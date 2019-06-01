namespace Hospital
{
    partial class frmSearch
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbSInsurance = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSFname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSLname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSBednum = new System.Windows.Forms.TextBox();
            this.btneCancel = new System.Windows.Forms.Button();
            this.btneSearch = new System.Windows.Forms.Button();
            this.txtSAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbSInsurance
            // 
            this.cmbSInsurance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSInsurance.FormattingEnabled = true;
            this.cmbSInsurance.Location = new System.Drawing.Point(426, 424);
            this.cmbSInsurance.Name = "cmbSInsurance";
            this.cmbSInsurance.Size = new System.Drawing.Size(204, 21);
            this.cmbSInsurance.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(605, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "بیمه";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "نام خانوادگی";
            // 
            // txtSFname
            // 
            this.txtSFname.Location = new System.Drawing.Point(216, 353);
            this.txtSFname.Name = "txtSFname";
            this.txtSFname.Size = new System.Drawing.Size(204, 20);
            this.txtSFname.TabIndex = 29;
            this.txtSFname.WordWrap = false;
            this.txtSFname.Enter += new System.EventHandler(this.txtSCod_Enter);
            this.txtSFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLname_KeyPress);
            this.txtSFname.Leave += new System.EventHandler(this.txtSCod_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(610, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "نام";
            // 
            // txtSLname
            // 
            this.txtSLname.Location = new System.Drawing.Point(426, 353);
            this.txtSLname.Name = "txtSLname";
            this.txtSLname.Size = new System.Drawing.Size(204, 20);
            this.txtSLname.TabIndex = 27;
            this.txtSLname.WordWrap = false;
            this.txtSLname.Enter += new System.EventHandler(this.txtSCod_Enter);
            this.txtSLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLname_KeyPress);
            this.txtSLname.Leave += new System.EventHandler(this.txtSCod_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(800, 337);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "کد ملی";
            // 
            // txtSCod
            // 
            this.txtSCod.Location = new System.Drawing.Point(636, 353);
            this.txtSCod.Name = "txtSCod";
            this.txtSCod.Size = new System.Drawing.Size(204, 20);
            this.txtSCod.TabIndex = 25;
            this.txtSCod.WordWrap = false;
            this.txtSCod.Enter += new System.EventHandler(this.txtSCod_Enter);
            this.txtSCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSCod_KeyPress);
            this.txtSCod.Leave += new System.EventHandler(this.txtSCod_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(769, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "شماره ی تخت";
            // 
            // txtSBednum
            // 
            this.txtSBednum.Location = new System.Drawing.Point(636, 425);
            this.txtSBednum.Name = "txtSBednum";
            this.txtSBednum.Size = new System.Drawing.Size(204, 20);
            this.txtSBednum.TabIndex = 32;
            this.txtSBednum.WordWrap = false;
            this.txtSBednum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSCod_KeyPress);
            // 
            // btneCancel
            // 
            this.btneCancel.Location = new System.Drawing.Point(12, 487);
            this.btneCancel.Name = "btneCancel";
            this.btneCancel.Size = new System.Drawing.Size(158, 23);
            this.btneCancel.TabIndex = 36;
            this.btneCancel.Text = "انصراف";
            this.btneCancel.UseVisualStyleBackColor = true;
            // 
            // btneSearch
            // 
            this.btneSearch.Location = new System.Drawing.Point(176, 487);
            this.btneSearch.Name = "btneSearch";
            this.btneSearch.Size = new System.Drawing.Size(158, 23);
            this.btneSearch.TabIndex = 37;
            this.btneSearch.Text = "جستجو";
            this.btneSearch.UseVisualStyleBackColor = true;
            // 
            // txtSAddress
            // 
            this.txtSAddress.Location = new System.Drawing.Point(6, 353);
            this.txtSAddress.Name = "txtSAddress";
            this.txtSAddress.Size = new System.Drawing.Size(204, 20);
            this.txtSAddress.TabIndex = 38;
            this.txtSAddress.WordWrap = false;
            this.txtSAddress.Enter += new System.EventHandler(this.txtSCod_Enter);
            this.txtSAddress.Leave += new System.EventHandler(this.txtSCod_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "آدرس";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 522);
            this.ControlBox = false;
            this.Controls.Add(this.txtSAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btneSearch);
            this.Controls.Add(this.btneCancel);
            this.Controls.Add(this.cmbSInsurance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSFname);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSLname);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSCod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSBednum);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSearch";
            this.Text = "جستجو";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbSInsurance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSFname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSLname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSBednum;
        private System.Windows.Forms.Button btneCancel;
        private System.Windows.Forms.Button btneSearch;
        private System.Windows.Forms.TextBox txtSAddress;
        private System.Windows.Forms.Label label3;
    }
}