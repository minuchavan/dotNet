using ConnectedArchitecture.Dal;
using ConnectedArchitecture.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectedArchitecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CustomerDal customerDal=new CustomerDal();
        List<Model.Customer> customersCollection;
        int currentRowNo =0;

        private void Navigate(int index)
        {
            if(customersCollection.Count>0)
            {
                txtcustomerId.Text= customersCollection[index].customerId.ToString();
                txtcontactname.Text = customersCollection[index].contactName.ToString();
                txtcity.Text= customersCollection[index].city.ToString();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            customersCollection=customerDal.GetAllCustomers();
            Navigate(currentRowNo);
                
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            currentRowNo = 0;
            Navigate(currentRowNo);
        }

        private void btnMovePreveious_Click(object sender, EventArgs e)
        {
            if(currentRowNo>0)
            {
                currentRowNo--;
                Navigate(currentRowNo);
            }
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            if(currentRowNo<customersCollection.Count-1)
            {
                currentRowNo++;
                Navigate(currentRowNo);
            }

        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
             currentRowNo=customersCollection.Count-1;
            Navigate(currentRowNo);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtcustomerId.Text=string.Empty;
            txtcontactname.Text=string.Empty;
            txtcity.Text=string.Empty;
            txtcustomerId.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                customerId=int.Parse(txtcustomerId.Text),
                contactName=txtcontactname.Text,
                city=txtcity.Text
            };
            customerDal.InsertCustomer(customer);
            Form1_Load(sender, e);
            btnNew_Click(sender, e);
            MessageBox.Show("Record Saved Successfully");
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                customerId = int.Parse(txtcustomerId.Text),
                contactName=txtcontactname.Text,
                city=txtcity.Text
            };
            customerDal.UpdateCustomer(customer);
            Form1_Load(sender, e);
            btnNew_Click(sender, e);
            MessageBox.Show("Record Updated Successfully...");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            customerDal.DeleteCustomer(int.Parse(txtcustomerId.Text));
            Form1_Load(sender, e);
            btnNew_Click(sender, e);
            MessageBox.Show("Record Delete Successfully...");

        }
    }
}
