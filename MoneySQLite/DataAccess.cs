using SQLite.Net;
using System.Collections.Generic;
using Xamarin.Forms;


namespace MoneySQLite
{
    public class DataAccess
    {
        SQLiteConnection dbConn;
        public DataAccess()
        {
            dbConn = DependencyService.Get<INterfaceConnection>().GetConnection();
            dbConn.CreateTable<Transaction>();
        }

        public List<Transaction> GetAllTransaction()
        {
            return dbConn.Query<Transaction>("SELECT * FROM [Transaction]");
        }
        public int GeTotalAmount()
        {
            return dbConn.ExecuteScalar<int>("SELECT sum(Amount) FROM [Transaction]");


        }
        public int SaveTransaction(Transaction aTransaction)
        {
            return dbConn.Insert(aTransaction);
        }
        public int DeleteTransaction(Transaction aTransaction)
        {
            return dbConn.Delete(aTransaction);
        }
        public int EditEmployee(Transaction aTransaction)
        {
            return dbConn.Update(aTransaction);
        }
    }
}
