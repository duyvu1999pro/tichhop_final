namespace Admin
{
    partial class TaiKhoanQuanTri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pan_edit = new System.Windows.Forms.Panel();
            this.but_edit = new System.Windows.Forms.Button();
            this.but_del = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.but_back = new System.Windows.Forms.Button();
            this.ten = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.sdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.matkhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pan_edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(1001, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 326;
            this.label1.Text = "Role";
            // 
            // pan_edit
            // 
            this.pan_edit.Controls.Add(this.but_edit);
            this.pan_edit.Controls.Add(this.but_del);
            this.pan_edit.Location = new System.Drawing.Point(841, 491);
            this.pan_edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pan_edit.Name = "pan_edit";
            this.pan_edit.Size = new System.Drawing.Size(283, 121);
            this.pan_edit.TabIndex = 325;
            this.pan_edit.Visible = false;
            // 
            // but_edit
            // 
            this.but_edit.BackColor = System.Drawing.Color.White;
            this.but_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_edit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.but_edit.FlatAppearance.BorderSize = 0;
            this.but_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_edit.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_edit.ForeColor = System.Drawing.Color.White;
            this.but_edit.Image = global::Admin.Properties.Resources.edit_64_bac;
            this.but_edit.Location = new System.Drawing.Point(20, 10);
            this.but_edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(101, 96);
            this.but_edit.TabIndex = 210;
            this.but_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_edit.UseVisualStyleBackColor = false;
            this.but_edit.Click += new System.EventHandler(this.sua);
            // 
            // but_del
            // 
            this.but_del.BackColor = System.Drawing.Color.White;
            this.but_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_del.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.but_del.FlatAppearance.BorderSize = 0;
            this.but_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_del.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_del.ForeColor = System.Drawing.Color.White;
            this.but_del.Image = global::Admin.Properties.Resources.delete_64;
            this.but_del.Location = new System.Drawing.Point(179, 10);
            this.but_del.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(87, 96);
            this.but_del.TabIndex = 206;
            this.but_del.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_del.UseVisualStyleBackColor = false;
            this.but_del.Click += new System.EventHandler(this.xoa);
            // 
            // but_add
            // 
            this.but_add.BackColor = System.Drawing.Color.White;
            this.but_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_add.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.but_add.FlatAppearance.BorderSize = 0;
            this.but_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.but_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_add.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_add.ForeColor = System.Drawing.Color.White;
            this.but_add.Image = global::Admin.Properties.Resources.add2;
            this.but_add.Location = new System.Drawing.Point(891, 455);
            this.but_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(188, 171);
            this.but_add.TabIndex = 324;
            this.but_add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_add.UseVisualStyleBackColor = false;
            this.but_add.Click += new System.EventHandler(this.them);
            // 
            // but_back
            // 
            this.but_back.BackColor = System.Drawing.Color.White;
            this.but_back.BackgroundImage = global::Admin.Properties.Resources.back_32;
            this.but_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_back.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.but_back.FlatAppearance.BorderSize = 0;
            this.but_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.but_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_back.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_back.ForeColor = System.Drawing.Color.White;
            this.but_back.Location = new System.Drawing.Point(1193, 21);
            this.but_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.but_back.Name = "but_back";
            this.but_back.Size = new System.Drawing.Size(69, 47);
            this.but_back.TabIndex = 322;
            this.but_back.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_back.UseVisualStyleBackColor = false;
            this.but_back.Visible = false;
            this.but_back.Click += new System.EventHandler(this.but_back_Click);
            // 
            // ten
            // 
            this.ten.BackColor = System.Drawing.Color.White;
            this.ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten.ForeColor = System.Drawing.Color.Black;
            this.ten.Location = new System.Drawing.Point(718, 129);
            this.ten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ten.Multiline = true;
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(519, 36);
            this.ten.TabIndex = 321;
            this.ten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(677, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 756);
            this.panel1.TabIndex = 319;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(715, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 320;
            this.label2.Text = "Họ tên";
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToResizeColumns = false;
            this.gridView.AllowUserToResizeRows = false;
            this.gridView.BackgroundColor = System.Drawing.Color.White;
            this.gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(28)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(28)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridView.ColumnHeadersHeight = 60;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colum,
            this.tenn,
            this.Column1,
            this.Column2,
            this.cl,
            this.Column3});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridView.EnableHeadersVisualStyles = false;
            this.gridView.GridColor = System.Drawing.Color.White;
            this.gridView.Location = new System.Drawing.Point(24, 15);
            this.gridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersVisible = false;
            this.gridView.RowHeadersWidth = 51;
            this.gridView.RowTemplate.Height = 40;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(645, 726);
            this.gridView.TabIndex = 318;
            this.gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellDoubleClick);
            // 
            // sdt
            // 
            this.sdt.BackColor = System.Drawing.Color.White;
            this.sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdt.ForeColor = System.Drawing.Color.Black;
            this.sdt.Location = new System.Drawing.Point(719, 203);
            this.sdt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sdt.Multiline = true;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            this.sdt.Size = new System.Drawing.Size(232, 36);
            this.sdt.TabIndex = 328;
            this.sdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(715, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 327;
            this.label3.Text = "Phone";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Member"});
            this.comboBox1.Location = new System.Drawing.Point(1005, 203);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 37);
            this.comboBox1.TabIndex = 337;
            // 
            // matkhau
            // 
            this.matkhau.BackColor = System.Drawing.Color.White;
            this.matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhau.ForeColor = System.Drawing.Color.Black;
            this.matkhau.Location = new System.Drawing.Point(718, 297);
            this.matkhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matkhau.Multiline = true;
            this.matkhau.Name = "matkhau";
            this.matkhau.ReadOnly = true;
            this.matkhau.Size = new System.Drawing.Size(232, 36);
            this.matkhau.TabIndex = 339;
            this.matkhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label4.Location = new System.Drawing.Point(715, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 338;
            this.label4.Text = "Mật khẩu";
            // 
            // colum
            // 
            this.colum.DataPropertyName = "MaQT";
            this.colum.HeaderText = "Mã";
            this.colum.MinimumWidth = 6;
            this.colum.Name = "colum";
            this.colum.ReadOnly = true;
            this.colum.Width = 50;
            // 
            // tenn
            // 
            this.tenn.DataPropertyName = "HoTen";
            this.tenn.HeaderText = "Họ tên";
            this.tenn.MinimumWidth = 6;
            this.tenn.Name = "tenn";
            this.tenn.ReadOnly = true;
            this.tenn.Width = 225;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SDT";
            this.Column1.HeaderText = "Số điện thoại";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 175;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MatKhau";
            this.Column2.HeaderText = "Mật khẩu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            this.Column2.Width = 125;
            // 
            // cl
            // 
            this.cl.DataPropertyName = "Role";
            this.cl.HeaderText = "Quyền";
            this.cl.MinimumWidth = 6;
            this.cl.Name = "cl";
            this.cl.ReadOnly = true;
            this.cl.Visible = false;
            this.cl.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ROLE1";
            this.Column3.HeaderText = "ROLES";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            this.Column3.Width = 125;
            // 
            // TaiKhoanQuanTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1285, 756);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.sdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pan_edit);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.but_back);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TaiKhoanQuanTri";
            this.Text = "TaiKhoanQuanTri";
            this.pan_edit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pan_edit;
        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Button but_back;
        private System.Windows.Forms.TextBox ten;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox matkhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}