using System;

namespace DesignDatabaseConncetion
{
    public class OracleConnection : DbConnection
    {
        private bool _status = false;

        public OracleConnection(string connection) : base(connectionString: connection)
        {
            
        }

        public override void OpenConnection()
        {
            if (_status)
            {
                Console.WriteLine("Oracle connection is already open.");
            }
                Console.WriteLine("Oracle connection is open.");
                _status = true;

        }

        public override void CloseConnection()
        {
            if (_status)
            {
                Console.WriteLine("Oracle connection is closed.");
                _status = false;
            }
            else
            {
                Console.WriteLine("Oracle connection cannot be closed because it is not open.");
            }

        }
    }
}