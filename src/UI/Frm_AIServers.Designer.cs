﻿
namespace AITool
{
    partial class Frm_AIServers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AIServers));
            this.FOLV_AIServers = new BrightIdeasSoftware.FastObjectListView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButtonAdd = new System.Windows.Forms.ToolStripSplitButton();
            this.deepstackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDoodsServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAmazonReToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sightHoundVehicleAIServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sightHoundPersonAIServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUp = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDown = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FOLV_AIServers)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FOLV_AIServers
            // 
            this.FOLV_AIServers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FOLV_AIServers.HideSelection = false;
            this.FOLV_AIServers.Location = new System.Drawing.Point(0, 34);
            this.FOLV_AIServers.Name = "FOLV_AIServers";
            this.FOLV_AIServers.ShowGroups = false;
            this.FOLV_AIServers.Size = new System.Drawing.Size(591, 122);
            this.FOLV_AIServers.TabIndex = 0;
            this.FOLV_AIServers.UseCompatibleStateImageBehavior = false;
            this.FOLV_AIServers.View = System.Windows.Forms.View.Details;
            this.FOLV_AIServers.VirtualMode = true;
            this.FOLV_AIServers.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.FOLV_AIServers_FormatRow);
            this.FOLV_AIServers.SelectionChanged += new System.EventHandler(this.FOLV_AIServers_SelectionChanged);
            this.FOLV_AIServers.SelectedIndexChanged += new System.EventHandler(this.FOLV_AIServers_SelectedIndexChanged);
            this.FOLV_AIServers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FOLV_AIServers_MouseDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButtonAdd,
            this.toolStripSeparator1,
            this.toolStripButtonEdit,
            this.toolStripSeparator2,
            this.toolStripButtonDelete,
            this.toolStripSeparator3,
            this.toolStripButtonUp,
            this.toolStripButtonDown});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(591, 31);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButtonAdd
            // 
            this.toolStripSplitButtonAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deepstackToolStripMenuItem,
            this.addDoodsServerToolStripMenuItem,
            this.addAmazonReToolStripMenuItem,
            this.sightHoundVehicleAIServerToolStripMenuItem,
            this.sightHoundPersonAIServerToolStripMenuItem});
            this.toolStripSplitButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonAdd.Image")));
            this.toolStripSplitButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonAdd.Name = "toolStripSplitButtonAdd";
            this.toolStripSplitButtonAdd.Size = new System.Drawing.Size(69, 28);
            this.toolStripSplitButtonAdd.Text = "Add";
            this.toolStripSplitButtonAdd.ButtonClick += new System.EventHandler(this.toolStripSplitButtonAdd_ButtonClick);
            // 
            // deepstackToolStripMenuItem
            // 
            this.deepstackToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deepstackToolStripMenuItem.Image")));
            this.deepstackToolStripMenuItem.Name = "deepstackToolStripMenuItem";
            this.deepstackToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.deepstackToolStripMenuItem.Text = "Deepstack AI Server";
            this.deepstackToolStripMenuItem.Click += new System.EventHandler(this.deepstackToolStripMenuItem_Click);
            // 
            // addDoodsServerToolStripMenuItem
            // 
            this.addDoodsServerToolStripMenuItem.Image = global::AITool.Properties.Resources.network_server;
            this.addDoodsServerToolStripMenuItem.Name = "addDoodsServerToolStripMenuItem";
            this.addDoodsServerToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.addDoodsServerToolStripMenuItem.Text = "DOODS AI Server";
            this.addDoodsServerToolStripMenuItem.Click += new System.EventHandler(this.addDoodsServerToolStripMenuItem_Click);
            // 
            // addAmazonReToolStripMenuItem
            // 
            this.addAmazonReToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addAmazonReToolStripMenuItem.Image")));
            this.addAmazonReToolStripMenuItem.Name = "addAmazonReToolStripMenuItem";
            this.addAmazonReToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.addAmazonReToolStripMenuItem.Text = "AWS Rekognition AI Server";
            this.addAmazonReToolStripMenuItem.Click += new System.EventHandler(this.addAmazonReToolStripMenuItem_Click);
            // 
            // sightHoundVehicleAIServerToolStripMenuItem
            // 
            this.sightHoundVehicleAIServerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sightHoundVehicleAIServerToolStripMenuItem.Image")));
            this.sightHoundVehicleAIServerToolStripMenuItem.Name = "sightHoundVehicleAIServerToolStripMenuItem";
            this.sightHoundVehicleAIServerToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.sightHoundVehicleAIServerToolStripMenuItem.Text = "SightHound (Vehicle) AI Server";
            this.sightHoundVehicleAIServerToolStripMenuItem.Click += new System.EventHandler(this.sightHoundAIServerToolStripMenuItem_Click);
            // 
            // sightHoundPersonAIServerToolStripMenuItem
            // 
            this.sightHoundPersonAIServerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sightHoundPersonAIServerToolStripMenuItem.Image")));
            this.sightHoundPersonAIServerToolStripMenuItem.Name = "sightHoundPersonAIServerToolStripMenuItem";
            this.sightHoundPersonAIServerToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.sightHoundPersonAIServerToolStripMenuItem.Text = "SightHound (Person) AI Server";
            this.sightHoundPersonAIServerToolStripMenuItem.Click += new System.EventHandler(this.sightHoundPersonAIServerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.Enabled = false;
            this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(55, 28);
            this.toolStripButtonEdit.Text = "Edit";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.Enabled = false;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(68, 28);
            this.toolStripButtonDelete.Text = "Delete";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButtonUp
            // 
            this.toolStripButtonUp.Enabled = false;
            this.toolStripButtonUp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUp.Image")));
            this.toolStripButtonUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUp.Name = "toolStripButtonUp";
            this.toolStripButtonUp.Size = new System.Drawing.Size(50, 28);
            this.toolStripButtonUp.Text = "Up";
            this.toolStripButtonUp.Click += new System.EventHandler(this.toolStripButtonUp_Click);
            // 
            // toolStripButtonDown
            // 
            this.toolStripButtonDown.Enabled = false;
            this.toolStripButtonDown.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDown.Image")));
            this.toolStripButtonDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDown.Name = "toolStripButtonDown";
            this.toolStripButtonDown.Size = new System.Drawing.Size(66, 28);
            this.toolStripButtonDown.Text = "Down";
            this.toolStripButtonDown.Click += new System.EventHandler(this.toolStripButtonDown_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "AWSRekognition.png");
            this.imageList1.Images.SetKeyName(1, "Deepstack.png");
            this.imageList1.Images.SetKeyName(2, "DOODS.png");
            this.imageList1.Images.SetKeyName(3, "SightHound.png");
            // 
            // Frm_AIServers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 159);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.FOLV_AIServers);
            this.Name = "Frm_AIServers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "SAVE";
            this.Text = "AI Servers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_AddAIServers_FormClosing);
            this.Load += new System.EventHandler(this.Frm_AddAIServers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FOLV_AIServers)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public BrightIdeasSoftware.FastObjectListView FOLV_AIServers;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonAdd;
        private System.Windows.Forms.ToolStripMenuItem deepstackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAmazonReToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDoodsServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonUp;
        private System.Windows.Forms.ToolStripButton toolStripButtonDown;
        private System.Windows.Forms.ToolStripMenuItem sightHoundVehicleAIServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sightHoundPersonAIServerToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
    }
}