using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate.Section5 {
    public abstract class DbConnection {
        private string ConnectionString;
        private TimeSpan Timeout;

        public DbConnection(string connectionString) {
            if (String.IsNullOrEmpty(connectionString)) {
                throw new InvalidOperationException();
            }
            this.ConnectionString = connectionString;
        }
        public abstract void OpenConnection();
        public abstract void CloseConnection();


    }
}
