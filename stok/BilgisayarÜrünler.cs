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

namespace stok
{
    public partial class BilgisayarÜrünler : Form
    {
        public BilgisayarÜrünler()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlDataAdapter da;
        DataSet ds;
        DataClasses1DataContext db;
        SqlCommandBuilder cmdb;
        private void BilgisayarÜrünler_Load(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            comboBox1.ValueMember = "PcMarkaID";
            comboBox1.DisplayMember = "PcMarkaAdi";
            comboBox1.DataSource = db.Stok_PcMarka.ToList();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                var markammodel = from i in db.Stok_PcModel
                                  where i.PcModelMarkaID == Convert.ToInt32(comboBox1.SelectedValue)
                                  select i;
                comboBox2.ValueMember = "PcModelID";
                comboBox2.DisplayMember = "PcModelAdi";
                comboBox2.DataSource = markammodel;

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var modelparca = from i in db.Stok_PcParca
                             where i.ParcaModelID == Convert.ToInt32(comboBox2.SelectedValue)
                             select i;

            dataGridView1.DataSource = modelparca;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            Form1 form2sec = new Form1();
            form2sec.Show();
            this.Hide();
        }
    }
}
