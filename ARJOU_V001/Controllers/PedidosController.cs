using ARJOU_V001.Areas.Identity.Data;
using ARJOU_V001.Data;
using ARJOU_V001.Models;
using ARJOU_V001.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ARJOU_V001.Controllers
{
    //3
    public class PedidosController : Controller
    {
        private readonly PedidoContext _context;
        //4
        private readonly IWebHostEnvironment _environment;
        //5
        private readonly UserContext _userContext;
        private readonly UserManager<User> _userManager;
        public PedidosController(PedidoContext context, IWebHostEnvironment environment, UserContext userContext, UserManager<User> userManager)
        {
            _context = context;
            //6
            _environment = environment;

            _userContext = userContext;
            _userManager = userManager;
        }
        //10
        // GET: Pedidoss
        public async Task<IActionResult> Index(string o, string bPedidos, string bEstados, DateTime? bFechaDesde, DateTime? bFechaHasta)
        {
            //Obtén el UserId del usuario actual
            var currentUserId = _userManager.GetUserId(User);



            var pedidos = from lista in _context.PedidoSet
                          select lista;

            // Si el usuario tiene el rol "user", filtra los pedidos por su UserId
            if (User.IsInRole("Usuario"))
            {
                pedidos = pedidos.Where(p => p.UserId == currentUserId);
            }

            // Filtrar por estados
            IQueryable<string> estadoQuery = from lista in _context.PedidoSet
                                             orderby lista.Estado
                                             select lista.Estado;

            // Filtrar por fechas
            IQueryable<DateTime> fechaQuery = from lista in _context.PedidoSet
                                              orderby lista.FechaSolicitud
                                              select lista.FechaSolicitud;

            // Definir orden de la vista
            ViewData["Orden"] = String.IsNullOrEmpty(o) || o == "fechaDesc" ? "fechaAsc" : "fechaDesc";

            // Ordenar según el parámetro 'o'
            switch (o)
            {
                case "fechaDesc":
                    pedidos = pedidos.OrderByDescending(p => p.FechaSolicitud);
                    break;
                case "fechaAsc":
                    pedidos = pedidos.OrderBy(p => p.FechaSolicitud);
                    break;
                default:
                    pedidos = pedidos.OrderBy(p => p.FechaSolicitud);  // Orden predeterminado por fecha ascendente
                    break;
            }

            if (!String.IsNullOrEmpty(bPedidos))
            {
                if (int.TryParse(bPedidos, out int idPedido))
                {
                    pedidos = pedidos.Where(p => p.Id == idPedido);
                }
            }

            // Búsqueda por estado del pedido
            if (!String.IsNullOrEmpty(bEstados))
            {
                pedidos = pedidos.Where(p => p.Estado == bEstados);
            }

            // Filtro por rango de fechas (opcional)
            if (bFechaDesde.HasValue)
            {
                pedidos = pedidos.Where(p => p.FechaSolicitud >= bFechaDesde.Value);
            }
            if (bFechaHasta.HasValue)
            {
                pedidos = pedidos.Where(p => p.FechaSolicitud <= bFechaHasta.Value);
            }

            // Crear el ViewModel con los filtros aplicados
            PedidoBuscaVM modeloBusqueda = new PedidoBuscaVM()
            {
                LosEstados = new SelectList(await estadoQuery.Distinct().ToListAsync()),  // Filtro por estado
                LasFechas = new SelectList(await fechaQuery.Distinct().ToListAsync()),  // Filtro por fecha
                LosPedidos = await pedidos.ToListAsync()  // Resultado de la búsqueda
            };

            return View(modeloBusqueda);

        }



        // GET: Pedidoss/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.PedidoSet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        // GET: Pedidoss/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pedidoss/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EstiloDeseado,ColorDeseado,LongitudDeseada,DescripcionAdicional,PrecioEstimado,FechaSolicitud,Estado")] PedidoVM pedidoVM, IFormFile Referencia)
        {
            if (Referencia == null || Referencia.Length == 0)
            {
                ModelState.AddModelError("Referencia", "La imagen de referencia es obligatoria.");
            }
            if (ModelState.IsValid)
            {
                //Obtener el UserId del usuario actual
                var currentUserId = _userManager.GetUserId(User);

                if (string.IsNullOrEmpty(currentUserId) || !_userContext.Users.Any(u => u.Id == currentUserId))
                {
                    ModelState.AddModelError("", "Usuario no encontrado.");
                    return View(pedidoVM);
                }
                Console.WriteLine($"Current User ID: {currentUserId}");


                string nombreArchivo = DateTime.Now.ToString("yyyyMMddHHmmssfff") + Path.GetExtension(Referencia.FileName);

                // Guardar la nueva imagen en la carpeta /images/
                string rutaImagen = Path.Combine(_environment.WebRootPath, "images", nombreArchivo);
                using (var stream = new FileStream(rutaImagen, FileMode.Create))
                {
                    await Referencia.CopyToAsync(stream);
                }
                // Crear una instancia del modelo Pedido a partir del ViewModel
                var pedido = new Pedido
                {
                    EstiloDeseado = pedidoVM.EstiloDeseado,
                    ColorDeseado = pedidoVM.ColorDeseado,
                    LongitudDeseada = pedidoVM.LongitudDeseada,
                    DescripcionAdicional = pedidoVM.DescripcionAdicional,
                    PrecioEstimado = 0.00M,
                    FechaSolicitud = DateTime.Now,
                    Estado = "Cotizando",
                    ImagenReferencia = nombreArchivo,
                    UserId = currentUserId
                };

                // Agregar el pedido al contexto y guardar cambios
                _context.Add(pedido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(pedidoVM);
        }


        // GET: Pedidoss/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.PedidoSet.FindAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }
            return View(pedido);
        }

        // POST: Pedidoss/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EstiloDeseado,ColorDeseado,LongitudDeseada,DescripcionAdicional,PrecioEstimado,Estado")] PedidoVM pedidoVM, IFormFile Referencia)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Recuperar el pedido actual de la base de datos
                    var pedidoActual = await _context.PedidoSet.FindAsync(id);
                    if (pedidoActual == null)
                    {
                        return NotFound();
                    }

                    // Verificar si hay una imagen nueva
                    string nombreArchivo = pedidoActual.ImagenReferencia; // Mantener la imagen existente por defecto
                    if (Referencia != null && Referencia.Length > 0)
                    {
                        // Generar un nombre único para la nueva imagen
                        nombreArchivo = DateTime.Now.ToString("yyyyMMddHHmmssfff") + Path.GetExtension(Referencia.FileName);

                        // Guardar la nueva imagen en la carpeta /images/
                        string rutaImagen = Path.Combine(_environment.WebRootPath, "images", nombreArchivo);
                        using (var stream = new FileStream(rutaImagen, FileMode.Create))
                        {
                            await Referencia.CopyToAsync(stream);
                        }

                        // Eliminar la imagen antigua si existe
                        if (!string.IsNullOrEmpty(pedidoActual.ImagenReferencia))
                        {
                            string rutaImagenAntigua = Path.Combine(_environment.WebRootPath, "images", pedidoActual.ImagenReferencia);
                            if (System.IO.File.Exists(rutaImagenAntigua))
                            {
                                System.IO.File.Delete(rutaImagenAntigua);
                            }
                        }
                    }

                    // Actualizar los campos del pedido existente
                    pedidoActual.EstiloDeseado = pedidoVM.EstiloDeseado;
                    pedidoActual.ColorDeseado = pedidoVM.ColorDeseado;
                    pedidoActual.LongitudDeseada = pedidoVM.LongitudDeseada;
                    pedidoActual.DescripcionAdicional = pedidoVM.DescripcionAdicional;
                    pedidoActual.PrecioEstimado = pedidoVM.PrecioEstimado;
                    pedidoActual.FechaSolicitud = DateTime.Now; // Actualizar la fecha a la actual
                    pedidoActual.Estado = pedidoVM.Estado;
                    pedidoActual.ImagenReferencia = nombreArchivo; // Actualizar la referencia de la imagen

                    // Guardar los cambios en la base de datos
                    _context.Update(pedidoActual);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidoExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            return View(pedidoVM);
        }



        // GET: Pedidoss/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.PedidoSet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        // POST: Pedidoss/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // Buscar el pedido a eliminar
            var pedido = await _context.PedidoSet.FindAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }

            // Verificar si existe una imagen y eliminarla físicamente
            if (!string.IsNullOrEmpty(pedido.ImagenReferencia))
            {
                string rutaImagen = Path.Combine(_environment.WebRootPath, "images", pedido.ImagenReferencia);
                if (System.IO.File.Exists(rutaImagen))
                {
                    System.IO.File.Delete(rutaImagen);
                }
            }

            // Eliminar el pedido de la base de datos
            _context.PedidoSet.Remove(pedido);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [Authorize(Roles = "Usuario")]
        public async Task<IActionResult> ConfirmarPedido(int id)
        {
            var pedido = await _context.PedidoSet.FindAsync(id);
            if (pedido == null || pedido.UserId != _userManager.GetUserId(User) || pedido.ConfirmadoPorUsuario || pedido.PrecioEstimado == 0)
            {
                return NotFound();
            }

            // Confirmación del pedido
            pedido.ConfirmadoPorUsuario = true;
            _context.Update(pedido);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        private bool PedidoExists(int id)
        {
            return _context.PedidoSet.Any(e => e.Id == id);
        }
    }
}
