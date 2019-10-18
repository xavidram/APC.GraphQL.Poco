namespace APC.GraphQL.Poco.Views
{
	partial class DatabaseConnectionDialog
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
			this.DataSourceLabel = new DevExpress.XtraEditors.LabelControl();
			this.DataSource = new DevExpress.XtraEditors.TextEdit();
			this.ServerName = new DevExpress.XtraEditors.TextEdit();
			this.ServerNameLabel = new DevExpress.XtraEditors.LabelControl();
			this.AuthSectionLabel = new DevExpress.XtraEditors.LabelControl();
			this.ServerAuthenticationStyle = new DevExpress.XtraEditors.RadioGroup();
			this.checkButton1 = new DevExpress.XtraEditors.CheckButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.DataSource.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ServerName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ServerAuthenticationStyle.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// DataSourceLabel
			// 
			this.DataSourceLabel.Location = new System.Drawing.Point(23, 26);
			this.DataSourceLabel.Name = "DataSourceLabel";
			this.DataSourceLabel.Size = new System.Drawing.Size(63, 13);
			this.DataSourceLabel.TabIndex = 0;
			this.DataSourceLabel.Text = "Data Source:";
			// 
			// DataSource
			// 
			this.DataSource.EditValue = "Microsoft SQL Server (SqlClient)";
			this.DataSource.Enabled = false;
			this.DataSource.Location = new System.Drawing.Point(23, 46);
			this.DataSource.Name = "DataSource";
			this.DataSource.Size = new System.Drawing.Size(213, 20);
			this.DataSource.TabIndex = 1;
			// 
			// ServerName
			// 
			this.ServerName.Location = new System.Drawing.Point(23, 105);
			this.ServerName.Name = "ServerName";
			this.ServerName.Size = new System.Drawing.Size(213, 20);
			this.ServerName.TabIndex = 2;
			// 
			// ServerNameLabel
			// 
			this.ServerNameLabel.Location = new System.Drawing.Point(23, 86);
			this.ServerNameLabel.Name = "ServerNameLabel";
			this.ServerNameLabel.Size = new System.Drawing.Size(66, 13);
			this.ServerNameLabel.TabIndex = 3;
			this.ServerNameLabel.Text = "Server Name:";
			// 
			// AuthSectionLabel
			// 
			this.AuthSectionLabel.Location = new System.Drawing.Point(23, 155);
			this.AuthSectionLabel.Name = "AuthSectionLabel";
			this.AuthSectionLabel.Size = new System.Drawing.Size(98, 13);
			this.AuthSectionLabel.TabIndex = 4;
			this.AuthSectionLabel.Text = "Log on to the server";
			// 
			// ServerAuthenticationStyle
			// 
			this.ServerAuthenticationStyle.Location = new System.Drawing.Point(23, 189);
			this.ServerAuthenticationStyle.Name = "ServerAuthenticationStyle";
			this.ServerAuthenticationStyle.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.ServerAuthenticationStyle.Properties.Appearance.Options.UseBackColor = true;
			this.ServerAuthenticationStyle.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
			this.ServerAuthenticationStyle.Size = new System.Drawing.Size(213, 151);
			this.ServerAuthenticationStyle.TabIndex = 5;
			// 
			// checkButton1
			// 
			this.checkButton1.Location = new System.Drawing.Point(37, 204);
			this.checkButton1.Name = "checkButton1";
			this.checkButton1.Size = new System.Drawing.Size(22, 21);
			this.checkButton1.TabIndex = 6;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(65, 208);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(137, 13);
			this.labelControl1.TabIndex = 7;
			this.labelControl1.Text = "Use Windows Authentication";
			// 
			// DatabaseConnectionDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(373, 639);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.checkButton1);
			this.Controls.Add(this.ServerAuthenticationStyle);
			this.Controls.Add(this.AuthSectionLabel);
			this.Controls.Add(this.ServerNameLabel);
			this.Controls.Add(this.ServerName);
			this.Controls.Add(this.DataSource);
			this.Controls.Add(this.DataSourceLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "DatabaseConnectionDialog";
			this.Text = "Connection Settings";
			((System.ComponentModel.ISupportInitialize)(this.DataSource.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ServerName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ServerAuthenticationStyle.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl DataSourceLabel;
		private DevExpress.XtraEditors.TextEdit DataSource;
		private DevExpress.XtraEditors.TextEdit ServerName;
		private DevExpress.XtraEditors.LabelControl ServerNameLabel;
		private DevExpress.XtraEditors.LabelControl AuthSectionLabel;
		private DevExpress.XtraEditors.RadioGroup ServerAuthenticationStyle;
		private DevExpress.XtraEditors.CheckButton checkButton1;
		private DevExpress.XtraEditors.LabelControl labelControl1;
	}
}