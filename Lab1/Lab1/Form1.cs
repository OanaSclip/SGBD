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

namespace Lab1
{
    public partial class PlayersDataView : Form
    {

        SqlConnection connectSql = new SqlConnection("DATA SOURCE = DESKTOP-RED181G\\OANASQL; INITIAL CATALOG = NBAChampionship; INTEGRATED SECURITY = True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet set = new DataSet();
        DataSet hall = new DataSet();

        public PlayersDataView()
        {
            InitializeComponent();
        }

        private void Players_Click(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            adapter.SelectCommand = new SqlCommand("SELECT * FROM Player", connectSql);
            set.Clear();
            adapter.Fill(set);
            PlayerView.DataSource = set.Tables[0];
        }

        private void PlayerView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = PlayerView.CurrentCell.RowIndex;
       
            adapter.SelectCommand = new SqlCommand("SELECT * FROM Player where id_player=@id", connectSql);
            set.Clear();
            adapter.Fill(set);
            PlayerView.DataSource = set.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adapter.SelectCommand = new SqlCommand("SELECT * FROM Player", connectSql);
            set.Clear();
            adapter.Fill(set);
            PlayerDataView.DataSource = set.Tables[0];
        }

        private void PlayerDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
            adapter.SelectCommand = new SqlCommand("SELECT * FROM HallOfFame where id_player=@id", connectSql);
            adapter.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Int32.Parse(PlayerDataView.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString());
            hall.Clear();
            adapter.Fill(hall);
            HallDataView.DataSource = hall.Tables[0];
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                int index = HallDataView.CurrentCell.RowIndex;
            adapter.UpdateCommand = new SqlCommand("UPDATE HallOfFame set points=@p, id_player=@pid where id_hall=@id", connectSql);
            adapter.UpdateCommand.Parameters.Add("@id", SqlDbType.Int).Value = Int32.Parse(HallDataView.Rows[index].Cells[0].Value.ToString());
            adapter.UpdateCommand.Parameters.Add("@pid", SqlDbType.Int).Value = PIDHall.Text;
            adapter.UpdateCommand.Parameters.Add("@p", SqlDbType.Int).Value = PointsHall.Text;
            connectSql.Open();
            adapter.UpdateCommand.ExecuteNonQuery();
            connectSql.Close();
            hall.Clear();
            adapter.Fill(hall);
            HallDataView.DataSource = hall.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error in adding the data");
                connectSql.Close();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = HallDataView.CurrentCell.RowIndex;
                adapter.DeleteCommand = new SqlCommand("Delete from HallOfFame  where id_hall=@id", connectSql);
                adapter.DeleteCommand.Parameters.Add("@id", SqlDbType.Int).Value = Int32.Parse(HallDataView.Rows[index].Cells[0].Value.ToString());
                connectSql.Open();
                adapter.DeleteCommand.ExecuteNonQuery();
                connectSql.Close();
                hall.Clear();
                adapter.Fill(hall);
                HallDataView.DataSource = hall.Tables[0];
            }
			catch (Exception ex)
			{
				MessageBox.Show("There was an error in adding the data");
				connectSql.Close();
			}
}

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                int index = PlayerDataView.CurrentCell.RowIndex;

            adapter.InsertCommand = new SqlCommand("INSERT INTO HallOfFame VALUES (@pid,@p)", connectSql);
            adapter.InsertCommand.Parameters.Add("@pid", SqlDbType.NVarChar).Value = Int32.Parse(PlayerDataView.Rows[index].Cells[0].Value.ToString());
            adapter.InsertCommand.Parameters.Add("@p", SqlDbType.NVarChar).Value = PointsHall.Text;

            connectSql.Open();
            adapter.InsertCommand.ExecuteNonQuery();
            connectSql.Close();
            hall.Clear();
            adapter.Fill(hall);
            HallDataView.DataSource = hall.Tables[0];
        }
			catch (Exception ex)
			{
				MessageBox.Show("There was an error in adding the data");
				connectSql.Close();
			}
}

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
