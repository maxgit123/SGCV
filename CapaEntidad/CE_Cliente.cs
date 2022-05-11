namespace CapaEntidad
{
    public class CE_Cliente
    {
        public int IdCliente { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public CE_RespIVA oRespIVA { get; set; }
        //En vez de hacer referencia a ID_RespIVA se hace a la clase.
    }
}
