using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToodeDB_DM
{
    public partial class Form1 : Form
    {
        PictureBox pictureb1;
        ComboBox combobox1;
        SaveFileDialog save;
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\Tooded.mdf; Integrated Security = True");
        SqlCommand command;
        SqlDataAdapter adapter;
        int id = 0;
        public Form1()
        {
            InitializeComponent();
            DisplayData();

        }
        private void DisplayData()
        {
            connect.Open();
            DataTable tabel = new DataTable();
            adapter = SqlDataAdapter("SELECT * FROM Toodetable", connect);
            adapter.Fill(tabel);
            dataGridView1.DataSource = tabel;
            pictureb1 = new PictureBox();
            pictureb1.Image = Image.FromFile("../../images/list.png");

            SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT Kategooria_nimetus FROM Kategooria", connect);
            DataTable kat_tabel = new DataTable();
            adapter2.Fill(kat_tabel); 
            foreach (DataRow row in kat_tabel.Rows)
            {
                combobox1 = new ComboBox();
                combobox1.Items.Add(row["Kategooria_nimetus"]);
            }
            connect.Close();

        }
        private void ClearData()
        {
            id = 0;
            Lisa.Text = "";
            Uuenda.Text = "";
            Kustuta.Text = "";
            
        }

        private SqlDataAdapter SqlDataAdapter(string v, SqlConnection connect)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void Lisa_Insert_Click(object sender, EventArgs e)
        {
            if (Lisa.Text != "" && Uuenda.Text !="" && Kustuta.Text !="" && combobox1.SelectedItem !=null && pictureb1.Image != null)
            {
                command = new SqlCommand("INSERT INFO Toodetable(Toodenimetus,Kogus,Hind,Pilt)" +
                    "VALUES(@toode,@kogus,@hind,@pilt)",connect);
                connect.Open();
                command.Parameters.AddWithValue("@toode", Lisa.Text);
                command.Parameters.AddWithValue("@kogus", Uuenda.Text);
                command.Parameters.AddWithValue("@hind", Kustuta.Text);
                string file_pilt = Lisa.Text + ".jpg";
                command.Parameters.AddWithValue("@pilt", file_pilt);
                command.Parameters.AddWithValue("@kat", (combobox1.SelectedIndex));
                command.ExecuteNonQuery();
                connect.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andmed on lisatud");

            }
            else
            {
                MessageBox.Show("Viga");
            }

        }

        private void Lisa_Update_Click(object sender, EventArgs e)
        {
            if (Lisa.Text != "" && Uuenda.Text != "" && Kustuta.Text != "")
            {
                command = new SqlCommand("UPDATE Toodetable SET +" +
                    "Toodenimetus=@toode, Kogus=@kogus, Hind=@hind(@toode,@kogus,@hind)", connect);
                connect.Open();
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@toode", Lisa.Text);
                command.Parameters.AddWithValue("@kogus", Uuenda.Text);
                command.Parameters.AddWithValue("@hind", Kustuta.Text.Replace(",","."));
                command.ExecuteNonQuery();
                connect.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andmed on lisatud");

            }
            else
            {
                MessageBox.Show("Viga");
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toodedDataSet.Toodetable' table. You can move, or remove it, as needed.
            this.toodetableTableAdapter.Fill(this.toodedDataSet.Toodetable);

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Lisa.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Lisa.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Lisa.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            pictureb1.Image = Image.FromFile(@"C:\Users\Kasutajad\opilane\source\repos\Mihol\MyFormsDM\MyFormsDM\" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            string v = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            combobox1.SelectedIndex = Int32.Parse(v);
        }

        private void btn_LisaPilt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            open.InitialDirectory = Path.GetFullPath(@"");
            if (open.ShowDialog()==DialogResult.OK)
            {
                save = new SaveFileDialog();
                save.FileName = Lisa.Text + "jpg";
                save.Filter = "Image(*.jpeg;*.bmp;*.png;*.jpg|*.jpeg;*.bmp;*.png;*.jpg";
                save.InitialDirectory = Path.GetFullPath(@"C:\Users\Kasutajad\opilane\source\repos\Mihol\MyFormsDM\MyFormsDM\");

                if (save.ShowDialog()==DialogResult.OK)
                {
                    File.Copy(open.FileName, save.FileName);
                    save.RestoreDirectory = true;
                    pictureb1.Image = Image.FromFile(save.FileName);
                }
            }
        }
    }

    /*
     [id] INT IDENTity (1, 1) not null,
     [Toodenimetus] varchar (50) not null,
     [kogus] int null,
     [hind] real null,
     [pilt] varchar(50),
        
     [kategooria_id] int null,
     primary key clustered ([id] ASC),
     foreign key (kategooria_id) References [dbo].[kategooria] ([id])
     []
     
     */
}
