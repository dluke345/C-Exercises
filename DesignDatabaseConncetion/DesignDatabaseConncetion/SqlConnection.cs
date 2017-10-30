using System;

namespace DesignDatabaseConncetion
{
    public class SqlConnection : DbConnection
    {
        private bool _status = false;

        public SqlConnection(string connection) :base(connectionString: connection)
        {

        }

        public override void OpenConnection()
        {
            if (_status)
            {
                Console.WriteLine("Sql connection is already open.");
            }
            Console.WriteLine("Sql Connection is open.");
            _status = true;
        }

        public override void CloseConnection()
        {
            if (_status)
            {
                Console.WriteLine("Sql Connection is closed.");
                _status = false;
            }
            else
            {
                Console.WriteLine("Sql connection cannot be closed because it is NOT open.");
            }

        }
    }
}