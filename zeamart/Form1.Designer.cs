namespace zeamart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tb_searchdata = new TextBox();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            btn_image = new Button();
            label3 = new Label();
            tb_stok = new TextBox();
            tb_id = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btn_delete = new Button();
            btn_update = new Button();
            pictureBox2 = new PictureBox();
            btn_new = new Button();
            label8 = new Label();
            label7 = new Label();
            tb_harga = new TextBox();
            tb_penerbit = new TextBox();
            tb_penulis = new TextBox();
            tb_judul = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            p_image = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p_image).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tb_searchdata
            // 
            tb_searchdata.Location = new Point(82, 27);
            tb_searchdata.Name = "tb_searchdata";
            tb_searchdata.Size = new Size(880, 31);
            tb_searchdata.TabIndex = 12;
            tb_searchdata.TextChanged += tb_searchdata_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(940, 228);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientInactiveCaption;
            panel4.Controls.Add(tb_searchdata);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(dataGridView1);
            panel4.Location = new Point(25, 565);
            panel4.Name = "panel4";
            panel4.Size = new Size(982, 340);
            panel4.TabIndex = 13;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(22, 27);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(49, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // btn_image
            // 
            btn_image.BackColor = SystemColors.ActiveCaption;
            btn_image.Location = new Point(210, 279);
            btn_image.Name = "btn_image";
            btn_image.Size = new Size(150, 34);
            btn_image.TabIndex = 17;
            btn_image.Text = "Browse";
            btn_image.UseVisualStyleBackColor = false;
            btn_image.Click += btn_image_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(393, 324);
            label3.Name = "label3";
            label3.Size = new Size(47, 25);
            label3.TabIndex = 16;
            label3.Text = "Stok";
            // 
            // tb_stok
            // 
            tb_stok.Location = new Point(524, 318);
            tb_stok.Name = "tb_stok";
            tb_stok.Size = new Size(422, 31);
            tb_stok.TabIndex = 15;
            // 
            // tb_id
            // 
            tb_id.Location = new Point(524, 37);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(422, 31);
            tb_id.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(btn_image);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(tb_stok);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(tb_id);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(tb_harga);
            panel2.Controls.Add(tb_penerbit);
            panel2.Controls.Add(tb_penulis);
            panel2.Controls.Add(tb_judul);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(p_image);
            panel2.Location = new Point(25, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 404);
            panel2.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(btn_delete);
            panel3.Controls.Add(btn_update);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(btn_new);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(184, 404);
            panel3.TabIndex = 11;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.GradientActiveCaption;
            btn_delete.Location = new Point(12, 320);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(156, 34);
            btn_delete.TabIndex = 11;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.GradientActiveCaption;
            btn_update.Location = new Point(12, 265);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(156, 34);
            btn_update.TabIndex = 10;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.image_removebg_preview__82_;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 174);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // btn_new
            // 
            btn_new.BackColor = SystemColors.GradientActiveCaption;
            btn_new.Location = new Point(12, 216);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(156, 34);
            btn_new.TabIndex = 4;
            btn_new.Text = "New";
            btn_new.UseVisualStyleBackColor = false;
            btn_new.Click += btn_new_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(393, 43);
            label8.Name = "label8";
            label8.Size = new Size(28, 25);
            label8.TabIndex = 13;
            label8.Text = "Id";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(22, 49, 140);
            label7.Location = new Point(210, 21);
            label7.Name = "label7";
            label7.Size = new Size(115, 25);
            label7.TabIndex = 12;
            label7.Text = "| Form Buku";
            // 
            // tb_harga
            // 
            tb_harga.Location = new Point(524, 259);
            tb_harga.Name = "tb_harga";
            tb_harga.Size = new Size(422, 31);
            tb_harga.TabIndex = 11;
            // 
            // tb_penerbit
            // 
            tb_penerbit.Location = new Point(524, 204);
            tb_penerbit.Name = "tb_penerbit";
            tb_penerbit.Size = new Size(422, 31);
            tb_penerbit.TabIndex = 10;
            // 
            // tb_penulis
            // 
            tb_penulis.Location = new Point(524, 143);
            tb_penulis.Name = "tb_penulis";
            tb_penulis.Size = new Size(422, 31);
            tb_penulis.TabIndex = 9;
            // 
            // tb_judul
            // 
            tb_judul.Location = new Point(524, 89);
            tb_judul.Name = "tb_judul";
            tb_judul.Size = new Size(422, 31);
            tb_judul.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(393, 265);
            label6.Name = "label6";
            label6.Size = new Size(60, 25);
            label6.TabIndex = 6;
            label6.Text = "Harga";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(393, 210);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 5;
            label5.Text = "Penerbit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(393, 149);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 4;
            label4.Text = "Penulis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(393, 95);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 2;
            label2.Text = "Judul";
            // 
            // p_image
            // 
            p_image.BackColor = Color.White;
            p_image.BorderStyle = BorderStyle.Fixed3D;
            p_image.Location = new Point(210, 73);
            p_image.Name = "p_image";
            p_image.Size = new Size(150, 181);
            p_image.TabIndex = 0;
            p_image.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 49, 140);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1034, 105);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(102, 39);
            label1.Name = "label1";
            label1.Size = new Size(254, 32);
            label1.TabIndex = 1;
            label1.Text = "Welcome to ZeaMart";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 920);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)p_image).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tb_searchdata;
        private DataGridView dataGridView1;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Button btn_image;
        private Label label3;
        private TextBox tb_stok;
        private TextBox tb_id;
        private Panel panel2;
        private Label label8;
        private Label label7;
        private TextBox tb_harga;
        private TextBox tb_penerbit;
        private TextBox tb_penulis;
        private TextBox tb_judul;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private PictureBox p_image;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_new;
        private Button btn_delete;
        private Button btn_update;
        private PictureBox pictureBox2;
        private Panel panel3;
    }
}