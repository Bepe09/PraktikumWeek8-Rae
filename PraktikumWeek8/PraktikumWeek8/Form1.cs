using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PraktikumWeek8
{
    public partial class FormHasilPertandingan : Form
    {
        public FormHasilPertandingan()
        {
            InitializeComponent();

        }
            public static string sqlConnection = "server=localhost;uid=root;pwd=;database=premier_league";
            public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
            public MySqlCommand sqlCommand;
            public MySqlDataAdapter sqlAdapter;


            public string sqlQuery;
        

        private void comboBoxTim1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelValue.Text = comboBoxTim1
        }

        private void FormHasilPertandingan_Load(object sender, EventArgs e)
        {
            DataTable dtTeam = new DataTable();
            sqlQuery = "SELECT team_name as 'Nama Tim', team_is as 'ID Team' FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            comboBoxTim1.DataSource = dtTeam;
            comboBoxTim1.DisplayMember = "Nama Tim";
            comboBoxTim1.ValueMember = "ID Team";

        }
    }
}
