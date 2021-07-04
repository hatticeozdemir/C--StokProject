using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace stok
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlDataAdapter da;
        DataSet ds;
        DataClasses1DataContext db;
        SqlCommandBuilder cmdb;
        
       

        private void Form4_Load(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            comboBox1.ValueMember = "Stok_MarkaID";
            comboBox1.DisplayMember = "Stok_MarkaAdi";
            comboBox1.DataSource = db.Stok_TelMarka.ToList();
            /*
             SqlConnection connection = new SqlConnection();
             connection.ConnectionString = "Data Source=DESKTOP-KSLE4AO\\SQLEXPRESS;Initial Catalog=STOK; Integrated Security=True;";
             connection.Open();
             DataTable dt = connection.GetSchema("Tables");


              for (int i=0; i<dt.Rows.Count; i++)
              {
                  comboBox2.Items.Add(dt.Rows[i]["TABLE_ID"]);
              }
              connection.Close();
             */
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBox1.SelectedIndex != -1)
            {
                var markammodel = from i in db.Stok_TelModel
                                  where i.Stok_TelMarkaID == Convert.ToInt32(comboBox1.SelectedValue)
                                  select i;
                comboBox2.ValueMember = "Stok_ModelID";
                comboBox2.DisplayMember = "Stok_ModelAdı";
                comboBox2.DataSource = markammodel;

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var modelparca = from i in db.Stok_TelParca
                             where i.Stok_ModelID == Convert.ToInt32(comboBox2.SelectedValue)
                             select i;

            dataGridView1.DataSource = modelparca;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
  
        }

        private void dataGridView1_AutoSizeColumnsModeChanged(object sender, DataGridViewAutoSizeColumnsModeEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Form1 formCIKIS = new Form1();
            formCIKIS.Show();
            this.Hide();
        }
        public string mno;
        public int satir;
        private void telstok_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.DataSource == null)
            {
               
               MessageBox.Show("LÜTFEN İŞLEMİNİZİ ONAYLAYINIZ.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                Form3 formSTOK = new Form3();
                formSTOK.a = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                formSTOK.b = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                formSTOK.c = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                formSTOK.d = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                formSTOK.Show();
                this.Hide();
            }
           
        }

        private void dataGridView1_AutoSizeColumnModeChanged(object sender, DataGridViewAutoSizeColumnModeEventArgs e)
        {

        }

       
    }
}
