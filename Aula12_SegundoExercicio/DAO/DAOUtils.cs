using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_SegundoExercicio.DAO
{
    public class DAOUtils
    {
        public static DbConnection GetConnection()
        {
            DbConnection conn = new MySqlConnection(@"Server=127.0.0.1;Database=Test;Uid=root;Pwd=1234;");
            conn.Open();

            return conn;
        }

        public static DbCommand GetCommand(DbConnection conn)
        {
            DbCommand command = conn.CreateCommand();
            return command;
        }

        public static DbDataReader GetDataReader(DbCommand command)
        {
            return command.ExecuteReader();
        }
    }
}
