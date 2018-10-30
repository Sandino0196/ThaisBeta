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

        public List<Lote> ProductosAxe()
        {
            var lista = new List<Lote>();
            lista.Add(new Lote() { CodigoProducto = 101, Descripcion = "Chicle Vitolero", Imagen = "GlobosLogo" ,DescripcionLote = "9 botes, 120 unidades c/u", Precio=0 });
            lista.Add(new Lote() { CodigoProducto = 102, Descripcion = "Milky Way Minis", Imagen = "GlobosLogo", DescripcionLote = "12 botes, 52 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 103, Descripcion = "M&M's Minis", Imagen = "GlobosLogo", DescripcionLote = "12 botes, 52 unidades c/u", Precio = 0 });
            lista.Add(new Lote() { CodigoProducto = 104, Descripcion = "Snickers Minis", Imagen = "GlobosLogo", DescripcionLote = "12 botes, 52 unidades c/u", Precio = 0 });
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
