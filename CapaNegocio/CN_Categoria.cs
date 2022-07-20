using System.Collections.Generic;
//Lo que agregue:
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
        } //Retorna la lista que tiene la clase CD_Categoria de la capa de datos.
        public int Crear(CE_Categoria oCategoria, out string mensaje)
        {
            mensaje = string.Empty;

            //Validaciones de campos del formulario.
            if (oCategoria.Nombre == "")
                mensaje += "Ingrese un nombre de categoria.\n";
            //Va concatenando con saltos de linea los mensajes de error que surjan.

            if (mensaje == string.Empty)
                return oCD_Categoria.Crear(oCategoria, out mensaje);
            else
                return 0;
        }
        public bool Actualizar(CE_Categoria oCategoria, out string mensaje)
        {
            mensaje = string.Empty;

            //Validaciones de campos del formulario.
            if (oCategoria.Nombre == "")
                mensaje += "Ingrese un nombre de categoria.\n";
            //Va concatenando con saltos de linea los mensajes de error que surjan.

            if (mensaje == string.Empty)
                return oCD_Categoria.Actualizar(oCategoria, out mensaje);
            else
                return false;
        }
        public bool Eliminar(CE_Categoria oCategoria, out string mensaje)
        {
            return oCD_Categoria.Eliminar(oCategoria, out mensaje);
        }
    }
}
