using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipLists
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.treeView1.ExpandAll();
        }
    }
}
