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

namespace AssignmentDisconnectedArchitecture
{
    public partial class employeedataonlyprint : Form
    {
        public employeedataonlyprint()
        {
            InitializeComponent();
        }
        MySqlConnection CN;
        MySqlDataAdapter DA;
    
        DataSet DS;
        private void employeedataonlyprint_Load(object sender, EventArgs e)
        {
            CN = new MySqlConnection("Data Source=192.168.100.80; PORT=3306; Database=group011;User Id=group011; Password=welcome;");
            DA = new MySqlDataAdapter("Select * from Employees", CN);
            DS = new DataSet();
            DA.Fill(DS, "Employee");
            dgvEmployee.DataSource = DS.Tables[0];

           

        }
    }
}
