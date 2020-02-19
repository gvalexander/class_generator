namespace ClassGenerator
{
    partial class Generator
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
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnGenerate = new DevExpress.XtraEditors.SimpleButton();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtDatasource = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtNamespace = new DevExpress.XtraEditors.TextEdit();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtGeneratedText = new System.Windows.Forms.RichTextBox();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cbTabView = new System.Windows.Forms.ComboBox();
            this.cbTableName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatasource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamespace.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(223, 90);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(132, 90);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(664, 25);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(105, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.ToolTip = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(553, 25);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(105, 20);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.ToolTip = "Username";
            // 
            // txtDatasource
            // 
            this.txtDatasource.Location = new System.Drawing.Point(132, 25);
            this.txtDatasource.Name = "txtDatasource";
            this.txtDatasource.Size = new System.Drawing.Size(347, 20);
            this.txtDatasource.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Table/View Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Namespace";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DataSource";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cbTableName);
            this.groupControl2.Controls.Add(this.cbTabView);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.txtNamespace);
            this.groupControl2.Controls.Add(this.lblResult);
            this.groupControl2.Controls.Add(this.btnReset);
            this.groupControl2.Controls.Add(this.btnGenerate);
            this.groupControl2.Controls.Add(this.txtDatasource);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.txtPassword);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.txtUsername);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1064, 124);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Data Configuration";
            // 
            // txtNamespace
            // 
            this.txtNamespace.Location = new System.Drawing.Point(553, 54);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(216, 20);
            this.txtNamespace.TabIndex = 11;
            this.txtNamespace.ToolTip = "Username";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(346, 99);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 10;
            // 
            // txtGeneratedText
            // 
            this.txtGeneratedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGeneratedText.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtGeneratedText.Location = new System.Drawing.Point(0, 124);
            this.txtGeneratedText.Name = "txtGeneratedText";
            this.txtGeneratedText.ReadOnly = true;
            this.txtGeneratedText.Size = new System.Drawing.Size(1064, 520);
            this.txtGeneratedText.TabIndex = 0;
            this.txtGeneratedText.Text = "";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Credentials";
            // 
            // cbTabView
            // 
            this.cbTabView.FormattingEnabled = true;
            this.cbTabView.Items.AddRange(new object[] {
            "Table",
            "View"});
            this.cbTabView.Location = new System.Drawing.Point(132, 54);
            this.cbTabView.Name = "cbTabView";
            this.cbTabView.Size = new System.Drawing.Size(108, 21);
            this.cbTabView.TabIndex = 14;
            this.cbTabView.SelectedIndexChanged += new System.EventHandler(this.cbTabView_SelectedIndexChanged);
            // 
            // cbTableName
            // 
            this.cbTableName.FormattingEnabled = true;
            this.cbTableName.Items.AddRange(new object[] {
            "Table",
            "View"});
            this.cbTableName.Location = new System.Drawing.Point(246, 54);
            this.cbTableName.Name = "cbTableName";
            this.cbTableName.Size = new System.Drawing.Size(233, 21);
            this.cbTableName.TabIndex = 15;
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 644);
            this.Controls.Add(this.txtGeneratedText);
            this.Controls.Add(this.groupControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Generator";
            this.Text = "Class Generator";
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatasource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamespace.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtDatasource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.RichTextBox txtGeneratedText;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnGenerate;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Label lblResult;
        private DevExpress.XtraEditors.TextEdit txtNamespace;
        private System.Windows.Forms.ComboBox cbTabView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTableName;
    }
}

