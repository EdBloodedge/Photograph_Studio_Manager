using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto_estudio
{
    public class ConnectionPostgreSQL
    {
        //String para conexion
        private const string ConnectionString = "Host=localhost;Port=5432;Username=postgres;Password=Usuario;Database=StudioDB";

        public NpgsqlConnection CreateConnection()
        {
            return new NpgsqlConnection(ConnectionString);
        }
    }
}
