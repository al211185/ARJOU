using ARJOU_V001.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace ARJOU_V001.ViewModels
{
    public class PedidoBuscaVM
    {
        //9
        public List<Pedido> LosPedidos { get; set; }
        public SelectList LosEstados { get; set; }
        public SelectList LasFechas { get; set; }

        public string BPedidos { get; set; }
        public string BEstados { get; set; }
        public DateTime? BFechas { get; set; }
        public DateTime? BFechaDesde { get; set; }
        public DateTime? BFechaHasta { get; set; }
    }
}
