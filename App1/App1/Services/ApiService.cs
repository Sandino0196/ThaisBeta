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
