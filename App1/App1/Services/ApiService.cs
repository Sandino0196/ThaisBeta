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
            lista.Add(new Productos() { CodigoProducto = 3, Descripcion = "Downy", Imagen = "DownyLogo" });
            lista.Add(new Productos() { CodigoProducto = 4, Descripcion = "Suavitel", Imagen = "SuavitelLogo" });
            lista.Add(new Productos() { CodigoProducto = 5, Descripcion = "Rexona", Imagen = "RexonaLogo" });
            lista.Add(new Productos() { CodigoProducto = 6, Descripcion = "Axe", Imagen = "AxeLogo" });
            lista.Add(new Productos() { CodigoProducto = 7, Descripcion = "Pantene", Imagen = "PanteneLogo" });           
            lista.Add(new Productos() { CodigoProducto = 8, Descripcion = "Dove", Imagen = "DoveLogo" });
            lista.Add(new Productos() { CodigoProducto = 9, Descripcion = "Head & Shoulders", Imagen = "HeadShouldersLogo" });
            lista.Add(new Productos() { CodigoProducto = 10, Descripcion = "TRESemmé", Imagen = "TresemmeLogo" });
            lista.Add(new Productos() { CodigoProducto = 11, Descripcion = "Sedal", Imagen = "SedalLogo" });
            lista.Add(new Productos() { CodigoProducto = 12, Descripcion = "Savile", Imagen = "SavileLogo" });
            lista.Add(new Productos() { CodigoProducto = 13, Descripcion = "Producto Baño", Imagen = "BanoLogo" });
            lista.Add(new Productos() { CodigoProducto = 14, Descripcion = "Gel Xtreme", Imagen = "XtremeLogo" });
            lista.Add(new Productos() { CodigoProducto = 15, Descripcion = "Abarroteria", Imagen = "AbarroteriaLogo" });
            lista.Add(new Productos() { CodigoProducto = 16, Descripcion = "Smarty Baby", Imagen = "SmartyBabyLogo" });
            lista.Add(new Productos() { CodigoProducto = 17, Descripcion = "Senior", Imagen = "SeniorLogo" });
            lista.Add(new Productos() { CodigoProducto = 18, Descripcion = "Lucky Gummys", Imagen = "LuckGummysLogo" });
            lista.Add(new Productos() { CodigoProducto = 19, Descripcion = "Globos", Imagen = "GlobosLogo" });

            return lista;
        }

        public List<Lote> ProductosDulce()
        {
            var lista = new List<Lote>();
            lista.Add(new Lote() { CodigoProducto = 101, Descripcion = "Chicle Vitolero", Imagen = "GlobosLogo" ,DescripcionLote = "9 botes, 120 unidades c/u", Precio=0 });
            lista.Add(new Lote() { CodigoProducto = 102, Descripcion = "Milky Way Minis", Imagen = "GlobosLogo", DescripcionLote = "12 botes, 52 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 103, Descripcion = "M&M's Minis", Imagen = "GlobosLogo", DescripcionLote = "12 botes, 52 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 104, Descripcion = "Snickers Barras", Imagen = "GlobosLogo", DescripcionLote = "8 displays, 52 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 105, Descripcion = "Crayon Manzana", Imagen = "GlobosLogo", DescripcionLote = "12 paquetes, 10 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 106, Descripcion = "Crayon Mango", Imagen = "GlobosLogo", DescripcionLote = "12 paquetes, 10 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 107, Descripcion = "Crayon Fresa", Imagen = "GlobosLogo", DescripcionLote = "12 paquetes, 10 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 108, Descripcion = "Crayon Uva", Imagen = "GlobosLogo", DescripcionLote = "12 paquetes, 10 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 109, Descripcion = "Pachicleta", Imagen = "GlobosLogo", DescripcionLote = "10 unidades Ristra", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 110, Descripcion = "Pachicleta", Imagen = "GlobosLogo", DescripcionLote = "20 unidades Bolsa", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 111, Descripcion = "Trident Cool Bubble", Imagen = "GlobosLogo", DescripcionLote = "12 paquetes, 12 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 112, Descripcion = "Trident Fresh Mint", Imagen = "GlobosLogo", DescripcionLote = "12 paquetes, 12 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 113, Descripcion = "Trident Menta", Imagen = "GlobosLogo", DescripcionLote = "12 paquetes, 12 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 114, Descripcion = "Trident Sandia", Imagen = "GlobosLogo", DescripcionLote = "12 paquetes, 12 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 115, Descripcion = "Trident Yerbabuena", Imagen = "GlobosLogo", DescripcionLote = "12 paquetes, 12 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 116, Descripcion = "Trident Fresa", Imagen = "GlobosLogo", DescripcionLote = "30 paquetes, 18 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 117, Descripcion = "Trident Fresa/Frutilla y Limon", Imagen = "GlobosLogo", DescripcionLote = "10 paquetes, 18 displays c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 118, Descripcion = "Trident Menta y Vainilla", Imagen = "GlobosLogo", DescripcionLote = "10 paquetes, 18 displays c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 119, Descripcion = "Trident Uva y Naranja", Imagen = "GlobosLogo", DescripcionLote = "10 paquetes, 18 displays c/u", Precio = 0 });
            return lista;
        }

        public List<Lote> ProductosHogar()
        {
            var lista = new List<Lote>();
            lista.Add(new Lote() { CodigoProducto = 201, Descripcion = "Glade Jardin Campestre", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 202, Descripcion = "Glade Hawaiian Breeze", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 203, Descripcion = "Glade Campos de Lavanda", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 204, Descripcion = "Glade Manzana y Canela", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 205, Descripcion = "Glade Frescura Matinal", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 206, Descripcion = "Glade Floral Perfection", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 207, Descripcion = "Glade Vainilla", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 208, Descripcion = "Baygon Ultra", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 209, Descripcion = "Oko Multiusos", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 200ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 210, Descripcion = "Oko Multiusos", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 211, Descripcion = "Raid MAX", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 212, Descripcion = "Raid Casa y Jardin", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 213, Descripcion = "Raid Mata Moscas y Mosquitos", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 214, Descripcion = "Raid Mata Cucarachas, Moscas y Mosquitos", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            return lista;
        }

        public List<Lote> ProductosDowny()
        {
            var lista = new List<Lote>();
            lista.Add(new Lote() { CodigoProducto = 301, Descripcion = "Romance", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 800ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 302, Descripcion = "Elegance", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 800ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 303, Descripcion = "Floral", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 800ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 304, Descripcion = "Naturals", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 800ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 305, Descripcion = "Passion", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 800ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 306, Descripcion = "Brisca Fresca", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 800ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 307, Descripcion = "Pureza Silvestre", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 800ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 308, Descripcion = "Durazno", Imagen = "GlobosLogo", DescripcionLote = "6 unidades de 3 Litros por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 309, Descripcion = "Elegance", Imagen = "GlobosLogo", DescripcionLote = "6 unidades de 3 Litros por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 310, Descripcion = "Passion", Imagen = "GlobosLogo", DescripcionLote = "6 unidades de 3 Litros por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 311, Descripcion = "Tango", Imagen = "GlobosLogo", DescripcionLote = "6 unidades de 3 Litros por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 312, Descripcion = "Floral", Imagen = "GlobosLogo", DescripcionLote = "6 unidades de 3 Litros por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 313, Descripcion = "Brisa Fresca", Imagen = "GlobosLogo", DescripcionLote = "6 unidades de 3 Litros por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 314, Descripcion = "Flor de Luna", Imagen = "GlobosLogo", DescripcionLote = "6 unidades de 3 Litros por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 315, Descripcion = "Pureza Silvestre", Imagen = "GlobosLogo", DescripcionLote = "6 unidades de 3 Litros por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 316, Descripcion = "Floral", Imagen = "GlobosLogo", DescripcionLote = "8.5 Litros por unidad", Precio = 0 });
            return lista;
        }

        public List<Lote> ProductosSuavitel()
        {
            var lista = new List<Lote>();
            lista.Add(new Lote() { CodigoProducto = 401, Descripcion = "Fresa y Chocolate", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 402, Descripcion = "Aqua", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 850ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 403, Descripcion = "Abrazo de sol", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 404, Descripcion = "Aroma de Durazno", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 850ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 405, Descripcion = "Orquideas Blancas", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 850ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 406, Descripcion = "Toronja y Flor de Cereza", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 407, Descripcion = "Primavera", Imagen = "GlobosLogo", DescripcionLote = "4 unidades de 3 Litros por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 408, Descripcion = "Aroma de Sol", Imagen = "GlobosLogo", DescripcionLote = "4 unidades de 3 Litros por caja", Precio = 0 });
            return lista;
        }

        public List<Lote> ProductosAxe()
        {
            var lista = new List<Lote>();
            lista.Add(new Lote() { CodigoProducto = 501, Descripcion = "Black Night", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 502, Descripcion = "Dark Temptation", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 503, Descripcion = "Anarchy", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 504, Descripcion = "Black", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 505, Descripcion = "Collision", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 506, Descripcion = "Gold Temptation", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 507, Descripcion = "Excite", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 508, Descripcion = "You", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 509, Descripcion = "Conviction", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 510, Descripcion = "Kilo + 25", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 115ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 511, Descripcion = "Collision + 25", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 115ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 512, Descripcion = "Young", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 513, Descripcion = "Anarchy for Her", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 514, Descripcion = "Dark Temptation Seco", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 515, Descripcion = "Black Seco", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 516, Descripcion = "Adrenaline", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 517, Descripcion = "Gold Temptation Seco", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 90ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 518, Descripcion = "Anarchy for Her + 25", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 115ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 519, Descripcion = "Apollo", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 54 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 520, Descripcion = "You", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 54 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 521, Descripcion = "Black", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 54 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 522, Descripcion = "Collision", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 54 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 523, Descripcion = "Dark Temptation", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 54 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 524, Descripcion = "Excite", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 54 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 525, Descripcion = "Gold", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 54 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 526, Descripcion = "Kilo", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 54 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 527, Descripcion = "Dark Temptation Value Pack", Imagen = "GlobosLogo", DescripcionLote = "18 unidades de 90ml por caja", Precio = 0 });
            return lista;
        }

        public List<Lote> ProductosRexona()
        {
            var lista = new List<Lote>();
            lista.Add(new Lote() { CodigoProducto = 601, Descripcion = "Cobalt Dry", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 90 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 602, Descripcion = "Super Hero", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 90 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 603, Descripcion = "Antibacterial", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 90 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 604, Descripcion = "Invisible", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 90 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 605, Descripcion = "V8", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 90 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 606, Descripcion = "Active Amotion", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 105 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 607, Descripcion = "Extra Fresh", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 90 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 608, Descripcion = "Sexy Bouquet", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 90 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 609, Descripcion = "Antibacterial", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 90 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 610, Descripcion = "Antibacterial", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 48 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 611, Descripcion = "Powder Dry", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 48 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 612, Descripcion = "Bamboo", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 48 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 613, Descripcion = "Active Motion", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 48 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 614, Descripcion = "Invisible", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 48 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 615, Descripcion = "Nutritive", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 48 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 616, Descripcion = "Extra Fresh", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 48 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 617, Descripcion = "Xtra Cool", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 50 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 618, Descripcion = "V8", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 50 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 619, Descripcion = "Antibacterial", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 50 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 620, Descripcion = "Active Dry", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 50 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 621, Descripcion = "Fanatics", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 50 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 622, Descripcion = "Sensitive", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 50 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 623, Descripcion = "Super Hero", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 50 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 624, Descripcion = "Invisible", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 50 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 625, Descripcion = "Antibacterial + Invisible", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 50 gramos por caja", Precio = 0 });
            return lista;
        }

        public List<Lote> ProductosDove()
        {
            var lista = new List<Lote>();
            lista.Add(new Lote() { CodigoProducto = 701, Descripcion = "Acondicionador Control Caida", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 702, Descripcion = "Acondicionador Oleo Nutricion", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 703, Descripcion = "Acondicionador Puntas Reconstruidas", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 704, Descripcion = "Acondicionador Reconstruccion Completa", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 705, Descripcion = "Shampoo Control Caida", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 706, Descripcion = "Shampoo Oleo Nutricion", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 707, Descripcion = "Shampoo Puntas Reconstruidas", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 708, Descripcion = "Shampoo Reconstruccion Completa", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 709, Descripcion = "Antitranspirante Clear Tone", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 45 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 710, Descripcion = "Antitranspirante Dermo Aclarant", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 45 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 711, Descripcion = "Antitranspirante Original", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 45 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 712, Descripcion = "Antitranspirante Clear Tone", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 96ml gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 713, Descripcion = "Antitranspirante Dermo Aclarant", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 96ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 714, Descripcion = "Antitranspirante Original", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 96ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 715, Descripcion = "Antitranspirante Go Fresh Pepino y Te Verde", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 96ml por caja", Precio = 0 });
            return lista;
        }

        public List<Lote> ProductosHS()
        {
            var lista = new List<Lote>();
            lista.Add(new Lote() { CodigoProducto = 701, Descripcion = "Shampoo Limpieza Renovadora", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 702, Descripcion = "Shampoo Proteccion Caida", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 703, Descripcion = "Shampoo Alivio Refrescante", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 704, Descripcion = "Shampoo con Old Spice", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 705, Descripcion = "Shampoo 3 en 1 Men", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 706, Descripcion = "Shampoo Manzana Fresh", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 707, Descripcion = "Shampoo Fuerza Rejuvenecedora", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 708, Descripcion = "Shampoo Relax Control Comezon", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 709, Descripcion = "Shampoo Suave y Manejable", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 400ml por caja", Precio = 0 });
            return lista;
        }

        public List<Lote> ProductosTRES()
        {
            var lista = new List<Lote>();
            lista.Add(new Lote() { CodigoProducto = 801, Descripcion = "Shampoo Control Caida", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 802, Descripcion = "Shampoo Keratin Smooth", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 803, Descripcion = "Shampoo Rizos Perfectos", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 804, Descripcion = "Shampoo Repair Rituals", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 805, Descripcion = "Shampoo Oil Radiante", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 806, Descripcion = "Shampoo Liso y Sedoso", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 807, Descripcion = "Shampoo Split Remedy", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 808, Descripcion = "Shampoo Proteccion Termica", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 809, Descripcion = "Acondicionador Keratin Smooth", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 810, Descripcion = "Acondicionador Blindaje Platinum", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 811, Descripcion = "Acondicionador Oil Radiante", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 812, Descripcion = "Acondicionador Hidratacion Profunda", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 813, Descripcion = "Acondicionador Repair Rituals", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 814, Descripcion = "Acondicionador Liso y Sedoso", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 815, Descripcion = "Acondicionador Split Remedy", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            return lista;
        }

        public List<Lote> ProductosSedal()
        {
            var lista = new List<Lote>();
            lista.Add(new Lote() { CodigoProducto = 901, Descripcion = "Acondicionador Caida", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 902, Descripcion = "Acondicionador Hidratacion Ligera", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 903, Descripcion = "Acondicionador Liso Perfecto", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 904, Descripcion = "Acondicionador Miel y Germen de Trigo", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 905, Descripcion = "Acondicionador Rizos Definidos", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 906, Descripcion = "Acondicionador Yuya", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 907, Descripcion = "Crema Anti Sponge", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 300ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 908, Descripcion = "Crema Brillo Gloss", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 300ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 909, Descripcion = "Crema Hidratacion Ligera", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 300ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 910, Descripcion = "Crema Liso Perfecto", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 300ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 911, Descripcion = "Crema Restauracion Instantanea", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 300ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 912, Descripcion = "Crema Yuya", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 300ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 913, Descripcion = "Crema Rizos Definidos", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 300ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 914, Descripcion = "Shampoo Anti-Nudos", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 650ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 915, Descripcion = "Shampoo Rizos Definidos", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 650ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 916, Descripcion = "Shampoo Yuya", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 650ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 917, Descripcion = "Shampoo Caida", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 650ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 918, Descripcion = "Shampoo Ceramidas", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 650ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 919, Descripcion = "Shampoo Liso Perfecto", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 650ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 920, Descripcion = "Shampoo Restauracion Instantanea", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 650ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 921, Descripcion = "Shampoo Anti-Nudos", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 922, Descripcion = "Shampoo Brillo y Suavidad", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 923, Descripcion = "Shampoo Brillo Gloss", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 924, Descripcion = "Shampoo Anti-Quiebre", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 925, Descripcion = "Shampoo Keratina", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 926, Descripcion = "Shampoo Liso Perfecto", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 927, Descripcion = "Shampoo Miel y Germen de Trigo", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 928, Descripcion = "Shampoo Bombaa Argan", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 929, Descripcion = "Shampoo Hidratacion Ligera", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 340ml por caja", Precio = 0 });
            return lista;
        }

        public List<Lote> ProductosCaprice()
        {
            var lista = new List<Lote>();
            lista.Add(new Lote() { CodigoProducto = 1001, Descripcion = "Shampoo Anticaspa", Imagen = "GlobosLogo", DescripcionLote = "15 unidades de 220ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1002, Descripcion = "Shampoo Anticerami", Imagen = "GlobosLogo", DescripcionLote = "15 unidades de 220ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1003, Descripcion = "Shampoo Biotina", Imagen = "GlobosLogo", DescripcionLote = "15 unidades de 220ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1004, Descripcion = "Shampoo Control Caida", Imagen = "GlobosLogo", DescripcionLote = "15 unidades de 220ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1005, Descripcion = "Shampoo Herbal", Imagen = "GlobosLogo", DescripcionLote = "15 unidades de 220ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1006, Descripcion = "Shampoo Maxigloss", Imagen = "GlobosLogo", DescripcionLote = "15 unidades de 220ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1007, Descripcion = "Shampoo Proteccion y Crecimiento", Imagen = "GlobosLogo", DescripcionLote = "15 unidades de 220ml por caja", Precio = 0 });
            return lista;
        }

        public List<Lote> ProductosSavile()
        {
            var lista = new List<Lote>();
            lista.Add(new Lote() { CodigoProducto = 1101, Descripcion = "Shampoo Chile", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1102, Descripcion = "Shampoo Biotina", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1103, Descripcion = "Shampoo Aceite de Argan", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1104, Descripcion = "Shampoo Keratina", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1105, Descripcion = "Shampoo Miel 2 en 1", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1106, Descripcion = "Shampoo Colageno", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1107, Descripcion = "Shampoo Rizos Radiantes", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1108, Descripcion = "Shampoo Aguacate", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 750ml por caja", Precio = 0 });
            return lista;
        }

        public List<Lote> ProductosBano()
        {
            var lista = new List<Lote>();
            lista.Add(new Lote() { CodigoProducto = 1201, Descripcion = "Jabon Palmolive Aloe", Imagen = "GlobosLogo", DescripcionLote = "72 unidades de 160 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1202, Descripcion = "Jabon Palmolive Fusion Nutritiva", Imagen = "GlobosLogo", DescripcionLote = "72 unidades de 180 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1203, Descripcion = "Jabon Palmolive Hidratacion Radiante", Imagen = "GlobosLogo", DescripcionLote = "72 unidades de 180 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1204, Descripcion = "Jabon Palmolive Intensa Renovacion", Imagen = "GlobosLogo", DescripcionLote = "72 unidades de 180 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1205, Descripcion = "Jabon Palmolive Oliva", Imagen = "GlobosLogo", DescripcionLote = "92 unidades de 110 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1206, Descripcion = "Jabon Palmolive Petalos", Imagen = "GlobosLogo", DescripcionLote = "92 unidades de 110 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1207, Descripcion = "Jabon Palmolive Purificante y Frescura", Imagen = "GlobosLogo", DescripcionLote = "72 unidades de 180 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1208, Descripcion = "Jabon Palmolive Sensacion Humectante", Imagen = "GlobosLogo", DescripcionLote = "72 unidades de 180 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1209, Descripcion = "Jabon Palmolive Sensacion Nutrituva", Imagen = "GlobosLogo", DescripcionLote = "72 unidades de 180 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1210, Descripcion = "Jabon Palmolive Suavidad Exfoliante", Imagen = "GlobosLogo", DescripcionLote = "72 unidades de 180 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1211, Descripcion = "Jabon Palmolive Suavidad Relajante", Imagen = "GlobosLogo", DescripcionLote = "72 unidades de 180 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1212, Descripcion = "Jabon Palmolive Suavidad Radiante", Imagen = "GlobosLogo", DescripcionLote = "72 unidades de 180 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1213, Descripcion = "Gel Ego", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 120ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1214, Descripcion = "Desodorante Gillette Cool Wave", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 85 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1215, Descripcion = "Desodorante Gillette Power Rush", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 85 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1216, Descripcion = "Colgate Maxima Proteccion", Imagen = "GlobosLogo", DescripcionLote = "75 unidades de 72ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1217, Descripcion = "Colgate Total", Imagen = "GlobosLogo", DescripcionLote = "144 unidades de 50ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1218, Descripcion = "Colgate Triple Accion", Imagen = "GlobosLogo", DescripcionLote = "72 unidades de 75ml por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1219, Descripcion = "Jabon Camay", Imagen = "GlobosLogo", DescripcionLote = "72 unidades de 150 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1220, Descripcion = "Jabon Pequeño Camay", Imagen = "GlobosLogo", DescripcionLote = "96 unidades de 100 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1221, Descripcion = "Jabon Dove Go Fresh", Imagen = "GlobosLogo", DescripcionLote = "48 unidades de 135 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1222, Descripcion = "Jabon Dove Original", Imagen = "GlobosLogo", DescripcionLote = "48 unidades de 135 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1223, Descripcion = "Jabon Dove Rosa", Imagen = "GlobosLogo", DescripcionLote = "48 unidades de 135 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1224, Descripcion = "Gel Xtreme", Imagen = "GlobosLogo", DescripcionLote = "24 unidades de 125 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1225, Descripcion = "Gel Xtreme", Imagen = "GlobosLogo", DescripcionLote = "3 unidades de 2200 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1226, Descripcion = "Gel Xtreme", Imagen = "GlobosLogo", DescripcionLote = "24 unidades de 250 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1227, Descripcion = "Gel Xtreme", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 450 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1228, Descripcion = "Gel Xtreme", Imagen = "GlobosLogo", DescripcionLote = "6 unidades de 1 kilogramo por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1229, Descripcion = "Gel Xtreme Sachet", Imagen = "GlobosLogo", DescripcionLote = "30 unidades de 6 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1230, Descripcion = "Gel Xtreme Squeeze", Imagen = "GlobosLogo", DescripcionLote = "12 unidades de 500 gramos por caja", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 1231, Descripcion = "Gel Xtreme 4 Kilos", Imagen = "GlobosLogo", DescripcionLote = "6 unidades de 4 kilogramos por caja", Precio = 0 });

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
