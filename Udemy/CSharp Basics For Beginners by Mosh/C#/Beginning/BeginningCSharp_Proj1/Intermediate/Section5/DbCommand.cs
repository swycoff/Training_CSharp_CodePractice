using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate.Section5 {
    public class DbCommand {
        DbConnection DbConnection;
        string InstructionForDB;
        public DbCommand(DbConnection dbConnection, string instructionForDB) {
            // A DbCommand cannot be in a valid state without having a connection
            if (dbConnection != null) {
                this.DbConnection = dbConnection;
            }

            //Each DbCommand should also have the instruction to be sent to the database.
            //In case of SQL Server, this instruction is expressed in T-SQL language.
            //Use a string to represent this instruction. Again, a command cannot be in a valid state without this instruction
            if (String.IsNullOrEmpty(instructionForDB)) {
                throw new InvalidOperationException();
            }
            this.InstructionForDB = instructionForDB;
        }

            public void Open() {
            DbConnection.OpenConnection();
            }
        public void Run() {
            Console.WriteLine("We ran the command from DbConnection: " + InstructionForDB);
        }
        public void Close() {
            DbConnection.CloseConnection();
            }
    }
}
