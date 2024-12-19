namespace BaiKtraWF
{
    partial class Form1
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
            this.FIND = new System.Windows.Forms.Button();
            this.timtheotenSP = new System.Windows.Forms.TextBox();
            this.NAMEsp = new System.Windows.Forms.TextBox();
            this.IDsp = new System.Windows.Forms.TextBox();
            this.FIX = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.SAVE = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.NOTSAVE = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 195);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FIND
            // 
            this.FIND.Location = new System.Drawing.Point(282, 52);
            this.FIND.Name = "FIND";
            this.FIND.Size = new System.Drawing.Size(75, 23);
            this.FIND.TabIndex = 1;
            this.FIND.Text = "Tìm";
            this.FIND.UseVisualStyleBackColor = true;
            this.FIND.Click += new System.EventHandler(this.FIND_Click);
            // 
            // timtheotenSP
            // 
            this.timtheotenSP.Location = new System.Drawing.Point(93, 55);
            this.timtheotenSP.Name = "timtheotenSP";
            this.timtheotenSP.Size = new System.Drawing.Size(168, 20);
            this.timtheotenSP.TabIndex = 2;
            this.timtheotenSP.TextChanged += new System.EventHandler(this.timtheotenSP_TextChanged);
            // 
            // NAMEsp
            // 
            this.NAMEsp.Location = new System.Drawing.Point(537, 149);
            this.NAMEsp.Name = "NAMEsp";
            this.NAMEsp.Size = new System.Drawing.Size(168, 20);
            this.NAMEsp.TabIndex = 3;
            this.NAMEsp.TextChanged += new System.EventHandler(this.NAMEsp_TextChanged);
            // 
            // IDsp
            // 
            this.IDsp.Location = new System.Drawing.Point(537, 95);
            this.IDsp.Name = "IDsp";
            this.IDsp.Size = new System.Drawing.Size(168, 20);
            this.IDsp.TabIndex = 4;
            this.IDsp.TextChanged += new System.EventHandler(this.IDsp_TextChanged);
            // 
            // FIX
            // 
            this.FIX.Location = new System.Drawing.Point(149, 383);
            this.FIX.Name = "FIX";
            this.FIX.Size = new System.Drawing.Size(75, 23);
            this.FIX.TabIndex = 6;
            this.FIX.Text = "Sửa";
            this.FIX.UseVisualStyleBackColor = true;
            this.FIX.Click += new System.EventHandler(this.FIX_Click);
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(37, 383);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(75, 23);
            this.ADD.TabIndex = 7;
            this.ADD.Text = "Thêm";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(375, 383);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(75, 23);
            this.SAVE.TabIndex = 8;
            this.SAVE.Text = "Lưu";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(260, 383);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(75, 23);
            this.DELETE.TabIndex = 9;
            this.DELETE.Text = "Xóa";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(604, 383);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(75, 23);
            this.EXIT.TabIndex = 10;
            this.EXIT.Text = "Thoát";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // NOTSAVE
            // 
            this.NOTSAVE.Location = new System.Drawing.Point(492, 383);
            this.NOTSAVE.Name = "NOTSAVE";
            this.NOTSAVE.Size = new System.Drawing.Size(75, 23);
            this.NOTSAVE.TabIndex = 11;
            this.NOTSAVE.Text = "Không Lưu";
            this.NOTSAVE.UseVisualStyleBackColor = true;
            this.NOTSAVE.Click += new System.EventHandler(this.NOTSAVE_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(537, 199);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "MaSP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "NgayNhap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "TenSP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "LoaiSP";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Giải Khát",
            "Bánh Kẹo"});
            this.comboBox1.Location = new System.Drawing.Point(542, 249);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(519, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "QUAN LY SAN PHAM ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 479);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.NOTSAVE);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.FIX);
            this.Controls.Add(this.IDsp);
            this.Controls.Add(this.NAMEsp);
            this.Controls.Add(this.timtheotenSP);
            this.Controls.Add(this.FIND);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Mã SP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button FIND;
        private System.Windows.Forms.TextBox timtheotenSP;
        private System.Windows.Forms.TextBox NAMEsp;
        private System.Windows.Forms.TextBox IDsp;
        private System.Windows.Forms.Button FIX;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button NOTSAVE;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}

