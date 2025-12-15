using System.Text;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        private readonly CD_Proveedor oCD_Proveedor = new CD_Proveedor();
        public List<CE_Proveedor> Listar(out string mensaje)
        {
            return oCD_Proveedor.Listar(out mensaje);
        }
        public int Crear(CE_Proveedor oProveedor, out string mensaje)
        {
            var errores = new StringBuilder();

            //Validaciones de campos del formulario.
            if(string.IsNullOrWhiteSpace(oProveedor.RazonSocial))
                errores.AppendLine("Ingrese la razón social.");

            if (errores.Length > 0)
            {
                mensaje = "Se encontraron los siguientes errores:\n\n" + errores.ToString();
                return 0;
            }

            return oCD_Proveedor.Crear(oProveedor, out mensaje);
        }
        public bool Actualizar(CE_Proveedor oProveedor, out string mensaje)
        {
            var errores = new StringBuilder();

            //Validaciones de campos del formulario.
            if(string.IsNullOrWhiteSpace(oProveedor.RazonSocial))
                errores.AppendLine("Ingrese la razón social.");

            if (errores.Length > 0)
            {
                mensaje = "Se encontraron los siguientes errores:\n\n" + errores.ToString();
                return false;
            }

            return oCD_Proveedor.Actualizar(oProveedor, out mensaje);
        }
        public bool Eliminar(CE_Proveedor oProveedor, out string mensaje)
        {
            return oCD_Proveedor.Eliminar(oProveedor, out mensaje);
        }
    }
}
