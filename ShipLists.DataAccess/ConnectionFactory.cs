using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipLists.DataAccess
{
   public class ConnectionFactory
    {
       private readonly static string connectionString = "";

       private static ConnectionFactory connFactory = null;

       private ConnectionFactory(){}

       public static ConnectionFactory GetConnectionFactoryInstance()
       {
           if (null == connFactory) connFactory = new ConnectionFactory();
           return connFactory;
       }
       /// <summary>
       ///  获取连接对象 
       /// </summary>
       /// <returns></returns>
       public DbConnection GetConnection()
       {
          return new MySqlConnection(connectionString);
       }

    }
}
