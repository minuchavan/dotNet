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

namespace AssignmentDisconnectedArchitecture
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
        MySqlCommandBuilder CMD_BLD;
        DataSet DS;
        int currentIndex = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            CN = new MySqlConnection("Data Source=192.168.100.80; PORT=3306; Database=group011;User Id=group011; Password=welcome;");
            DA = new MySqlDataAdapter("Select * from Employees", CN);
            CMD_BLD = new MySqlCommandBuilder(DA);
            DS = new DataSet();
            DA.Fill(DS, "Employee");
            navigate(currentIndex);

        }
        private void navigate(int index)
        {
            if (DS.Tables[0].Rows.Count > 0)
            {
                txtemployeeid.Text = DS.Tables[0].Rows[index][0].ToString();
                txtemployeename.Text = DS.Tables[0].Rows[index][1].ToString();
                txtcity.Text = DS.Tables[0].Rows[index][2].ToString();

            }
        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            currentIndex = DS.Tables[0].Rows.Count - 1;
            navigate(currentIndex);
        }

        private void btnMovenext_Click(object sender, EventArgs e)
        {
            if (currentIndex < DS.Tables[0].Rows.Count - 1)
            {
                currentIndex++;
                navigate(currentIndex);
            }
        }

        private void btnMovePrevious_Click(object sender, EventArgs e)
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
            txtemployeeid.Text = string.Empty;
            txtemployeename.Text = string.Empty;
            txtcity.Text = string.Empty;
            txtemployeeid.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow row = DS.Tables[0].NewRow();
            row["employeeId"] = txtemployeeid.Text;
            row["employeeName"] = txtemployeename.Text;
            row["City"] = txtcity.Text;
            DS.Tables[0].Rows.Add(row);
            DA.Update(DS.Tables[0]);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DS.Tables[0].Rows[currentIndex].Delete();
            DA.Update(DS.Tables[0]);
        }
    }
}
