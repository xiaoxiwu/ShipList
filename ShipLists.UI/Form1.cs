using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShipLists.DataAccess;
using ShipLists.Model;
using System.Configuration;
using System.Reflection;
using ShipLists.Common;

namespace ShipLists.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string prName = "prGetUsers";
            Dictionary<string, Object> inParams = new Dictionary<string, object>();
            Dictionary<string, Object> outParams = new Dictionary<string, object>();

            //DataSet ds = BaseDAL.ExecuteQueryProcedure(prName, inParams, outParams);
           // DataSet ds1 = BaseDAL.ExecuteQuery(prName, inParams);
          
            //List<User> list = BaseDAL.ExecuteQueryProcedure<User>(prName,inParams,u.GetType());


            Type type = ClassType.GetType("User");
            inParams.Add("UserId", 4);
            inParams.Add("UserName", "laowang");
            inParams.Add("Sex", "2");
            outParams.Add("MSG", string.Empty);
            string msg=string.Empty;
            int result=BaseDAL.ExecuteNonQueryProcedure("prInsertUser", inParams, outParams, ref msg);

          
        }
    }
}
