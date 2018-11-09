using Plugin.Connectivity;
using System.Collections.Generic;
using System.Threading.Tasks;
using App1.Models;

namespace App1.Services
{
    public class ApiService
    {

        public List<Productos> Catalogo()
        {
            var lista = new List<Productos>();
            lista.Add(new Productos() { CodigoProducto = 1, Descripcion = "Dulces", Imagen = "DulcesLogo" });
            lista.Add(new Productos() { CodigoProducto = 2, Descripcion = "Producto Hogar", Imagen = "HogarLogo" });
            lista.Add(new Productos() { CodigoProducto = 3, Descripcion = "Producto Personal", Imagen = "BanoLogo" });
            lista.Add(new Productos() { CodigoProducto = 4, Descripcion = "Abarroteria", Imagen = "AbarroteriaLogo" });
            return lista;
        }

        public List<Lote> ProductosDulce()
        {
            var lista = new List<Lote>();
            lista.Add(new Lote() { CodigoProducto = 101, Descripcion = "Chicle Vitolero", Imagen = "ChicleV" ,DescripcionLote = "9 botes, 120 unidades c/u", Precio=0 });
            lista.Add(new Lote() { CodigoProducto = 102, Descripcion = "Milky Way Minis", Imagen = "MilkyMini", DescripcionLote = "12 botes, 52 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 103, Descripcion = "M&M's Minis", Imagen = "MMMinis", DescripcionLote = "12 botes, 52 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 104, Descripcion = "Snickers Minis", Imagen = "SnicMini", DescripcionLote = "12 botes, 52 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 105, Descripcion = "Snickers Barras", Imagen = "Snic", DescripcionLote = "8 displays, 52 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 106, Descripcion = "Crayon Manzana", Imagen = "Manzana", DescripcionLote = "12 paquetes, 10 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 107, Descripcion = "Crayon Mango", Imagen = "Mango", DescripcionLote = "12 paquetes, 10 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 108, Descripcion = "Crayon Fresa", Imagen = "FresaC", DescripcionLote = "12 paquetes, 10 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 109, Descripcion = "Crayon Uva", Imagen = "Uva", DescripcionLote = "12 paquetes, 10 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 110, Descripcion = "Pachicleta", Imagen = "Pac10", DescripcionLote = "10 unidades Ristra", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 111, Descripcion = "Pachicleta", Imagen = "Pac20", DescripcionLote = "20 unidades Bolsa", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 112, Descripcion = "Trident Cool Bubble", Imagen = "CoolB", DescripcionLote = "12 paquetes, 12 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 113, Descripcion = "Trident Fresh Mint", Imagen = "FreshM", DescripcionLote = "12 paquetes, 12 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 114, Descripcion = "Trident Menta", Imagen = "Menta", DescripcionLote = "12 paquetes, 12 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 115, Descripcion = "Trident Sandia", Imagen = "Sandia", DescripcionLote = "12 paquetes, 12 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 116, Descripcion = "Trident Yerbabuena", Imagen = "Yerba", DescripcionLote = "12 paquetes, 12 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 117, Descripcion = "Trident Fresa", Imagen = "FresaT", DescripcionLote = "30 paquetes, 18 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 118, Descripcion = "Trident Fresa/Frutilla y Limon", Imagen = "FresaLim", DescripcionLote = "10 paquetes, 18 displays c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 119, Descripcion = "Trident Menta y Vainilla", Imagen = "MentaVai", DescripcionLote = "10 paquetes, 18 displays c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 120, Descripcion = "Trident Uva y Naranja", Imagen = "UvaNar", DescripcionLote = "10 paquetes, 18 displays c/u", Precio = 0 });
            return lista;
        }

        public List<Lote> ProductosHogar()
        {
            var lista = new List<Lote>();
            lista.Add(new Lote() { CodigoProducto = 201, Descripcion = "Glade Jardin Campestre", Imagen = "GladeCamp", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 202, Descripcion = "Glade Hawaiian Breeze", Imagen = "GladeHawai", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 203, Descripcion = "Glade Campos de Lavanda", Imagen = "GladeLavanda", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 204, Descripcion = "Glade Manzana y Canela", Imagen = "GladeManzana", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 205, Descripcion = "Glade Frescura Matinal", Imagen = "GladeMatinal", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 206, Descripcion = "Glade Floral Perfection", Imagen = "GladeFloral", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 207, Descripcion = "Glade Vainilla", Imagen = "GladeVainilla", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });

            lista.Add(new Lote() { CodigoProducto = 208, Descripcion = "Baygon Ultra", Imagen = "Baygon", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 209, Descripcion = "Oko Multiusos", Imagen = "okoPe", DescripcionLote = "12 unidades de 200ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 210, Descripcion = "Oko Multiusos", Imagen = "okoGra", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });

            lista.Add(new Lote() { CodigoProducto = 211, Descripcion = "Raid MAX", Imagen = "RaidMax", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 212, Descripcion = "Raid Casa y Jardin", Imagen = "RaidCasa", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 213, Descripcion = "Raid Mata Moscas y Mosquitos", Imagen = "RaidMos", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 214, Descripcion = "Raid Mata Cucarachas, Moscas y Mosquitos", Imagen = "RaidCuca", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });

            lista.Add(new Lote() { CodigoProducto = 215, Descripcion = "Downy Elegance", Imagen = "DownyEleP", DescripcionLote = "12 unidades de 800ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 216, Descripcion = "Downy Floral", Imagen = "DownyFloralP", DescripcionLote = "12 unidades de 800ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 217, Descripcion = "Downy Naturals", Imagen = "DownyNatP", DescripcionLote = "12 unidades de 800ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 218, Descripcion = "Downy Pureza Silvestre", Imagen = "DownyPurG", DescripcionLote = "6 unidades de 3 Litros por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 219, Descripcion = "Downy Passion", Imagen = "DownyPassP", DescripcionLote = "12 unidades de 800ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 220, Descripcion = "Downy Romance", Imagen = "DownyRomG", DescripcionLote = "6 unidades de 3 Litros por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 221, Descripcion = "Downy Brisa Fresca", Imagen = "DownyBrisP", DescripcionLote = "12 unidades de 800ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 222, Descripcion = "Downy Brisa Fresca", Imagen = "DownyBrisG", DescripcionLote = "6 unidades de 3 Litros por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 223, Descripcion = "Downy Flor de Luna", Imagen = "DownyFlorG", DescripcionLote = "6 unidades de 3 Litros por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 224, Descripcion = "Downy Romance", Imagen = "DownyRomP", DescripcionLote = "12 unidades de 800ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 225, Descripcion = "Downy Pureza Silvestre", Imagen = "DownyPurP", DescripcionLote = "12 unidades de 800ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 226, Descripcion = "Downy Durazno", Imagen = "DownyDurG", DescripcionLote = "6 unidades de 3 Litros por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 227, Descripcion = "Downy Elegance", Imagen = "DownyEleG", DescripcionLote = "6 unidades de 3 Litros por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 228, Descripcion = "Downy Passion", Imagen = "DownyPassG", DescripcionLote = "6 unidades de 3 Litros por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 229, Descripcion = "Downy Tango", Imagen = "DownyTangoG", DescripcionLote = "6 unidades de 3 Litros por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 230, Descripcion = "Downy Floral", Imagen = "DownyFloralG", DescripcionLote = "6 unidades de 3 Litros por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 231, Descripcion = "Downy Floral", Imagen = "DownyFloralXXL", DescripcionLote = "8.5 Litros por unidad", Precio = 0 });

            lista.Add(new Lote() { CodigoProducto = 232, Descripcion = "Suavitel Fresa y Chocolate", Imagen = "SuaviFresa", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 233, Descripcion = "Suavitel Aqua", Imagen = "SuaviAqua", DescripcionLote = "12 unidades de 850ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 234, Descripcion = "Suavitel Abrazo de sol", Imagen = "SuaviAbrazo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 235, Descripcion = "Suavitel Aroma de Durazno", Imagen = "SuaviDur", DescripcionLote = "12 unidades de 850ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 236, Descripcion = "Suavitel Orquideas Blancas", Imagen = "SuaviOrquidea", DescripcionLote = "12 unidades de 850ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 237, Descripcion = "Suavitel Toronja y Flor de Cereza", Imagen = "SuaviToronja", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 238, Descripcion = "Suavitel Primavera", Imagen = "SuaviPrima", DescripcionLote = "4 unidades de 3 Litros por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 239, Descripcion = "Suavitel Aroma de Sol", Imagen = "SuaviSol", DescripcionLote = "4 unidades de 3 Litros por caja", Precio = 0 });
            return lista;
        }

        public List<Lote> ProductosBano()
        {
            var lista = new List<Lote>();
            lista.Add(new Lote() { CodigoProducto = 501, Descripcion = "Axe Black Night", Imagen = "AxeBN", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 502, Descripcion = "Axe Dark Temptation", Imagen = "AxeDT", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 503, Descripcion = "Axe Anarchy", Imagen = "AxeAnarchy", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 504, Descripcion = "Axe Black", Imagen = "AxeBlack", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 505, Descripcion = "Axe Collision", Imagen = "AxeCollision", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 506, Descripcion = "Axe Gold Temptation", Imagen = "AxeGT", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 507, Descripcion = "Axe Excite", Imagen = "AxeExcite", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 508, Descripcion = "Axe You", Imagen = "AxeYou", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 509, Descripcion = "Axe Conviction", Imagen = "AxeConviction", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 510, Descripcion = "Axe Kilo + 25", Imagen = "AxeKilo25", DescripcionLote = "12 unidades de 115ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 511, Descripcion = "Axe Collision + 25", Imagen = "AxeCollision25", DescripcionLote = "12 unidades de 115ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 512, Descripcion = "Axe Young", Imagen = "AxeYoung", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 513, Descripcion = "Axe Anarchy for Her", Imagen = "AxeAnarchyM", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 514, Descripcion = "Axe Dark Temptation Seco", Imagen = "AxeDTSeco", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 515, Descripcion = "Axe Black Seco", Imagen = "AxeBlackSeco", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 516, Descripcion = "Axe Adrenaline", Imagen = "AxeAdrenaline", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 517, Descripcion = "Axe Gold Temptation Seco", Imagen = "AxeDTSeco", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 518, Descripcion = "Axe Anarchy for Her + 25", Imagen = "AxeAnarchyM25", DescripcionLote = "12 unidades de 115ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 519, Descripcion = "Axe Apollo", Imagen = "AxeApolloB", DescripcionLote = "12 unidades de 54 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 520, Descripcion = "Axe You", Imagen = "AxeYouB", DescripcionLote = "12 unidades de 54 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 521, Descripcion = "Axe Black", Imagen = "AxeBlackB", DescripcionLote = "12 unidades de 54 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 522, Descripcion = "Axe Collision", Imagen = "AxeCollisionB", DescripcionLote = "12 unidades de 54 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 523, Descripcion = "Axe Dark Temptation", Imagen = "AxeDTB", DescripcionLote = "12 unidades de 54 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 524, Descripcion = "Axe Excite", Imagen = "AxeExciteB", DescripcionLote = "12 unidades de 54 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 525, Descripcion = "Axe Gold", Imagen = "AxeGoldB", DescripcionLote = "12 unidades de 54 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 526, Descripcion = "Axe Kilo", Imagen = "AxeKiloB", DescripcionLote = "12 unidades de 54 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 527, Descripcion = "Axe Dark Temptation Value Pack", Imagen = "AxeDTPaquete", DescripcionLote = "18 unidades de 90ml por caja", Precio = 0 });

            lista.Add(new Lote() { CodigoProducto = 601, Descripcion = "Rexona Cobalt Dry", Imagen = "RexonaCD", DescripcionLote = "12 unidades de 90 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 602, Descripcion = "Rexona Super Hero", Imagen = "RexonaSH", DescripcionLote = "12 unidades de 90 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 603, Descripcion = "Rexona Antibacterial + Invisible", Imagen = "RexonaAntiInvi", DescripcionLote = "12 unidades de 90 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 604, Descripcion = "Rexona Invisible", Imagen = "RexonaInvi", DescripcionLote = "12 unidades de 90 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 605, Descripcion = "Rexona V8", Imagen = "RexonaV8", DescripcionLote = "12 unidades de 90 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 606, Descripcion = "Rexona Active Emotion", Imagen = "RexonaAM", DescripcionLote = "12 unidades de 105 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 607, Descripcion = "Rexona Extra Fresh", Imagen = "RexonaEF", DescripcionLote = "12 unidades de 90 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 608, Descripcion = "Rexona Sexy Bouquet", Imagen = "RexonaSB", DescripcionLote = "12 unidades de 90 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 609, Descripcion = "Rexona Antibacterial", Imagen = "RexonaAnti", DescripcionLote = "12 unidades de 90 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 610, Descripcion = "Rexona Bamboo", Imagen = "RexonaBamboo", DescripcionLote = "12 unidades de 90 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 611, Descripcion = "Rexona Happy Morning", Imagen = "RexonaHM", DescripcionLote = "12 unidades de 90 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 612, Descripcion = "Rexona Invisible", Imagen = "RexonaInviM", DescripcionLote = "12 unidades de 90 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 613, Descripcion = "Rexona Powder Dry", Imagen = "RexonaPD", DescripcionLote = "12 unidades de 90 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 614, Descripcion = "Rexona Clinical Men", Imagen = "RexonaClinicalMen", DescripcionLote = "12 unidades de 48 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 615, Descripcion = "Rexona Clinical Classic", Imagen = "RexonaClinicalClassic", DescripcionLote = "12 unidades de 48 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 616, Descripcion = "Rexona Clinical Clen Scent", Imagen = "RexonaClinicalCS", DescripcionLote = "12 unidades de 48 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 617, Descripcion = "Rexona Antibacterial", Imagen = "RexonaAntiB", DescripcionLote = "12 unidades de 48 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 618, Descripcion = "Rexona Power Dry", Imagen = "RexonaPDB", DescripcionLote = "12 unidades de 48 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 619, Descripcion = "Rexona Bamboo", Imagen = "RexonaBambooB", DescripcionLote = "12 unidades de 48 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 620, Descripcion = "Rexona Active Emotion", Imagen = "RexonaAMB", DescripcionLote = "12 unidades de 48 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 621, Descripcion = "Rexona Invisible", Imagen = "RexonaInvisibleB", DescripcionLote = "12 unidades de 48 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 622, Descripcion = "Rexona Nutritive", Imagen = "RexonaNutritiveB", DescripcionLote = "12 unidades de 48 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 623, Descripcion = "Rexona Extra Fresh", Imagen = "RexonaEFB", DescripcionLote = "12 unidades de 48 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 624, Descripcion = "Rexona Xtra Cool", Imagen = "RexonaXCB", DescripcionLote = "12 unidades de 50 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 625, Descripcion = "Rexona V8", Imagen = "RexonaV8B", DescripcionLote = "12 unidades de 50 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 626, Descripcion = "Rexona Antibacterial", Imagen = "RexonaAntiHB", DescripcionLote = "12 unidades de 50 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 627, Descripcion = "Rexona Active Dry", Imagen = "RexonaADB", DescripcionLote = "12 unidades de 50 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 628, Descripcion = "Rexona Fanatics", Imagen = "RexonaFanaticsB", DescripcionLote = "12 unidades de 50 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 629, Descripcion = "Rexona Sensitive", Imagen = "RexonaSensitiveB", DescripcionLote = "12 unidades de 50 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 630, Descripcion = "Rexona Super Hero", Imagen = "RexonaSHB", DescripcionLote = "12 unidades de 50 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 631, Descripcion = "Rexona Invisible", Imagen = "RexonaInviB", DescripcionLote = "12 unidades de 50 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 632, Descripcion = "Rexona Antibacterial + Invisible", Imagen = "RexonaAntiInviB", DescripcionLote = "12 unidades de 50 gramos por caja", Precio = 0 });

            lista.Add(new Lote() { CodigoProducto = 701, Descripcion = "Acondicionador Dove Control Caida", Imagen = "DoveAcondicionadorCC", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 702, Descripcion = "Acondicionador Dove Oleo Nutricion", Imagen = "DoveAcondicionadorON", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 703, Descripcion = "Acondicionador Dove Puntas Reconstruidas", Imagen = "DoveAcondicionadorPR", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 704, Descripcion = "Acondicionador Dove Reconstruccion Completa", Imagen = "DoveAcondicionadorRC", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 705, Descripcion = "Shampoo Dove Control Caida", Imagen = "DoveShampooCC", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 706, Descripcion = "Shampoo Dove Oleo Nutricion", Imagen = "DoveShampooON", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 707, Descripcion = "Shampoo Dove Puntas Reconstruidas", Imagen = "DoveShampooPR", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 708, Descripcion = "Shampoo Dove Reconstruccion Completa", Imagen = "DoveShampooRC", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });

            lista.Add(new Lote() { CodigoProducto = 709, Descripcion = "Antitranspirante Dove Clear Tone", Imagen = "DoveCT", DescripcionLote = "12 unidades de 45 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 710, Descripcion = "Antitranspirante Dove Dermo Aclarant", Imagen = "DoveDA", DescripcionLote = "12 unidades de 45 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 711, Descripcion = "Antitranspirante Dove Original", Imagen = "DoveOriginal", DescripcionLote = "12 unidades de 45 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 712, Descripcion = "Antitranspirante Dove Clear Tone", Imagen = "DoveCTS", DescripcionLote = "12 unidades de 96ml gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 713, Descripcion = "Antitranspirante Dove Dermo Aclarant", Imagen = "DoveDAS", DescripcionLote = "12 unidades de 96ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 714, Descripcion = "Antitranspirante Dove Original", Imagen = "DoveOriginalS", DescripcionLote = "12 unidades de 96ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 715, Descripcion = "Antitranspirante Dove Go Fresh Pepino y Te Verde", Imagen = "DoveGoFresh", DescripcionLote = "12 unidades de 96ml por caja", Precio = 0 });

            lista.Add(new Lote() { CodigoProducto = 801, Descripcion = "Shampoo H&S Limpieza Renovadora", Imagen = "HeadLR", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 802, Descripcion = "Shampoo H&S Proteccion Caida", Imagen = "HeadPC", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 803, Descripcion = "Shampoo H&S Alivio Refrescante", Imagen = "HeadAR", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 804, Descripcion = "Shampoo H&S con Old Spice", Imagen = "HeadOS", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 805, Descripcion = "Shampoo H&S 3 en 1 Men", Imagen = "Head3en1", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 806, Descripcion = "Shampoo H&S Manzana Fresh", Imagen = "HeadMF", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 807, Descripcion = "Shampoo H&S Fuerza Rejuvenecedora", Imagen = "HeadFR", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 808, Descripcion = "Shampoo H&S Relax Control Comezon", Imagen = "HeadRCC", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 809, Descripcion = "Shampoo H&S Suave y Manejable", Imagen = "HeadSM", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });

            lista.Add(new Lote() { CodigoProducto = 901, Descripcion = "Shampoo Control Caida", Imagen = "TRESCC", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 902, Descripcion = "Shampoo Keratin Smooth", Imagen = "TRESKS", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 903, Descripcion = "Shampoo Rizos Perfectos", Imagen = "TRESRP", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 904, Descripcion = "Shampoo Repair Rituals", Imagen = "TRESRR", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 905, Descripcion = "Shampoo Oil Radiante", Imagen = "TRESOR", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 906, Descripcion = "Shampoo Liso y Sedoso", Imagen = "TRESLS", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 907, Descripcion = "Shampoo Split Remedy", Imagen = "TRESSR", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 908, Descripcion = "Shampoo Proteccion Termica", Imagen = "TRESPT", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 909, Descripcion = "Acondicionador Keratin Smooth", Imagen = "TRESAKS", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 910, Descripcion = "Acondicionador Blindaje Platinum", Imagen = "TRESABP", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 911, Descripcion = "Acondicionador Oil Radiante", Imagen = "TRESAOR", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 912, Descripcion = "Acondicionador Hidratacion Profunda", Imagen = "TRESAHP", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 913, Descripcion = "Acondicionador Repair Rituals", Imagen = "TRESARR", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 914, Descripcion = "Acondicionador Liso y Sedoso", Imagen = "TRESALS", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 915, Descripcion = "Acondicionador Split Remedy", Imagen = "TRESASR", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });

            lista.Add(new Lote() { CodigoProducto = 1001, Descripcion = "Acondicionador Sedal Caida", Imagen = "SedalAconCaida", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1002, Descripcion = "Acondicionador Sedal Hidratacion Ligera", Imagen = "SedalAconHL", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1003, Descripcion = "Acondicionador Sedal Liso Perfecto", Imagen = "SedalAconLP", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1004, Descripcion = "Acondicionador Sedal Miel y Germen de Trigo", Imagen = "SedalAconMiel", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1005, Descripcion = "Acondicionador Sedal Rizos Definidos", Imagen = "SedalAconRD", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1006, Descripcion = "Acondicionador Sedal Yuya", Imagen = "SedalAconYuya", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1007, Descripcion = "Crema Sedal Anti Sponge", Imagen = "SedalCremaAS", DescripcionLote = "12 unidades de 300ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1008, Descripcion = "Crema Sedal Brillo Gloss", Imagen = "SedalCremaBG", DescripcionLote = "12 unidades de 300ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1009, Descripcion = "Crema Sedal Hidratacion Ligera", Imagen = "SedalCremaHL", DescripcionLote = "12 unidades de 300ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1010, Descripcion = "Crema Sedal Liso Perfecto", Imagen = "SedalCremaLP", DescripcionLote = "12 unidades de 300ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1011, Descripcion = "Crema Sedal Restauracion Instantanea", Imagen = "SedalCremaRI", DescripcionLote = "12 unidades de 300ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1012, Descripcion = "Crema Sedal Yuya", Imagen = "SedalCremaYuya", DescripcionLote = "12 unidades de 300ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1013, Descripcion = "Crema Sedal Rizos Definidos", Imagen = "SedalCremaRD", DescripcionLote = "12 unidades de 300ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1014, Descripcion = "Shampoo Sedal Anti-Nudos", Imagen = "SedalShampooAN", DescripcionLote = "12 unidades de 650ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1015, Descripcion = "Shampoo Sedal Rizos Definidos", Imagen = "SedalShampooRD", DescripcionLote = "12 unidades de 650ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1016, Descripcion = "Shampoo Sedal Yuya", Imagen = "SedalShampooYuya", DescripcionLote = "12 unidades de 650ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1017, Descripcion = "Shampoo Sedal Caida", Imagen = "SedalShampooCaida", DescripcionLote = "12 unidades de 650ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1018, Descripcion = "Shampoo Sedal Ceramidas", Imagen = "SedalShampooCeramidas", DescripcionLote = "12 unidades de 650ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1019, Descripcion = "Shampoo Sedal Liso Perfecto", Imagen = "SedalShampooLP", DescripcionLote = "12 unidades de 650ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1020, Descripcion = "Shampoo Sedal Restauracion Instantanea", Imagen = "SedalShampooRI", DescripcionLote = "12 unidades de 650ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1021, Descripcion = "Shampoo Sedal Anti-Nudos", Imagen = "SedalShampooANP", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1022, Descripcion = "Shampoo Sedal Brillo y Suavidad", Imagen = "SedalShampooBSP", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1023, Descripcion = "Shampoo Sedal Brillo Gloss", Imagen = "SedalShampooBGP", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1024, Descripcion = "Shampoo Sedal Anti-Quiebre", Imagen = "SedalShampooAQP", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1025, Descripcion = "Shampoo Sedal Keratina", Imagen = "SedalShampooKeratinaP", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1026, Descripcion = "Shampoo Sedal Liso Perfecto", Imagen = "SedalShampooLPP", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1027, Descripcion = "Shampoo Sedal Miel y Germen de Trigo", Imagen = "SedalShampooMielP", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1028, Descripcion = "Shampoo Sedal Bombaa Argan", Imagen = "SedalShampooBAP", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1029, Descripcion = "Shampoo Sedal Hidratacion Ligera", Imagen = "SedalShampooHLP", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });

            lista.Add(new Lote() { CodigoProducto = 1101, Descripcion = "Shampoo Caprice Anticaspa", Imagen = "CapriceCaspa", DescripcionLote = "15 unidades de 220ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1102, Descripcion = "Shampoo Caprice Anticerami", Imagen = "CapriceAntiC", DescripcionLote = "15 unidades de 220ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1103, Descripcion = "Shampoo Caprice Biotina", Imagen = "CapriceBiotina", DescripcionLote = "15 unidades de 220ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1104, Descripcion = "Shampoo Caprice Control Caida", Imagen = "CapriceCC", DescripcionLote = "15 unidades de 220ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1105, Descripcion = "Shampoo Caprice Herbal", Imagen = "CapriceHerbal", DescripcionLote = "15 unidades de 220ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1106, Descripcion = "Shampoo Caprice Maxigloss", Imagen = "CapriceMaxi", DescripcionLote = "15 unidades de 220ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1107, Descripcion = "Shampoo Caprice Proteccion y Crecimiento", Imagen = "CapricePC", DescripcionLote = "15 unidades de 220ml por caja", Precio = 0 });

            lista.Add(new Lote() { CodigoProducto = 1201, Descripcion = "Shampoo Savile Chile", Imagen = "SavileChile", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1202, Descripcion = "Shampoo Savile Biotina", Imagen = "SavileBiotina", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1203, Descripcion = "Shampoo Savile Aceite de Argan", Imagen = "SavileAA", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1204, Descripcion = "Shampoo Savile Keratina", Imagen = "SavileKeratina", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1205, Descripcion = "Shampoo Savile Miel 2 en 1", Imagen = "SavileMiel", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1206, Descripcion = "Shampoo Savile Colageno", Imagen = "SavileColageno", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1207, Descripcion = "Shampoo Savile Rizos Radiantes", Imagen = "SavileRR", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1208, Descripcion = "Shampoo Savile Aguacate", Imagen = "SavileAguacate", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });

            lista.Add(new Lote() { CodigoProducto = 1301, Descripcion = "Jabon Palmolive Aloe", Imagen = "PalmoliveAloe", DescripcionLote = "72 unidades de 160 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1302, Descripcion = "Jabon Palmolive Fusion Nutritiva", Imagen = "PalmoliveFN", DescripcionLote = "72 unidades de 180 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1303, Descripcion = "Jabon Palmolive Hidratacion Radiante", Imagen = "PalmoliveHR", DescripcionLote = "72 unidades de 180 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1304, Descripcion = "Jabon Palmolive Intensa Renovacion", Imagen = "PalmoliveIR", DescripcionLote = "72 unidades de 180 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1305, Descripcion = "Jabon Palmolive Oliva", Imagen = "PalmoliveOliva", DescripcionLote = "92 unidades de 110 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1306, Descripcion = "Jabon Palmolive Petalos", Imagen = "PalmolivePetalos", DescripcionLote = "92 unidades de 110 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1307, Descripcion = "Jabon Palmolive Purificante y Frescura", Imagen = "PalmolivePF", DescripcionLote = "72 unidades de 180 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1308, Descripcion = "Jabon Palmolive Sensacion Humectante", Imagen = "PalmoliveSH", DescripcionLote = "72 unidades de 180 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1309, Descripcion = "Jabon Palmolive Sensacion Nutrituva", Imagen = "PalmoliveSN", DescripcionLote = "72 unidades de 180 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1310, Descripcion = "Jabon Palmolive Suavidad Exfoliante", Imagen = "PalmoliveSE", DescripcionLote = "72 unidades de 180 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1311, Descripcion = "Jabon Palmolive Suavidad Relajante", Imagen = "PalmoliveSRe", DescripcionLote = "72 unidades de 180 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1312, Descripcion = "Jabon Palmolive Suavidad Radiante", Imagen = "PalmoliveSRa", DescripcionLote = "72 unidades de 180 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1313, Descripcion = "Gel Ego", Imagen = "Ego", DescripcionLote = "12 unidades de 120ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1314, Descripcion = "Desodorante Gillette Cool Wave", Imagen = "GilleteCW", DescripcionLote = "12 unidades de 85 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1315, Descripcion = "Desodorante Gillette Power Rush", Imagen = "GilletePR", DescripcionLote = "12 unidades de 85 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1316, Descripcion = "Colgate Maxima Proteccion", Imagen = "ColgateMP", DescripcionLote = "75 unidades de 72ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1317, Descripcion = "Colgate Total", Imagen = "ColgateTotal", DescripcionLote = "144 unidades de 50ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1318, Descripcion = "Colgate Triple Accion", Imagen = "ColgateTA", DescripcionLote = "72 unidades de 75ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1319, Descripcion = "Jabon Camay", Imagen = "Camay", DescripcionLote = "72 unidades de 150 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1320, Descripcion = "Jabon Pequeño Camay", Imagen = "CamayP", DescripcionLote = "96 unidades de 100 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1321, Descripcion = "Jabon Dove Go Fresh", Imagen = "JabonDoveGoFresh", DescripcionLote = "48 unidades de 135 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1322, Descripcion = "Jabon Dove Original", Imagen = "JabonDoveOriginal", DescripcionLote = "48 unidades de 135 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1323, Descripcion = "Jabon Dove Rosa", Imagen = "JabonDoveRosa", DescripcionLote = "48 unidades de 135 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1324, Descripcion = "Gel Xtreme", Imagen = "Xtreme1", DescripcionLote = "24 unidades de 125 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1325, Descripcion = "Gel Xtreme", Imagen = "Xtreme2", DescripcionLote = "3 unidades de 2200 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1326, Descripcion = "Gel Xtreme", Imagen = "Xtreme3", DescripcionLote = "24 unidades de 250 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1327, Descripcion = "Gel Xtreme", Imagen = "Xtreme4", DescripcionLote = "12 unidades de 450 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1328, Descripcion = "Gel Xtreme", Imagen = "Xtreme5", DescripcionLote = "6 unidades de 1 kilogramo por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1329, Descripcion = "Gel Xtreme Sachet", Imagen = "Xtreme6", DescripcionLote = "30 unidades de 6 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1330, Descripcion = "Gel Xtreme Squeeze", Imagen = "Xtreme7", DescripcionLote = "12 unidades de 500 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1331, Descripcion = "Gel Xtreme 4 Kilos", Imagen = "Xtreme8Xtreme", DescripcionLote = "6 unidades de 4 kilogramos por caja", Precio = 0 });
            return lista;
        }

        public List<Lote> Abarroteria()
        {
            var lista = new List<Lote>();
            lista.Add(new Lote() { CodigoProducto = 1301, Descripcion = "Elote Dorado del Monte", Imagen = "Elote", DescripcionLote = "24 unidades de 225 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1301, Descripcion = "Chicharos del Monte", Imagen = "Chicharo1", DescripcionLote = "24 unidades de 225 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1301, Descripcion = "Chicharos del Monte", Imagen = "Chicharo2", DescripcionLote = "24 unidades de 400 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1301, Descripcion = "Ensalada de Verduras", Imagen = "Verdura", DescripcionLote = "24 unidades de 215 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1301, Descripcion = "Ensalada de Verduras", Imagen = "Verdura2", DescripcionLote = "24 unidades de 400 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1301, Descripcion = "Leche Condensada La Lechera", Imagen = "Lechera", DescripcionLote = "48 unidades de 100 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1301, Descripcion = "Leche Condensada La Lechera", Imagen = "Lechera2", DescripcionLote = "48 unidades de 100 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1301, Descripcion = "Leche en Polvo NAN 1", Imagen = "NAN1", DescripcionLote = "12 unidades de 1 kilogramo por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1301, Descripcion = "Leche en Polvo NAN 1 Optipro", Imagen = "NAN2", DescripcionLote = "12 unidades de 1 kilogramo por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1301, Descripcion = "Papel Higienico Monarca 450 hojas doble", Imagen = "Monarca", DescripcionLote = "12 unidades de 4 rollos por paquete", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1301, Descripcion = "Pasta Crest Anti-Caries", Imagen = "Crest", DescripcionLote = "36 unidades de 75ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1401, Descripcion = "Pañal Grande G4", Imagen = "PanalG", DescripcionLote = "50 unidades por paquete", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1402, Descripcion = "Pañal Mediano M3", Imagen = "PanalM", DescripcionLote = "52 unidades por paquete", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1403, Descripcion = "Pañal Pequeño P2", Imagen = "PanalP", DescripcionLote = "56 unidades por paquete", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1404, Descripcion = "Pañal XX Grande", Imagen = "PanalXX", DescripcionLote = "40 unidades por paquete", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1405, Descripcion = "Pañal XG Grande", Imagen = "PanalX", DescripcionLote = "46 unidades por paquete", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1406, Descripcion = "Toallitas Humedas", Imagen = "Toallita", DescripcionLote = "12 paquetes de 84 unidades", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1501, Descripcion = "Pañal para Adulto Pequeño", Imagen = "PanalAP", DescripcionLote = "4 paquetes de 10 unidades", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1502, Descripcion = "Pañal para Adulto Mediano", Imagen = "PanalAM", DescripcionLote = "4 paquetes de 10 unidades", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1503, Descripcion = "Pañal para Adulto Grande", Imagen = "PanalAG", DescripcionLote = "4 paquetes de 10 unidades", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Cubitos", Imagen = "LuckyCubo", DescripcionLote = "8 unidades de 1 kilogramo por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Gomitas", Imagen = "LuckyGoma", DescripcionLote = "8 unidades de 1 kilogramo por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Gotitas", Imagen = "LuckyGota", DescripcionLote = "8 unidades de 1 kilogramo por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Frutitas", Imagen = "LuckyFruta", DescripcionLote = "8 unidades de 1 kilogramo por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Corazones", Imagen = "LuckyCorazon", DescripcionLote = "8 unidades de 1 kilogramo por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Lombriz Neon", Imagen = "LuckyGusano", DescripcionLote = "8 unidades de 1 kilogramo por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Orugas", Imagen = "LuckyOruga", DescripcionLote = "8 unidades de 1 kilogramo por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Ositos", Imagen = "LuckyOso", DescripcionLote = "8 unidades de 1 kilogramo por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Lombrices", Imagen = "LuckyLombriz", DescripcionLote = "8 unidades de 1 kilogramo por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Aros de Manzano", Imagen = "LuckyAroMa", DescripcionLote = "8 unidades de 1 kilogramo por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Aros de Durazno", Imagen = "LuckyAroDu", DescripcionLote = "8 unidades de 1 kilogramo por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Azul bebe (Numero 7)", Imagen = "GloboAzulBebe", DescripcionLote = "50 bolsas de 100 unidades por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Aqua estandar (Numero 7 y 9)", Imagen = "GloboAquaEstandar", DescripcionLote = "50 bolsas de 100 unidades por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Azul estandar (Numero 7 y 9)", Imagen = "GloboAzulEstandar", DescripcionLote = "50 bolsas de 100 unidades por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Azul turquesa (Numero 7 y 9)", Imagen = "GloboAzulTurquesa", DescripcionLote = "50 bolsas de 100 unidades por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Coral (Numero 7 y 9)", Imagen = "GloboCoral", DescripcionLote = "50 bolsas de 100 unidades por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Fucsia (Numero 7 y 9)", Imagen = "GloboFucsia", DescripcionLote = "50 bolsas de 100 unidades por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Lavanda (Numero 7 y 9)", Imagen = "GloboLavanda", DescripcionLote = "50 bolsas de 100 unidades por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Rojo (Numero 7 y 9)", Imagen = "GloboRojo", DescripcionLote = "50 bolsas de 100 unidades por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Rosa (Numero 7 y 9)", Imagen = "GloboRosa", DescripcionLote = "50 bolsas de 100 unidades por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Durazno (Numero 9)", Imagen = "GloboDurazno", DescripcionLote = "50 bolsas de 100 unidades por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Naranja (Numero 7 y 9)", Imagen = "GloboNaranja", DescripcionLote = "50 bolsas de 100 unidades por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Mostaza (Numero 7 y 9)", Imagen = "GloboMostaza", DescripcionLote = "50 bolsas de 100 unidades por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Dorado (Numero 9)", Imagen = "GloboDorado", DescripcionLote = "50 bolsas de 100 unidades por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Amarillo estandar (Numero 7 y 9)", Imagen = "GloboAmarillo", DescripcionLote = "50 bolsas de 100 unidades por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Lima (Numero 7 y 9)", Imagen = "GloboLima", DescripcionLote = "50 bolsas de 100 unidades por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Verde (Numero 7 y 9)", Imagen = "GloboVerde", DescripcionLote = "50 bolsas de 100 unidades por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Negro estandar (Numero 9)", Imagen = "GloboNegroEstandar", DescripcionLote = "50 bolsas de 100 unidades por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Plateado estandar (Numero 9)", Imagen = "GloboPlateadoEstandar", DescripcionLote = "50 bolsas de 100 unidades por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Blanco estandar (Numero 7 y 9)", Imagen = "GloboBlancoEstandar", DescripcionLote = "50 bolsas de 100 unidades por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1601, Descripcion = "Globo Rifa", Imagen = "GlobosLogo", DescripcionLote = "50 cartones de 140 unidades por caja", Precio = 0 });
            return lista;
        }        

        public async Task<Response> CheckConnection()
        {
            if(!CrossConnectivity.Current.IsConnected)
            {
                return new Response
                    {
                        IsSuccess = false,
                        Message = "Por favor, revise su configuracion de internet"
                    };
            }

            var isReachable = await CrossConnectivity.Current.IsRemoteReachable("google.com");
            if(!isReachable)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "Por favor, revise su conexion a internet"
                };
                }

            return new Response
            {
                IsSuccess = true,
                Message = "Ok"
            };
        }
    }
}
