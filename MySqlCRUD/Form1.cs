using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySqlCRUD
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readData();
        }

        Connection connect = new Connection();
        MySqlDataAdapter dataAdapter;
        DataTable dataTable;

        public void readData()
        {
            MySqlConnection conn = connect.dbConnect();
            String query = "SELECT * From crud_table";
            dataTable = new DataTable();
            dataAdapter = new MySqlDataAdapter(query, conn);
            dataAdapter.Fill(dataTable);
            gridData.DataSource = dataTable;
        }
    }
}
