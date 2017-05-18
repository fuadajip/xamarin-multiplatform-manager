using SQLite.Net.Attributes;
using System;

namespace MoneySQLite
{
    public class Transaction
    {
        [PrimaryKey, AutoIncrement]
        public long TransId { get; set; }
        [NotNull]
        public string TransName { get; set; }
        public string Amount { get; set; }

        public string Date { get; set; }
        public string Desc { get; set; }
    }
}
