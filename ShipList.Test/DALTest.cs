using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShipLists.DataAccess;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using ShipLists.Common;
using ShipLists.Model;
namespace ShipList.Test
{
    [TestClass]
    public class DALTest
    {
        [TestMethod]
        public void TestExecuteNonQueryProcedure()
        {
            string prName = "prInsertUser";
            Dictionary<string, Object> inParams = new Dictionary<string, object>();
            Dictionary<string, Object> outParams = new Dictionary<string, object>();

            inParams.Add("UserId", 4);
            inParams.Add("UserName", "老王");
            inParams.Add("Sex", "5");

            outParams.Add("MSG", string.Empty);
            //DataSet ds = BaseDAL.ExecuteQueryProcedure(prName, inParams, outParams);
            // DataSet ds1 = BaseDAL.ExecuteQuery(prName, inParams);
            string msg = string.Empty;
            BaseDAL.ExecuteNonQueryProcedure(prName, inParams, outParams, ref msg);
           
        }
        [TestMethod]
        public void TestExecuteQueryProcedure()
        {
            string prName = "prGetUsers";
            Dictionary<string, Object> inParams = new Dictionary<string, object>();

            inParams.Add("UserId", 4);           
          
            List<User> list= BaseDAL.ExecuteQueryProcedure<User>(prName, inParams, ClassType.GetType("User"));
        }
    }
}
