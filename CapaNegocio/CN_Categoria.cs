using System.Collections.Generic;
using System.Text;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private readonly CD_Categoria oCD_Categoria = new CD_Categoria();
        public List<CE_Categoria> Listar()
        {
            return oCD_Categoria.Listar();
        }
        public int Crear(CE_Categoria oCategoria, out string mensaje)
        {
            var errores = new StringBuilder();

            if (string.IsNullOrWhiteSpace(oCategoria.Nombre))
                errores.AppendLine("Ingrese un nombre de categoría.");

            if (oCategoria.oAlicuotaIVA == null || oCategoria.oAlicuotaIVA.Id < 1)
                errores.AppendLine("Seleccione una alícuota IVA.");

            if (errores.Length > 0)
            {
                mensaje = "Se encontraron los siguientes errores:\n\n" + errores.ToString();
                return 0;
            }
            
            return oCD_Categoria.Crear(oCategoria, out mensaje);
        }
        public bool Actualizar(CE_Categoria oCategoria, out string mensaje)
        {
            var errores = new StringBuilder();

            if (string.IsNullOrWhiteSpace(oCategoria.Nombre))
                errores.AppendLine("Ingrese un nombre de categoría.");

            if (oCategoria.oAlicuotaIVA == null || oCategoria.oAlicuotaIVA.Id < 1)
                errores.AppendLine("Seleccione una alícuota IVA.");

            if (errores.Length > 0) { 
                mensaje = "Se encontraron los siguientes errores:\n\n" + errores.ToString();
                return false;
            }
            
            return oCD_Categoria.Actualizar(oCategoria, out mensaje);
        }
        public bool Eliminar(CE_Categoria oCategoria, out string mensaje)
        {
            return oCD_Categoria.Eliminar(oCategoria, out mensaje);
        }
    }
}
