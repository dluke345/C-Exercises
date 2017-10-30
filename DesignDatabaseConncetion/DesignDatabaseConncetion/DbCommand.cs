using System;

namespace DesignDatabaseConncetion
{
    public class DbCommand 
    {
        private string Instruction { get; set; }
        private DbConnection Connection { get; set; }

        public DbCommand(DbConnection connection, string instruction)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(Instruction) || !String.IsNullOrWhiteSpace(connection.ToString()))
                {
                    Instruction = instruction;
                    Connection = connection;
                }
                else
                {
                    throw new InvalidOperationException("Instructions or DbConnection are null or empty.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Execute()
        {
            Connection.OpenConnection();
            Console.WriteLine("This is the instruction: " + Instruction);
            Connection.CloseConnection();
        }
    }
}