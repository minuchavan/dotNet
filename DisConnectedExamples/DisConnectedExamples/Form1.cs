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



namespace DisConnectedExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection CN;
        MySqlDataAdapter DA;
        MySqlDataAdapter DA1;
        DataSet DS;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            CN=new MySqlConnection("Data Source=127.0.0.1; PORT=3306; Database=tush;User Id=root; Password=root123;");
            DA=new MySqlDataAdapter("Select * from Customers", CN);
            DS=new DataSet();
            DA.Fill(DS, "Customers");
            dgvCustomer.DataSource = DS.Tables[0];

           
            


        }
    }
}
