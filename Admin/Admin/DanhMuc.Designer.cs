
namespace Admin
{
    partial class DanhMuc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.colum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.but_back = new System.Windows.Forms.Button();
            this.ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ghichu = new System.Windows.Forms.TextBox();
            this.pan_edit = new System.Windows.Forms.Panel();
            this.but_edit = new System.Windows.Forms.Button();
            this.but_del = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.pan_edit.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(28)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(28)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView.ColumnHeadersHeight = 60;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colum,
            this.tenn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridView.EnableHeadersVisualStyles = false;
            this.gridView.GridColor = System.Drawing.Color.White;
            this.gridView.Location = new System.Drawing.Point(12, 12);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersVisible = false;
            this.gridView.RowTemplate.Height = 40;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(431, 590);
            this.gridView.TabIndex = 291;
            this.gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellDoubleClick);
            // 
            // colum
            // 
            this.colum.DataPropertyName = "MaDM";
            this.colum.HeaderText = "Mã";
            this.colum.Name = "colum";
            this.colum.ReadOnly = true;
            // 
            // tenn
            // 
            this.tenn.DataPropertyName = "TenDM";
            this.tenn.HeaderText = "Tên danh mục";
            this.tenn.Name = "tenn";
            this.tenn.ReadOnly = true;
            this.tenn.Width = 300;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(481, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 614);
            this.panel1.TabIndex = 292;
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
            this.but_back.Location = new System.Drawing.Point(889, 17);
            this.but_back.Name = "but_back";
            this.but_back.Size = new System.Drawing.Size(52, 38);
            this.but_back.TabIndex = 313;
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
            this.ten.Location = new System.Drawing.Point(540, 75);
            this.ten.Multiline = true;
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(401, 30);
            this.ten.TabIndex = 312;
            this.ten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(537, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 311;
            this.label2.Text = "Tên Danh mục";
            // 
            // ghichu
            // 
            this.ghichu.BackColor = System.Drawing.Color.White;
            this.ghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghichu.ForeColor = System.Drawing.Color.Black;
            this.ghichu.Location = new System.Drawing.Point(540, 177);
            this.ghichu.Multiline = true;
            this.ghichu.Name = "ghichu";
            this.ghichu.Size = new System.Drawing.Size(401, 79);
            this.ghichu.TabIndex = 314;
            this.ghichu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pan_edit
            // 
            this.pan_edit.Controls.Add(this.but_edit);
            this.pan_edit.Controls.Add(this.but_del);
            this.pan_edit.Location = new System.Drawing.Point(625, 399);
            this.pan_edit.Name = "pan_edit";
            this.pan_edit.Size = new System.Drawing.Size(212, 98);
            this.pan_edit.TabIndex = 316;
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
            this.but_edit.Location = new System.Drawing.Point(15, 8);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(76, 78);
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
            this.but_del.Location = new System.Drawing.Point(134, 8);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(65, 78);
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
            this.but_add.Location = new System.Drawing.Point(662, 370);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(141, 139);
            this.but_add.TabIndex = 315;
            this.but_add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_add.UseVisualStyleBackColor = false;
            this.but_add.Click += new System.EventHandler(this.them);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(537, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 317;
            this.label1.Text = "Ghi chú";
            // 
            // DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 614);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pan_edit);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.ghichu);
            this.Controls.Add(this.but_back);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhMuc";
            this.Text = "DanhMuc";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.pan_edit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button but_back;
        private System.Windows.Forms.TextBox ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ghichu;
        private System.Windows.Forms.Panel pan_edit;
        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenn;
    }
}