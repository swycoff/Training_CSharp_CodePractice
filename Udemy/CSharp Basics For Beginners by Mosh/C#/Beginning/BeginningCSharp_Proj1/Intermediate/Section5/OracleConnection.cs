using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate.Section5 {
    class OracleConnection : DbConnection {

        public OracleConnection(string connectionString) : base(connectionString) {

        }

        public override void OpenConnection() {
            Console.WriteLine("The connection has been opened: OracleConnection ");
        }
        public override void CloseConnection() {
            Console.WriteLine("The Connection has been closed: OracleConnection ");
        }
    }
}
