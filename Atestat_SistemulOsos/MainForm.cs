using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lab1sgbd
{
    public partial class MainForm : Form
    {
        SqlConnection cs = new SqlConnection("Data Source=DESKTOP-FTIQD6C;Initial Catalog=TransfusionCenterDatabaseV6;Integrated Security=True");

        SqlDataAdapter adapter = new SqlDataAdapter();

        DataSet ds = new DataSet();

        BindingSource bs = new BindingSource();

        public MainForm()
        {
            InitializeComponent();
            PopulateDataGridViewTransfusionCenters();
        }

        private void PopulateDataGridViewTransfusionCenters()
        {
            //populate DataGridView with the content of TransfusionCenters Table

            adapter.SelectCommand = new SqlCommand("select * from TransfusionCenters", cs);
            ds.Clear();
            adapter.Fill(ds);
            dataGridViewTransfuionCenters.DataSource = ds.Tables[0];
            bs.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addTrCenter_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonCollections_Click(object sender, EventArgs e)
        {
            // trimit id-ul parintelui selectat
           SecondForm collections = new SecondForm(Convert.ToInt32(dataGridViewTransfuionCenters.Rows[bs.Position].Cells[0].Value));
           collections.Show();
        }

        private void firstBtn_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
            dataGridViewUpdate();
            records();
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
            dataGridViewUpdate();
            records();
        }

        private void records()
        {
            labelPoz.Text = "Record" + bs.Position + " of " + (bs.Count - 1);
        }

        private void dataGridViewUpdate()
        {
            dataGridViewTransfuionCenters.ClearSelection();
            dataGridViewTransfuionCenters.Rows[bs.Position].Selected = true;
            records();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
            dataGridViewUpdate();
            records();
        }

        private void lastBtn_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
            dataGridViewUpdate();
            records();
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}