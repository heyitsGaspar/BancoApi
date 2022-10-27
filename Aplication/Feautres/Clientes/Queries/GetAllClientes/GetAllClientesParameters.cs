using Aplication.Parameters;


namespace Aplication.Feautres.Clientes.Queries.GetAllClientes
{
    public class GetAllClientesParameters : RequestParameter
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
