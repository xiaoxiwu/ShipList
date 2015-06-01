using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ShipLists.DataAccess
{
   public class ConnectionFactory
    {
       private readonly static string connectionString = ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;

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
       public MySqlConnection GetConnection()
       {
          return new MySqlConnection(connectionString);
       }

    }
}
