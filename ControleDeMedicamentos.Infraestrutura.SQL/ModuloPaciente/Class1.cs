using System.Data;

namespace ControleDeMedicamentos.Infraestrutura.SQL.ModuloPaciente
{
    public class RepositorioPacienteEmSql
    {
        public RepositorioPacienteEmSql(IDbConnection connection)
        {
            this.connection = connection;
        }
    }
}
