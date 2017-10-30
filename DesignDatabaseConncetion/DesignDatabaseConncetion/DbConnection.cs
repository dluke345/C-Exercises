using System;

namespace DesignDatabaseConncetion
{
    public abstract class DbConnection
    {
        private string ConnectionString { get; set; }
        private TimeSpan Timeout { get; set; }

        protected DbConnection(string connectionString)
        {
            try
            {
                if (!String.IsNullOrEmpty(connectionString))
                {
                    ConnectionString = connectionString;
                    Timeout = new TimeSpan(0, 0, 0, 30);
                }
                else
                {
                    throw new InvalidOperationException("Connection String must not be null or empty");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();

    }
}