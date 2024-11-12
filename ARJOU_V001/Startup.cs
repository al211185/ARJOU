using ARJOU_V001.Areas.Identity.Data;
using ARJOU_V001.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace ARJOU_V001
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PedidoContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("PedidoCon")));

            services.AddDbContext<UserContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("UserContextConnection")));

            services.AddControllersWithViews();

        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public async void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

            using (var scope = app.ApplicationServices.CreateScope())
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();

                // Definición de los datos del nuevo administrador
                string email = "arjou3@admin.com";
                string clienteTelefono = "6567828767";
                string nombre = "ARJOU";
                string apellido = "Admin";
                string direccion = "Cd. Juárez";
                string rol = "Admin";
                string contraseña = "Arjou123!";

                // Comprobar si ya existe un usuario con este email
                var existingUser = await userManager.FindByEmailAsync(email);

                if (existingUser == null)
                {
                    // Crear un nuevo usuario
                    var user = new User
                    {
                        UserName = email,
                        Email = email,
                        PhoneNumber = clienteTelefono,
                        Nombre = nombre,
                        Apellido = apellido,
                        Direccion = direccion,
                        Rol = rol // Si esta propiedad se va a usar, asegúrate de que esté implementada correctamente
                    };

                    // Crear el usuario
                    var result = await userManager.CreateAsync(user, contraseña);
                    if (result.Succeeded)
                    {
                        // Asignar el rol al usuario
                        await userManager.AddToRoleAsync(user, rol);
                    }
                }
            }



        }
    }
}
