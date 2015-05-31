using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipLists.DataAccess
{
    public class BaseDAL
    {
        /// <summary>
        /// 无结果查询，适用于更新、插入以及删除
        /// </summary>
        /// <param name="cmdText">sql语句</param>
        /// <param name="inParms">输入参数</param>
        /// <returns>受影响行数</returns>
        public static int ExecuteNoneQuery(String cmdText, Dictionary<string, Object> inParms)
        {
            int result = 0;
            using (DbConnection conn = ConnectionFactory.GetConnectionFactoryInstance().GetConnection())
            {
                using (DbCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = cmdText;
                    AddInParameters(cmd, inParms);

                    cmd.Connection.Open();
                    result = cmd.ExecuteNonQuery();
                }
            }
            return result;
        }
        /// <summary>
        /// 执行SQL语句返回查询结果集
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cmdText"></param>
        /// <param name="inParms"></param>
        /// <param name="type">类型对象实例</param>
        /// <returns>List<T></returns>
        public static List<T> ExecuteQuery<T>(String cmdText, Dictionary<string, Object> inParms, Type type)
        {
            List<T> list = new List<T>();
            using (DbConnection conn = ConnectionFactory.GetConnectionFactoryInstance().GetConnection())
            {
                using (DbCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = cmdText;
                    AddInParameters(cmd, inParms);

                    cmd.Connection.Open();
                    DbDataReader dr=cmd.ExecuteReader();

                    int cloumns=dr.FieldCount;
                    string cloumnName = string.Empty;
                    while (dr.Read())
                    {
                        T obj = (T)Activator.CreateInstance(type, true);//根据类型创建实例
                        for (int i = 0; i < cloumns; i++)
                        {
                            cloumnName = dr.GetName(i);
                            type.GetProperty(cloumnName).SetValue(obj,dr.GetValue(i), null);
                        }
                        list.Add(obj);
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// 返回第1行第1列数据，一般用来查询count值
        /// </summary>
        /// <param name="cmdtext"></param>
        /// <param name="inParms"></param>
        /// <returns></returns>
        public static Object ExecuteScalar(String cmdText, Dictionary<string, Object> inParms)
        {
            object result = null;
            using (DbConnection conn = ConnectionFactory.GetConnectionFactoryInstance().GetConnection())
            {
                using (DbCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = cmdText;
                    AddInParameters(cmd, inParms);

                    cmd.Connection.Open();
                    result = cmd.ExecuteScalar();
                }
            }
            return result;
        }
        /// <summary>
        /// 执行查询类存储过程,返回结果集
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cmdText"></param>
        /// <param name="inParms"></param>
        /// <param name="outPrarms"></param>
        /// <param name="type"></param>
        /// <returns>List<T> </returns>
        public static List<T> ExecuteQueryProcedure<T>(String cmdText, Dictionary<string, Object> inParms, Dictionary<string, Object> outPrarms, Type type)
        {
            List<T> list = new List<T>();
            using (DbConnection conn = ConnectionFactory.GetConnectionFactoryInstance().GetConnection())
            {
                using (DbCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = cmdText;
                    cmd.CommandType = CommandType.StoredProcedure;

                    AddInParameters(cmd, inParms);
                    AddOutParameters(cmd, outPrarms);
                    cmd.Connection.Open();

                    DbDataReader dr = cmd.ExecuteReader();

                    int cloumns = dr.FieldCount;
                    string cloumnName = string.Empty;
                    while (dr.Read())
                    {
                        T obj = (T)Activator.CreateInstance(type, true);//根据类型创建实例
                        for (int i = 0; i < cloumns; i++)
                        {
                            cloumnName = dr.GetName(i);
                            type.GetProperty(cloumnName).SetValue(obj, dr.GetValue(i), null);
                        }
                        list.Add(obj);
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// 执行非查询类存储过程
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="inParms"></param>
        /// <param name="outPrarms"></param>
        /// <returns></returns>
        public static int ExecuteNonQueryProcedure(String cmdText, Dictionary<string, Object> inParms, Dictionary<string, Object> outPrarms)
        {
            int result = 0;
            using (DbConnection conn = ConnectionFactory.GetConnectionFactoryInstance().GetConnection())
            {
                using (DbCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = cmdText;
                    cmd.CommandType = CommandType.StoredProcedure;
                                        
                    AddInParameters(cmd, inParms);
                    AddOutParameters(cmd,outPrarms);
                    cmd.Connection.Open();
                    result = cmd.ExecuteNonQuery();
                }
            }
            return result;
        }
        /// <summary>
        /// 执行SQL语句返回查询结果集
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="inParms"></param>
        /// <returns>DataSet</returns>
        public static DataSet ExecuteQuery(String cmdText, Dictionary<string, Object> inParms)
        {
            DataSet ds = new DataSet();
            using (DbConnection conn = ConnectionFactory.GetConnectionFactoryInstance().GetConnection())
            {
                using (DbCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = cmdText;
                    AddInParameters(cmd, inParms);

                    DbDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;

                    da.Fill(ds);
                }
            }
            return ds;
        }
        /// <summary>
        /// 执行查询类存储过程,返回结果集
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="inParms"></param>
        /// <param name="outPrarms"></param>
        /// <returns>DataSet</returns>
        public static DataSet ExecuteQueryProcedure(String cmdText, Dictionary<string, Object> inParms, Dictionary<string, Object> outPrarms)
        {
            DataSet ds = new DataSet();
            using (DbConnection conn = ConnectionFactory.GetConnectionFactoryInstance().GetConnection())
            {
                using (DbCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = cmdText;
                    AddInParameters(cmd, inParms);
                    AddOutParameters(cmd, outPrarms);

                    DbDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;

                    da.Fill(ds);
                }
            }
            return ds;
        }

        /// <summary>
        /// 添加输入参数
        /// </summary>
        /// <param name="sqlCmd"></param>
        /// <param name="parms"></param>
        private static void AddInParameters(DbCommand sqlCmd, Dictionary<string, Object> parms)
        {
            if (null != parms && parms.Count > 0)
            {
                foreach (KeyValuePair<string, Object> entry in parms)
                {
                    MySqlParameter paramter = new MySqlParameter(entry.Key, entry.Value);
                    sqlCmd.Parameters.Add(paramter);
                }
            }
        }
        /// <summary>
        /// 添加输出参数
        /// </summary>
        /// <param name="sqlCmd"></param>
        /// <param name="parms"></param>
        private static void AddOutParameters(DbCommand sqlCmd, Dictionary<string, Object> parms)
        {
            if (null != parms && parms.Count > 0)
            {
                foreach (KeyValuePair<string, Object> entry in parms)
                {
                    MySqlParameter paramter = new MySqlParameter(entry.Key, MySqlDbType.String, 100);
                    paramter.Direction = ParameterDirection.Output;
                    sqlCmd.Parameters.Add(paramter);
                }
            }
        }
   }
}
