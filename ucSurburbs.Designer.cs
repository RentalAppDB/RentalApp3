namespace RentalApp
{
    partial class ucSurburbs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Suburbs = new System.Windows.Forms.GroupBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvSuburbs = new System.Windows.Forms.DataGridView();
            this.cmbCityID = new System.Windows.Forms.ComboBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtSuburbDescr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSuburbID = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.errorSurbubs = new System.Windows.Forms.ErrorProvider(this.components);
            this.Suburbs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuburbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSurbubs)).BeginInit();
            this.SuspendLayout();
            // 
            // Suburbs
            // 
            this.Suburbs.Controls.Add(this.btnDisplay);
            this.Suburbs.Controls.Add(this.btnAdd);
            this.Suburbs.Controls.Add(this.dgvSuburbs);
            this.Suburbs.Controls.Add(this.cmbCityID);
            this.Suburbs.Controls.Add(this.txtPostalCode);
            this.Suburbs.Controls.Add(this.txtSuburbDescr);
            this.Suburbs.Controls.Add(this.label4);
            this.Suburbs.Controls.Add(this.label3);
            this.Suburbs.Controls.Add(this.label2);
            this.Suburbs.Controls.Add(this.label1);
            this.Suburbs.Controls.Add(this.txtSuburbID);
            this.Suburbs.Location = new System.Drawing.Point(31, 35);
            this.Suburbs.Name = "Suburbs";
            this.Suburbs.Size = new System.Drawing.Size(795, 477);
            this.Suburbs.TabIndex = 0;
            this.Suburbs.TabStop = false;
            this.Suburbs.Text = "Suburbs";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(579, 88);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 10;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(579, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // dgvSuburbs
            // 
            this.dgvSuburbs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuburbs.Location = new System.Drawing.Point(39, 310);
            this.dgvSuburbs.Name = "dgvSuburbs";
            this.dgvSuburbs.RowHeadersWidth = 51;
            this.dgvSuburbs.RowTemplate.Height = 24;
            this.dgvSuburbs.Size = new System.Drawing.Size(750, 150);
            this.dgvSuburbs.TabIndex = 8;
            // 
            // cmbCityID
            // 
            this.cmbCityID.FormattingEnabled = true;
            this.cmbCityID.Location = new System.Drawing.Point(166, 267);
            this.cmbCityID.Name = "cmbCityID";
            this.cmbCityID.Size = new System.Drawing.Size(231, 24);
            this.cmbCityID.TabIndex = 7;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(166, 200);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(231, 22);
            this.txtPostalCode.TabIndex = 6;
            // 
            // txtSuburbDescr
            // 
            this.txtSuburbDescr.Location = new System.Drawing.Point(166, 122);
            this.txtSuburbDescr.Name = "txtSuburbDescr";
            this.txtSuburbDescr.Size = new System.Drawing.Size(231, 22);
            this.txtSuburbDescr.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "City ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Postal Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Suburb Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Suburb ID:";
            // 
            // txtSuburbID
            // 
            this.txtSuburbID.Location = new System.Drawing.Point(166, 44);
            this.txtSuburbID.Name = "txtSuburbID";
            this.txtSuburbID.Size = new System.Drawing.Size(231, 22);
            this.txtSuburbID.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // errorSurbubs
            // 
            this.errorSurbubs.ContainerControl = this;
            // 
            // ucSurburbs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Suburbs);
            this.Name = "ucSurburbs";
            this.Size = new System.Drawing.Size(854, 544);
            this.Suburbs.ResumeLayout(false);
            this.Suburbs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuburbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSurbubs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Suburbs;
        private System.Windows.Forms.DataGridView dgvSuburbs;
        private System.Windows.Forms.ComboBox cmbCityID;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtSuburbDescr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSuburbID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorSurbubs;
    }
}
