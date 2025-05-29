using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private readonly CD_Producto oCD_Producto = new CD_Producto();
        public List<CE_Producto> Listar()
        {
            return oCD_Producto.Listar();
        } //Retorna la lista que tiene la clase CD_Producto de la capa de datos.
        public int Crear(CE_Producto oProducto, out string mensaje)
        {
            mensaje = string.Empty;

            //Validaciones de campos del formulario.
            if (oProducto.Descripcion == "")
                mensaje += "Ingrese la descripcion del producto.\n";
            //Va concatenando con saltos de linea los mensajes de error que surjan.

            if (mensaje == string.Empty)
                return oCD_Producto.Crear(oProducto, out mensaje);
            else
                return 0;
        }
        public bool Actualizar(CE_Producto oProducto, out string mensaje)
        {
            mensaje = string.Empty;

            //Validaciones de campos del formulario.
            if (oProducto.Descripcion == "")
                mensaje += "Ingrese la descripcion del producto.\n";
            //Va concatenando con saltos de linea los mensajes de error que surjan.

            if (mensaje == string.Empty)
                return oCD_Producto.Actualizar(oProducto, out mensaje);
            else
                return false;
        }
        public bool Eliminar(CE_Producto oProducto, out string mensaje)
        {
            return oCD_Producto.Eliminar(oProducto, out mensaje);
        }
    }
}
