using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net;
namespace MoneySQLite
{
    public interface INterfaceConnection
    {
        SQLiteConnection GetConnection();
    }
}
