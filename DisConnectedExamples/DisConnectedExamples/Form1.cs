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
            CN=new MySqlConnection("Data Source=192.168.100.80; PORT=3306; Database=group011;User Id=group011; Password=welcome;");
            DA=new MySqlDataAdapter("Select * from Customers1", CN);
            DS=new DataSet();
            DA.Fill(DS, "Customers2");
            dgvCustomer.DataSource = DS.Tables[0];

            DA1 = new MySqlDataAdapter("select * from Emp", CN);
            DA1.Fill(DS, "employee");
            


        }
    }
}
