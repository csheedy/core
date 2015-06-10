// @@@ START COPYRIGHT @@@
//
// (C) Copyright 2015 Hewlett-Packard Development Company, L.P.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//
// @@@ END COPYRIGHT @@@
namespace Trafodion.Manager.WorkloadArea.Controls
{
    partial class WMSRepositoryInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WMSRepositoryInfo));
            this.groupBox1 = new Trafodion.Manager.Framework.Controls.TrafodionGroupBox();
            this.repositoryInfoIGrid = new Trafodion.Manager.Framework.Controls.TrafodionIGrid("aQB2AFkAZAB3AGkAVwBlAG4ALgBIAHMANQBsAGUAdAB0AEkATwBaAHQAdAB1AEcAUgB2AG4AZAB1AG0AT" +
                    "QB5AGgAcgBlAHUATgBlAGsASgAtAHMAMAA2AHgAYwBwAHQAOABhAHYAbgAwAHkAZABhADkAOQBtADAAI" +
                    "ABiAHIAUAB5ADAAdQBrAEMANAAxAG8AcQBhAHcAMgByAHoAMABhAA==");
            this.iGrid1DefaultCellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
            this.iGrid1DefaultColHdrStyle = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
            this.iGrid1RowTextColCellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
            this.label1 = new Trafodion.Manager.Framework.Controls.TrafodionLabel();
            this.queryIdTextBox = new Trafodion.Manager.Framework.Controls.TrafodionTextBox();
            this.panel1 = new Trafodion.Manager.Framework.Controls.TrafodionPanel();
            this.panel2 = new Trafodion.Manager.Framework.Controls.TrafodionPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.oneGuiPanel1 = new Trafodion.Manager.Framework.Controls.TrafodionPanel();
            this.progressBar1 = new Trafodion.Manager.Framework.Controls.TrafodionProgressBar();
            this.closeButton = new Trafodion.Manager.Framework.Controls.TrafodionButton();
            this.helpButton = new Trafodion.Manager.Framework.Controls.TrafodionButton();
            this.oneGuiBannerControl1 = new Trafodion.Manager.Framework.Controls.TrafodionBannerControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryInfoIGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.oneGuiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.repositoryInfoIGrid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 428);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // repositoryInfoIGrid
            // 
            this.repositoryInfoIGrid.AllowColumnFilter = true;
            this.repositoryInfoIGrid.AllowWordWrap = false;
            this.repositoryInfoIGrid.AlwaysHiddenColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("repositoryInfoIGrid.AlwaysHiddenColumnNames")));
            this.repositoryInfoIGrid.BackColorEvenRows = System.Drawing.Color.WhiteSmoke;
            this.repositoryInfoIGrid.CurrentFilter = null;
            this.repositoryInfoIGrid.DefaultCol.CellStyle = this.iGrid1DefaultCellStyle;
            this.repositoryInfoIGrid.DefaultCol.ColHdrStyle = this.iGrid1DefaultColHdrStyle;
            this.repositoryInfoIGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repositoryInfoIGrid.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.repositoryInfoIGrid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.repositoryInfoIGrid.Header.Height = 19;
            this.repositoryInfoIGrid.HelpTopic = "";
            this.repositoryInfoIGrid.Location = new System.Drawing.Point(3, 17);
            this.repositoryInfoIGrid.Name = "repositoryInfoIGrid";
            this.repositoryInfoIGrid.ReadOnly = true;
            this.repositoryInfoIGrid.RowMode = true;
            this.repositoryInfoIGrid.RowTextCol.CellStyle = this.iGrid1RowTextColCellStyle;
            this.repositoryInfoIGrid.SearchAsType.MatchRule = TenTec.Windows.iGridLib.iGMatchRule.Contains;
            this.repositoryInfoIGrid.SearchAsType.Mode = TenTec.Windows.iGridLib.iGSearchAsTypeMode.Seek;
            this.repositoryInfoIGrid.SearchAsType.SearchCol = null;
            this.repositoryInfoIGrid.Size = new System.Drawing.Size(954, 408);
            this.repositoryInfoIGrid.TabIndex = 0;
            this.repositoryInfoIGrid.TreeCol = null;
            this.repositoryInfoIGrid.TreeLines.Color = System.Drawing.SystemColors.WindowText;
            this.repositoryInfoIGrid.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Query ID:";
            // 
            // queryIdTextBox
            // 
            this.queryIdTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.queryIdTextBox.Location = new System.Drawing.Point(62, 17);
            this.queryIdTextBox.Name = "queryIdTextBox";
            this.queryIdTextBox.ReadOnly = true;
            this.queryIdTextBox.Size = new System.Drawing.Size(557, 21);
            this.queryIdTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.queryIdTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 54);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 428);
            this.panel2.TabIndex = 42;
            // 
            // oneGuiPanel1
            // 
            this.oneGuiPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.oneGuiPanel1.Controls.Add(this.progressBar1);
            this.oneGuiPanel1.Controls.Add(this.closeButton);
            this.oneGuiPanel1.Controls.Add(this.helpButton);
            this.oneGuiPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.oneGuiPanel1.Location = new System.Drawing.Point(0, 533);
            this.oneGuiPanel1.Name = "oneGuiPanel1";
            this.oneGuiPanel1.Size = new System.Drawing.Size(960, 37);
            this.oneGuiPanel1.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.Location = new System.Drawing.Point(7, 7);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(207, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.closeButton.Location = new System.Drawing.Point(796, 7);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.helpButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.helpButton.Location = new System.Drawing.Point(877, 7);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 23);
            this.helpButton.TabIndex = 1;
            this.helpButton.Text = "&Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // oneGuiBannerControl1
            // 
            this.oneGuiBannerControl1.ConnectionDefinition = null;
            this.oneGuiBannerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.oneGuiBannerControl1.Location = new System.Drawing.Point(0, 0);
            this.oneGuiBannerControl1.Name = "oneGuiBannerControl1";
            this.oneGuiBannerControl1.ShowDescription = true;
            this.oneGuiBannerControl1.Size = new System.Drawing.Size(960, 51);
            this.oneGuiBannerControl1.TabIndex = 9;
            // 
            // WMSRepositoryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.oneGuiBannerControl1);
            this.Controls.Add(this.oneGuiPanel1);
            this.Name = "WMSRepositoryInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HP Database Manager - Repository Info";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryInfoIGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.oneGuiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private Trafodion.Manager.Framework.Controls.TrafodionGroupBox groupBox1;
        private Trafodion.Manager.Framework.Controls.TrafodionIGrid repositoryInfoIGrid;
		private TenTec.Windows.iGridLib.iGCellStyle iGrid1DefaultCellStyle;
		private TenTec.Windows.iGridLib.iGColHdrStyle iGrid1DefaultColHdrStyle;
        private TenTec.Windows.iGridLib.iGCellStyle iGrid1RowTextColCellStyle;
		private Trafodion.Manager.Framework.Controls.TrafodionLabel label1;
		private Trafodion.Manager.Framework.Controls.TrafodionTextBox queryIdTextBox;
        private Trafodion.Manager.Framework.Controls.TrafodionPanel panel1;
        private Trafodion.Manager.Framework.Controls.TrafodionPanel panel2;
        private System.Windows.Forms.Timer timer1;
        private Trafodion.Manager.Framework.Controls.TrafodionPanel oneGuiPanel1;
        private Trafodion.Manager.Framework.Controls.TrafodionButton closeButton;
        private Trafodion.Manager.Framework.Controls.TrafodionButton helpButton;
        private Trafodion.Manager.Framework.Controls.TrafodionProgressBar progressBar1;
        private Trafodion.Manager.Framework.Controls.TrafodionBannerControl oneGuiBannerControl1;
	}
}