using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToodeDB_DM
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\Tooded.mdf; Integrated Security = True");
        SqlCommand command;
        SqlDataAdapter adapter;
        int id = 0;
        public Form1()
        {
            InitializeComponent();

        }
        private void DisplayData()
        {
            connect.Open();
            DataTable tabel = new DataTable();
            adapter = SqlDataAdapter("SELECT * FROM Toodetable", connect);
            adapter.Fill(tabel);
            dataGridView1.DataSource = tabel;
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
            if (Lisa.Text != "" && Uuenda.Text !="" && Kustuta.Text !="")
            {
                command = new SqlCommand("INSERT INFO Toodetable(Toodenimetus,Kogus,Hind)" +
                    "VALUES(@toode,@kogus,@hind)",connect);
                connect.Open();
                command.Parameters.AddWithValue("@toode", Lisa.Text);
                command.Parameters.AddWithValue("@kogus", Uuenda.Text);
                command.Parameters.AddWithValue("@hind", Kustuta.Text);
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventHandler e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Lisa.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Lisa.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Lisa.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
