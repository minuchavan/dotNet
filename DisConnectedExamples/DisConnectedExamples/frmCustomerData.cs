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

namespace DisConnectedExamples
{
    public partial class frmCustomerData : Form
    {
        public frmCustomerData()
        {
            InitializeComponent();
        }
        MySqlConnection CN;
        MySqlDataAdapter DA;
        MySqlDataAdapter DA1;
        MySqlCommandBuilder CMD_BLD;
        DataSet DS;
        int currentIndex = 0;

        private void frmCustomerData_Load(object sender, EventArgs e)
        {
            CN = new MySqlConnection("Data Source=127.0.0.1; PORT=3306; Database=tush;User Id=root; Password=root123;");
            DA = new MySqlDataAdapter("Select * from Customers", CN);
            CMD_BLD = new MySqlCommandBuilder(DA);
            DS = new DataSet();
            DA.Fill(DS, "Customers");
            navigate(currentIndex);

        }
        private void navigate(int index)
        {
            if (DS.Tables[0].Rows.Count > 0)
            {
                txtcustomerId.Text = DS.Tables[0].Rows[index][0].ToString();
                txtcontactname.Text = DS.Tables[0].Rows[index][1].ToString();
                txtcity.Text = DS.Tables[0].Rows[index][2].ToString();

            }
        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            currentIndex=DS.Tables[0].Rows.Count-1;
            navigate(currentIndex);
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < DS.Tables[0].Rows.Count - 1)
            {
                currentIndex++;
                navigate(currentIndex);
            }
        }

        private void btnMovePreveious_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                navigate(currentIndex);
            }
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            navigate(currentIndex);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtcustomerId.Text=string.Empty;
            txtcontactname.Text = string.Empty;
            txtcity.Text = string.Empty;
            txtcustomerId.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow row = DS.Tables[0].NewRow();
            row["customerId"]=txtcustomerId.Text;
            row["contactName"]=txtcontactname.Text;
            row["City"]=txtcity.Text;
            DS.Tables[0].Rows.Add(row);  
            DA.Update(DS.Tables[0]);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
         }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DS.Tables[0].Rows[currentIndex].Delete();
            DA.Update(DS.Tables[0]);
        }
    }
}
