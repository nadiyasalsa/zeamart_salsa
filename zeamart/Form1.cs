using MySql.Data.MySqlClient;
using Mysqlx.Session;
using System.Data;

namespace zeamart
{
    public partial class Form1 : Form
    {
        int i = 0;

        MySqlConnection koneksi = connections.getConnection();
        DataTable dataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(koneksi, "SET @id := 0; UPDATE book SET id = @id := (@id+1); " +
                "ALTER TABLE book AUTO_INCREMENT = 1;");

            script.Execute();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filldataTable();
        }

        public DataTable getDataBuku()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM book", koneksi))
            {
                koneksi.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;

        }

        public void filldataTable()
        {
            dataGridView1.DataSource = getDataBuku();
        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                p_image.Image = new Bitmap(openFileDialog.FileName);
                p_image.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            byte[] imageData;
            using (MemoryStream ms = new MemoryStream())
            {
                p_image.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageData = ms.ToArray();
            }
            MySqlCommand cmd;

            try
            {
                resetIncrement();

                cmd = koneksi.CreateCommand();
                cmd.CommandText = "insert into book (judul, penulis, penerbit, harga, stok, image) VALUE (@judul, @penulis, @penerbit, @harga, @stok, @image)";
                cmd.Parameters.AddWithValue("@judul", tb_judul.Text);
                cmd.Parameters.AddWithValue("@penulis", tb_penulis.Text);
                cmd.Parameters.AddWithValue("@penerbit", tb_penerbit.Text);
                cmd.Parameters.AddWithValue("@harga", tb_harga.Text);
                cmd.Parameters.AddWithValue("@stok", tb_stok.Text);
                cmd.Parameters.AddWithValue("@image", imageData);

                cmd.ExecuteNonQuery();
                koneksi.Close();
                dataTable.Clear();
                filldataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error karena = " + ex);
            }
        }

        public void searchData(string ValueToFind)
        {
            string searchQuery = "SELECT * FROM book WHERE CONCAT (judul, penulis, penerbit, harga, stok) LIKE '%" + ValueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, koneksi);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void tb_searchdata_TextChanged(object sender, EventArgs e)
        {
            searchData(tb_searchdata.Text);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            p_image.Image.Save(ms, p_image.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand cmd;
            // mengecek apakah ada field yang kosong
            if ((tb_id.Text == string.Empty || tb_judul.Text == string.Empty || tb_penulis.Text == string.Empty || tb_penerbit.Text == string.Empty || tb_harga.Text == string.Empty || tb_stok.Text == string.Empty))
            {
                MessageBox.Show("Tolong isi semua field !", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "UPDATE book SET judul=@judul, penulis=@penulis, penerbit=@penerbit, harga=@harga, stok=@stok, image=@image where id=@id";
                cmd.Parameters.AddWithValue("@id", tb_id.Text);
                cmd.Parameters.AddWithValue("@judul", tb_judul.Text);
                cmd.Parameters.AddWithValue("@penulis", tb_penulis.Text);
                cmd.Parameters.AddWithValue("@penerbit", tb_penerbit.Text);
                cmd.Parameters.AddWithValue("@harga", tb_harga.Text);
                cmd.Parameters.AddWithValue("@stok", tb_stok.Text);
                cmd.Parameters.AddWithValue("@image", img);
                cmd.ExecuteNonQuery();

                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("yipiyey data berhasil diupdate nich :)", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("yaahh data lom berhasil diupdate T_T", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                koneksi.Close();
                filldataTable();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            resetIncrement();
            int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());

            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "DELETE FROM `book` WHERE id=@id";
            cmd.Parameters.AddWithValue("@id", tb_id.Text);
            i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("yipiyey data berhasil dihapus nich :)", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("yaahh data lom berhasil dihapus T_T", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            koneksi.Close();
            filldataTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());
            tb_id.Text = dataGridView1.Rows[id].Cells[0].Value.ToString();
            tb_judul.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
            tb_penulis.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
            tb_penerbit.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();
            tb_harga.Text = dataGridView1.Rows[id].Cells[4].Value.ToString();
            tb_stok.Text = dataGridView1.Rows[id].Cells[5].Value.ToString();

            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(img);
            p_image.Image = Image.FromStream(ms);
        }
    }
}