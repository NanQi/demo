namespace CustomerService
{
    partial class dockCustomerGroup
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("节点0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("节点5");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("节点6");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("节点3", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("节点4");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("节点1", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("节点2");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dockCustomerGroup));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新增客户信息1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.新增客户组1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑客户组2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除客户组3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点0";
            treeNode1.Text = "节点0";
            treeNode2.Name = "节点5";
            treeNode2.Text = "节点5";
            treeNode3.Name = "节点6";
            treeNode3.Text = "节点6";
            treeNode4.Name = "节点3";
            treeNode4.Text = "节点3";
            treeNode5.Name = "节点4";
            treeNode5.Text = "节点4";
            treeNode6.Name = "节点1";
            treeNode6.Text = "节点1";
            treeNode7.Name = "节点2";
            treeNode7.Text = "节点2";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode6,
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(206, 364);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增客户信息1ToolStripMenuItem,
            this.toolStripSeparator1,
            this.新增客户组1ToolStripMenuItem,
            this.编辑客户组2ToolStripMenuItem,
            this.删除客户组3ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 98);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 新增客户信息1ToolStripMenuItem
            // 
            this.新增客户信息1ToolStripMenuItem.Name = "新增客户信息1ToolStripMenuItem";
            this.新增客户信息1ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.新增客户信息1ToolStripMenuItem.Text = "新增客户信息(&1)";
            this.新增客户信息1ToolStripMenuItem.Click += new System.EventHandler(this.新增客户信息1ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // 新增客户组1ToolStripMenuItem
            // 
            this.新增客户组1ToolStripMenuItem.Name = "新增客户组1ToolStripMenuItem";
            this.新增客户组1ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.新增客户组1ToolStripMenuItem.Text = "新增客户组(&2)";
            this.新增客户组1ToolStripMenuItem.Click += new System.EventHandler(this.新增客户组1ToolStripMenuItem_Click);
            // 
            // 编辑客户组2ToolStripMenuItem
            // 
            this.编辑客户组2ToolStripMenuItem.Name = "编辑客户组2ToolStripMenuItem";
            this.编辑客户组2ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.编辑客户组2ToolStripMenuItem.Text = "修改客户组(&3)";
            this.编辑客户组2ToolStripMenuItem.Click += new System.EventHandler(this.修改客户组2ToolStripMenuItem_Click);
            // 
            // 删除客户组3ToolStripMenuItem
            // 
            this.删除客户组3ToolStripMenuItem.Name = "删除客户组3ToolStripMenuItem";
            this.删除客户组3ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.删除客户组3ToolStripMenuItem.Text = "删除客户组(&4)";
            this.删除客户组3ToolStripMenuItem.Click += new System.EventHandler(this.删除客户组3ToolStripMenuItem_Click);
            // 
            // dockCustomerGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 364);
            this.Controls.Add(this.treeView1);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft)
                        | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)));
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dockCustomerGroup";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockLeft;
            this.TabText = "客户组";
            this.Text = "客户组";
            this.Load += new System.EventHandler(this.dockCustomerGroup_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新增客户组1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑客户组2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除客户组3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增客户信息1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}