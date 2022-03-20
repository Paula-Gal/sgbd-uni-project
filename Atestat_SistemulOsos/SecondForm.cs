using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lab1sgbd
{
    public partial class SecondForm : Form
    {
        SqlConnection cs = new SqlConnection("Data Source=DESKTOP-FTIQD6C;Initial Catalog=TransfusionCenterDatabaseV6;Integrated Security=True");

        SqlDataAdapter adapter = new SqlDataAdapter();

        DataSet dataSetCollection = new DataSet();

        BindingSource bs = new BindingSource();

        int pos;

        public SecondForm(int pos)
        {
            InitializeComponent();
            this.pos = pos;
            PopulateDataGridViewCollections();
        }

        private void PopulateDataGridViewCollections()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Collections WHERE TransfusionCenterID=@id", cs);
            command.Parameters.AddWithValue("@id", pos);

            adapter = new SqlDataAdapter(command);

            adapter.Fill(dataSetCollection, "Collections");
            dataGridViewCollections.DataSource = dataSetCollection.Tables["Collections"];
            bs.DataSource = dataSetCollection.Tables["Collections"];

            textBoxTrCenterName.DataBindings.Add("Text", bs, "TansfusionCenter");
            textBoxPr.DataBindings.Add("Text", bs, "Program");
            textBoxLocation.DataBindings.Add("Text", bs, "Location");
            textBoxTrCenterID.DataBindings.Add("Text", bs, "TransfusionCenterID");
            textBoxDate.DataBindings.Add("Text", bs, "Date");
        }

        private void refresh()
        {
            dataSetCollection.Clear();

            SqlCommand command = new SqlCommand("SELECT * FROM Collections WHERE TransfusionCenterID=@id", cs);
            command.Parameters.AddWithValue("@id", pos);

            adapter = new SqlDataAdapter(command);

            adapter.Fill(dataSetCollection, "Collections");
            dataGridViewCollections.DataSource = dataSetCollection.Tables["Collections"];
            bs.DataSource = dataSetCollection.Tables["Collections"];
        }

        private void ThirdForm_Load(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void dataGridViewChild_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void records()
        {
            labelPoz.Text = "Record" + bs.Position + " of " + (bs.Count - 1);
        }

        private void dataGridViewUpdate()
        {
            dataGridViewCollections.ClearSelection();
            dataGridViewCollections.Rows[bs.Position].Selected = true;
            records();
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddCollection_Click_1(object sender, EventArgs e)
        {
            try
            {
                adapter.InsertCommand = new SqlCommand("insert into Collections (TansfusionCenter, Program, Location, TransfusionCenterID, Date) VALUES(@tr, @program, @location, @trID, @Date)", cs);
                adapter.InsertCommand.Parameters.Add("@tr", SqlDbType.VarChar).Value = textBoxTrCenterName.Text;
                adapter.InsertCommand.Parameters.Add("@program", SqlDbType.VarChar).Value = textBoxPr.Text;
                adapter.InsertCommand.Parameters.Add("@location", SqlDbType.VarChar).Value = textBoxLocation.Text;
                adapter.InsertCommand.Parameters.Add("@trID", SqlDbType.Int).Value = Int32.Parse(textBoxTrCenterID.Text);
                adapter.InsertCommand.Parameters.Add("@date", SqlDbType.VarChar).Value = textBoxDate.Text;
                cs.Open();
                adapter.InsertCommand.ExecuteNonQuery();
                cs.Close();
                // already inserted - apear in the list
                //adapter.Fill(ds);
                dataGridViewCollections.DataSource = dataSetCollection.Tables[0];
                textBoxTrCenterName.Clear();
                textBoxPr.Clear();
                textBoxLocation.Clear();
                textBoxTrCenterID.Clear();
                textBoxDate.Clear();

                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cs.Close();
            }
        }

        private void buttonDeleteChild_Click_1(object sender, EventArgs e)
        {
            try
            {
                adapter.DeleteCommand = new SqlCommand("delete from Collections where CollectionID=@id", cs);
                adapter.DeleteCommand.Parameters.Add("@id", SqlDbType.Int).Value = dataSetCollection.Tables[0].Rows[bs.Position][0];

                cs.Open();
                adapter.DeleteCommand.ExecuteNonQuery();
                cs.Close();
                dataSetCollection.Clear();

                refresh();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cs.Close();
            }

        }

        private void buttonUpdateChild_Click_1(object sender, EventArgs e)
        {
            try
            {
                int x;

                adapter.UpdateCommand = new SqlCommand("update Collections set TansfusionCenter=@trName, Program=@program, Location=@location, Date=@date, TransfusionCenterID=@trID where CollectionID=@clID", cs);
                adapter.UpdateCommand.Parameters.Add("@trName", SqlDbType.VarChar).Value = textBoxTrCenterName.Text;
                adapter.UpdateCommand.Parameters.Add("@program", SqlDbType.VarChar).Value = textBoxPr.Text;
                adapter.UpdateCommand.Parameters.Add("@location", SqlDbType.VarChar).Value = textBoxLocation.Text;
                adapter.UpdateCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = textBoxDate.Text;
                adapter.UpdateCommand.Parameters.Add("@trID", SqlDbType.Int).Value = textBoxTrCenterID.Text;
                adapter.UpdateCommand.Parameters.Add("@clID", SqlDbType.Int).Value = dataSetCollection.Tables[0].Rows[bs.Position][0];

                cs.Open();
                x = adapter.UpdateCommand.ExecuteNonQuery();
                cs.Close();

                if (x >= 1)
                {
                    MessageBox.Show("The record has been updated!");
                }

                refresh();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cs.Close();
            }
        }

        private void textBoxTrCenterName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTrCenterID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLast_Click_1(object sender, EventArgs e)
        {
            bs.MoveLast();
            dataGridViewUpdate();
            records();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
            dataGridViewUpdate();
            records();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
            dataGridViewUpdate();
            records();
        }

        private void buttonFirst_Click_1(object sender, EventArgs e)
        {
            bs.MoveFirst();
            dataGridViewUpdate();
            records(); bs.MoveFirst();
            dataGridViewUpdate();
            records();
        }

        private void dataGridViewCollections_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}