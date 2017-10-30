using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignDatabaseConncetion
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = new DbCommand(new SqlConnection("https:/sqlconnection"), "Select * from something");
            command.Execute();

            var command2 = new DbCommand(new OracleConnection("https:/oracleconnection"), "Select * from something");
            command2.Execute();
        }
    }
}
