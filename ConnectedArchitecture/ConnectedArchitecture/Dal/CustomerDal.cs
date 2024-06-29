using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectedArchitecture.Model;
using Mysqlx.Crud;


namespace ConnectedArchitecture.Dal
{
    internal class CustomerDal
    {
        private string _constr = ConfigurationManager.ConnectionStrings["InfowayConString"].ConnectionString;
        public List<Customer> GetAllCustomers()
        {
            List<Customer> customersCollection = new List<Customer>();
            using (MySqlConnection CN = new MySqlConnection(_constr))
            {
                CN.Open();
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "GetAllCustomers";
                    MySqlDataReader DR = CMD.ExecuteReader(CommandBehavior.SequentialAccess);
                    while (DR.Read())
                    {
                        Customer customer = new Customer()
                        {
                            customerId = Convert.ToInt32(DR["customerId"]),
                            contactName = DR["customerName"].ToString(),
                            city = DR["City"].ToString()

                        };
                        customersCollection.Add(customer);
                    }
                    DR.Close();

                }
                CN.Close();

            }
            return customersCollection;
        }

        public int InsertCustomer(Customer customer)
        {
            int result = -1;
            using (MySqlConnection CN = new MySqlConnection(_constr))
            {
                CN.Open();
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "InsertCustomer";
                    CMD.Parameters.AddWithValue("p_customerName", customer.contactName);
                    CMD.Parameters.AddWithValue("p_city", customer.city);
                    CMD.Parameters.AddWithValue("p_customerId",customer.customerId);
                    result = CMD.ExecuteNonQuery();
                }
                CN.Close();
            }
            return result;
        }
        public int UpdateCustomer(Customer customer)
        {
            int result = -1;
            using (MySqlConnection CN = new MySqlConnection(_constr))
            {
                CN.Open();
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "UpdateCustomer";
                    CMD.Parameters.AddWithValue("p_customerName", customer.contactName);
                    CMD.Parameters.AddWithValue("p_city", customer.city);
                    CMD.Parameters.AddWithValue("p_customerId", customer.customerId);
                    result = CMD.ExecuteNonQuery();
                }
                CN.Clone(); 
            }
            return result;
        }

        public int DeleteCustomer(int customerId)
        {
            int result = -1;
            using(MySqlConnection CN = new MySqlConnection(_constr))
            {
                CN.Open() ;
                using(MySqlCommand CMD = new MySqlCommand())
                {
                    CMD.Connection= CN;
                    CMD.CommandType= CommandType.StoredProcedure;
                    CMD.CommandText = "DeleteCustomer";
                    CMD.Parameters.AddWithValue("p_customerId",customerId);
                    result = CMD.ExecuteNonQuery();
                }
                CN.Close();
            }
            return result;
        }


     }
}
    

