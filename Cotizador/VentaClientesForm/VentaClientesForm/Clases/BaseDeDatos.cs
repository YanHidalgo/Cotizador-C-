using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaClientesForm
{
    public static class BaseDeDatos
    {
        public static List<Producto> ProductosDePrueba()
        {
            return new List<Producto>()
            {
                new Producto()
                {Codigo = "7800007176394", Descripcion = "Naproxeno Sodico 550mg, 10 comprimidos", CPP = 1001M},
                new Producto()
                {Codigo = "7800007806901", Descripcion = "Citalopram 20mg, 30 comprimidos", CPP = 1239M},
                new Producto()
                {Codigo = "7804650880677", Descripcion = "Losartan Potasico 50mg, 30 comprimidos", CPP = 590M},
                new Producto()
                {Codigo = "8903726208847", Descripcion = "Quetiapina 100mg, 30 comprimidos", CPP = 1800M},
                new Producto()
                {Codigo = "7804620833467", Descripcion = "Omeprazol 20mg, 30 cápsulas", CPP = 582M},
                new Producto()
                {Codigo = "7800046004887", Descripcion = "Bropavol Bromhexina CL 8mg/5ml, jarabe", CPP = 1758M},
                new Producto()
                {Codigo = "7800063330648", Descripcion = "Brontec Hedera Helix 35mg/5ml, jarabe", CPP = 1453M},
                new Producto()
                {Codigo = "7800050002794", Descripcion = "Gesidol Paracetamol 120mg/5ml, jarabe", CPP = 2950M}
            };
        }

        public static string ObtenerCostoFormateado(decimal costoUnitario)
        {
            return costoUnitario.ToString("C"); // Formatea el costo unitario como moneda
        }
    }
}

