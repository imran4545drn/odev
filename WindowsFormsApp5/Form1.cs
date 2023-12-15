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

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string constring = "DESKTOP-UCAQ5TB\\SQLEXPRESS";
        SqlConnection Connect = new SqlConnection(constring);

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)

            }
            connect.Open();
            string kayitekle = "insert into bilgiler(adi.soyadi) values (@kisi_adi,@kisi_soyadi)";
             SqlCommand komut = new SqlCommand(kayitekle.connect);
            komut.Parameters.AddWithValue("@kisi_adi", textBox1);
            komut.Parametrs.AddWithValue("@kisi_soyadi", textBox2);

            komut.Execute.NonQuery();
            Connect.Close();
            MessageBox.Show("işlem yapıldı");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelDataSet2.Table_1' table. You can move, or remove it, as needed.
            this.table_1TableAdapter.Fill(this.personelDataSet2.Table_1);

        }
    }
    catch(Exception uyari)
   }
      MessageBox.Show("uyarınız var" + uyari);



