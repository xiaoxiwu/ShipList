using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShipLists.DataAccess;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
namespace ShipList.Test
{
    [TestClass]
    public class DALTest
    {
        [TestMethod]
        public void TestExecuteQueryProcedure()
        {
            string prName = "prGetUsers";
            Dictionary<string, Object> inParams = new Dictionary<string, object>();
            Dictionary<string, Object> outParams = new Dictionary<string, object>();

            //DataSet ds = BaseDAL.ExecuteQueryProcedure(prName, inParams, outParams);
            // DataSet ds1 = BaseDAL.ExecuteQuery(prName, inParams);
           
        }
    }
}
