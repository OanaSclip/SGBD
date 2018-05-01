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
using System.Configuration;


namespace Lab2SGBD
{
    public partial class Form1 : Form
    {
        SqlConnection conexiune;
        DataSet ds;
        SqlDataAdapter da;

        //Binding sources
        BindingSource bsC;
        BindingSource bsP;
        List<TextBox> textBoxList;
        List<Label> labelList;
        int idx = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void fillDataSet()
        {
            conexiune.Open();
            
            string selectcmd = ConfigurationManager.AppSettings["ParentSelectCmd"];
            da.SelectCommand = new SqlCommand(selectcmd, conexiune);
            da.Fill(ds, "ParentTable");

            selectcmd = ConfigurationManager.AppSettings["ChildSelectCmd"];
            da.SelectCommand = new SqlCommand(selectcmd, conexiune);
            da.Fill(ds, "ChildTable");
            conexiune.Close();
        }

        public void getData()
        {
            //setare bidingSource
            string parentId = ConfigurationManager.AppSettings["idParent"];

            DataRelation relation = new DataRelation("Parent_Child_FK",
                ds.Tables["ParentTable"].Columns[parentId],
                ds.Tables["ChildTable"].Columns[parentId]);
            ds.Relations.Add(relation);

            bsP.DataSource = ds;
            bsP.DataMember = "ParentTable";

            bsC.DataSource = bsP;
            bsC.DataMember = "Parent_Child_FK";
        }

        public void populateDataGridViews()
        {
            parentDataGridView.DataSource = bsP;
            childDataGridView.DataSource = bsC;
            getData();
            childDataGridView.AutoResizeColumns();
            parentDataGridView.AutoGenerateColumns = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings conSet = ConfigurationManager.ConnectionStrings["conStr"];
            string connectionString = conSet.ConnectionString;
            conexiune = new SqlConnection(connectionString);

            bsP = new BindingSource();
            bsC = new BindingSource();
            da = new SqlDataAdapter();
            ds = new DataSet();

            fillDataSet();
            populateDataGridViews();
            setUpTextBoxAndLabels();
        }


        /* setare panel cu textboxuri pentru id_player si points
         */
        private void setUpTextBoxAndLabels()
        {
            idx = 0;
            textBoxList = new List<TextBox>();
            labelList = new List<Label>();

            foreach (Control item in panel1.Controls.OfType<TextBox>())
            {
                panel1.Controls.Remove(item);
            }
            foreach (Control item in panel1.Controls.OfType<Label>())
            {
                panel1.Controls.Remove(item);
            }
            int columnNr = ds.Tables["ChildTable"].Columns.Count;

            for (int i = 1; i < columnNr; i++)
            {
                Label label = new Label();
                label.Text = ds.Tables["ChildTable"].Columns[i].ColumnName;

                
                Point textP = new Point(idx * 120, 44);
                Point lableP = new Point(idx * 120, 30);
                label.Location = lableP;
                label.AutoSize = true;

                TextBox textBox = new TextBox();
                textBox.Location = textP;
                textBoxList.Add(textBox);
                labelList.Add(label);
                idx++;

                panel1.Controls.Add(label);
                panel1.Controls.Add(textBox);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //adaugare
            conexiune.Open();
            string value;
            int i;
            int selectedRowindex = parentDataGridView.SelectedCells[0].RowIndex;
            string foreingID = parentDataGridView.Rows[selectedRowindex].Cells[0].Value.ToString();
            string insertCmd = ConfigurationSettings.AppSettings["ChildInsertCmd"];
            da.InsertCommand = new SqlCommand(insertCmd, conexiune);
            int nrColumns = ds.Tables["ChildTable"].Columns.Count;
            for (i = 0; i < nrColumns - 1; i++)
            {
                value = "@value" + (i + 1).ToString();
                da.InsertCommand.Parameters.AddWithValue(value,textBoxList[i].Text);
            }
            value = "@value" + (i + 1).ToString();
            da.InsertCommand.Parameters.AddWithValue(value, foreingID);
            da.InsertCommand.ExecuteNonQuery();
            ds.Tables["ChildTable"].Clear();
            string selectcmd = ConfigurationManager.AppSettings["ChildSelectCmd"];
            da.SelectCommand = new SqlCommand(selectcmd, conexiune);
            da.Fill(ds, "ChildTable");
            conexiune.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //actualizare
            if (childDataGridView.SelectedCells.Count > 0)
            {
                conexiune.Open();
                string updateCmd = ConfigurationSettings.AppSettings["ChildUpdateCmd"];
                da.UpdateCommand = new SqlCommand(updateCmd, conexiune);
                //Id_hall
                String id_hall = childDataGridView.CurrentRow.Cells[0].Value.ToString();
                int index = ds.Tables["ChildTable"].Columns.Count;
                int i = 0;
                string value;
                for (i = 0; i < index - 1; i++)
                {
                    value = "@value" + (i + 1).ToString();
                    //da.UpdateCommand.Parameters.Add(value, SqlDbType.VarChar).Value = textBoxList[i].Text;
                    da.UpdateCommand.Parameters.AddWithValue(value, textBoxList[i].Text);
                }
                value = "@value" + (i + 1).ToString();
                da.UpdateCommand.Parameters.AddWithValue(value, id_hall);               
                da.UpdateCommand.ExecuteNonQuery();
                ds.Tables["ChildTable"].Clear();
                string selectcmd = ConfigurationManager.AppSettings["ChildSelectCmd"];
                da.SelectCommand = new SqlCommand(selectcmd, conexiune);
                da.Fill(ds, "ChildTable");
                conexiune.Close();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (childDataGridView.SelectedCells.Count > 0)
            {
                conexiune.Open();
                int selectedrowindex = childDataGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = childDataGridView.Rows[selectedrowindex];

                string toDeletedId = Convert.ToString(selectedRow.Cells[0].Value);

                string deleteCmd = ConfigurationSettings.AppSettings["ChildDeleteCmd"];
                da.DeleteCommand = new SqlCommand(deleteCmd, conexiune);

                da.DeleteCommand.Parameters.AddWithValue("value",toDeletedId);

                da.DeleteCommand.ExecuteNonQuery();
                ds.Tables["ChildTable"].Clear();
                string selectcmd = ConfigurationManager.AppSettings["ChildSelectCmd"];
                da.SelectCommand = new SqlCommand(selectcmd, conexiune);
                da.Fill(ds, "ChildTable");

                conexiune.Close();
            }
            else
                MessageBox.Show("Selectati o linie");
        }

        private void childDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}