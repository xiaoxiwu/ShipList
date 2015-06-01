namespace ShipLists
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("船舶档案信息");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("船舶轨迹数据");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("港口信息数据");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("数据分析结果");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("清单结果数据");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("主机低负载调节系数");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("排放因子信息");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("用户信息数据");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("数据管理", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("数据分析");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("清单估算");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(186, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(661, 462);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(653, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(677, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(677, 436);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(11, 19);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "ShipRecordInfo";
            treeNode1.Text = "船舶档案信息";
            treeNode2.Name = "ShipTraceInfo";
            treeNode2.Text = "船舶轨迹数据";
            treeNode3.Name = "PortInfoData";
            treeNode3.Text = "港口信息数据";
            treeNode4.Name = "DataAnalysisResult";
            treeNode4.Text = "数据分析结果";
            treeNode5.Name = "InventoryResultInfo";
            treeNode5.Text = "清单结果数据";
            treeNode6.Name = "HostLowLoadAdjustRatio";
            treeNode6.Text = "主机低负载调节系数";
            treeNode7.Name = "DischargeFactorInfo";
            treeNode7.Text = "排放因子信息";
            treeNode8.Name = "UserInfoData";
            treeNode8.Text = "用户信息数据";
            treeNode9.Name = "DataManagement";
            treeNode9.Text = "数据管理";
            treeNode10.Name = "节点1";
            treeNode10.Text = "数据分析";
            treeNode11.Name = "InventoryEstimation";
            treeNode11.Text = "清单估算";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(173, 462);
            this.treeView1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 507);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.treeView1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TreeView treeView1;

    }
}