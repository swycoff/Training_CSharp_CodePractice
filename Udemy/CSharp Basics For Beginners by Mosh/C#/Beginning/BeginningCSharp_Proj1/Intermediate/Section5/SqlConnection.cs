using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate.Section5 {
    class SqlConnection : DbConnection {

        public SqlConnection(string connectionString) : base(connectionString) {
           
        }

        public override void OpenConnection() {
            Console.WriteLine("The connection has been opened: SqlConnection");
        }
        public override void CloseConnection() {
            Console.WriteLine("The Connection has been closed: SqlConnection");
        }
    }
}
