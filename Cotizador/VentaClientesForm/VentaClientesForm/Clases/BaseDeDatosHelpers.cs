using System.Collections.Generic;
using VentaClientesForm;

internal static class BaseDeDatosHelpers
{
    public static List<Producto> ProductosDePrueba()
    {
        return new List<Producto>()
            {
                new Producto()
                {Codigo = "7800007176394", Descripcion = "Naproxeno Sodico 550mg, 10 comprimidos", CPP = 2.390M},
                new Producto()
                {Codigo = "7800007806901", Descripcion = "Citalopram 20mg, 30 comprimidos", CPP = 3.990M},
                new Producto()
                {Codigo = "7804650880677", Descripcion = "Losartan Potasico 50mg, 30 comprimidos", CPP = 1.890M},
                new Producto()
                {Codigo = "8903726208847", Descripcion = "Quetiapina 100mg, 30 comprimidos", CPP = 8.990M},
                new Producto()
                {Codigo = "7804620833467", Descripcion = "Omeprazol 20mg, 30 cápsulas", CPP = 1.990M},
                new Producto()
                {Codigo = "7800046004887", Descripcion = "Bropavol Bromhexina CL 8mg/5ml, jarabe", CPP = 3.390M},
                new Producto()
                {Codigo = "7800063330648", Descripcion = "Brontec Hedera Helix 35mg/5ml, jarabe", CPP = 2.890M},
                new Producto()
                {Codigo = "7800050002794", Descripcion = "Gesidol Paracetamol 120mg/5ml, jarabe", CPP = 5.990M}
            };
    }
}