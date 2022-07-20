using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        private readonly CD_Proveedor oCD_Proveedor = new CD_Proveedor();
        public List<CE_Proveedor> Listar()
        {
            return oCD_Proveedor.Listar();
        }
        public int Crear(CE_Proveedor oProveedor, out string mensaje)
        {
            mensaje = string.Empty;

            //Validaciones de campos del formulario.
            if (oProveedor.RazonSocial == "")
                mensaje += "Ingrese la razón social.\n";

            if (mensaje == string.Empty)
                return oCD_Proveedor.Crear(oProveedor, out mensaje);
            else
                return 0;
        }
        public bool Actualizar(CE_Proveedor oProveedor, out string mensaje)
        {
            mensaje = string.Empty;

            if (oProveedor.RazonSocial == "")
                mensaje += "Ingrese la razón social.\n";

            if (mensaje == string.Empty)
                return oCD_Proveedor.Actualizar(oProveedor, out mensaje);
            else
                return false;
        }
        public bool Eliminar(CE_Proveedor oProveedor, out string mensaje)
        {
            return oCD_Proveedor.Eliminar(oProveedor, out mensaje);
        }
    }
}
