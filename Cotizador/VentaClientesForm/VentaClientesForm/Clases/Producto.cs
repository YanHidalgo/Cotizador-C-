using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaClientesForm
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal CPP { get; set; }
        public double MargenPorcentajeAdi { get; set; }
        public double MargenValordicional { get; set; }
        public double MargenPorcentajeIVA { get; set; }
        public double MargenValorIVA { get; set; }

        // Constructor de la clase
        public Producto(string codigo, string descripcion, decimal cpp,
                        double margenPorcentajeAdi, double margenValorAdicional,
                        double margenPorcentajeIVA, double margenValorIVA)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            CPP = cpp;
            MargenPorcentajeAdi = 0.20;
            MargenValordicional = 1.12;
            MargenPorcentajeIVA = 0.19;
            MargenValorIVA = 1.19;
        }

        public Producto()
        {
        }
    }
}
