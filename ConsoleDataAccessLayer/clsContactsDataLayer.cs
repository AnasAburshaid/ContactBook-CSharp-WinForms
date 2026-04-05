using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;
namespace ConsoleDataAccessLayer

{
    public class clsContactsDataLayer
    {
        

        public static bool GetContactInfoByID(ref int contactid, ref string firstname, ref string lastname, ref string email
            , ref string phone, ref string address, ref DateTime dateofbirth, ref int countryid, ref string imagepath)
        {
            SqlConnection con = new SqlConnection(clsDbSettings.connectionString);
            string query = "Select * from contacts where contactid = @id";
            SqlCommand command = new SqlCommand(query, con);

            bool isfound = false;
            command.Parameters.AddWithValue("@id", contactid);

            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    firstname = (string)reader["firstname"];
                    lastname = (string)reader["lastname"];
                    email = (string)reader["email"];
                    phone = (string)reader["phone"];
                    address = (string)reader["address"];
                    dateofbirth = (DateTime)reader["dateofbirth"];
                    countryid = (int)reader["countryid"];

                    if (reader["imagepath"] != DBNull.Value)
                    {
                        imagepath = (string)reader["imagepath"];
                    }
                    else
                        imagepath = "";

                    isfound = true;

                }
                else
                    isfound = false;

                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return isfound;
        }

        public static int AddNewContact(string firstname, string lastname, string email, string phone,
        string address, DateTime dateofbirth, int countryid, string imagepath)
        {
            SqlConnection con = new SqlConnection(clsDbSettings.connectionString);
            string query = @"INSERT into contacts (firstname,lastname,email,phone,address,dateofbirth,countryid,imagepath)
                           Values (@firstname,@lastname,@email,@phone,@address,@dateofbirth,@countryid,@imagepath);
                             select SCOPE_IDENTITY();";

            int contactid = -1;
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@dateofbirth", dateofbirth);
            cmd.Parameters.AddWithValue("@countryid", countryid);
            if (imagepath != "")
            {
                cmd.Parameters.AddWithValue("@imagepath", imagepath);
            }
            else
                cmd.Parameters.AddWithValue("@imagepath", DBNull.Value);

            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int Id))
                    contactid = Id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return contactid;

        }

        public static bool UpdateContact(int contactid, string firstname, string lastname, string email, string address,
        string phone, DateTime dateofbirth, int countryid, string imagepath)
        {
            int RowAffected = 0;
            SqlConnection con = new SqlConnection(clsDbSettings.connectionString);
            string query = @"UPDATE contacts  
                           SET  firstname = @firstname,
                                lastname = @lastname,
                                email = @email,
                                phone = @phone,
                                address = @address,
                                dateofbirth = @dateofbirth,
                                countryid = @countryid,
                                imagepath = @imagepath
                            WHERE
                                contactid = @contactid;
                            ";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@contactid", contactid);
            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@dateofbirth", dateofbirth);
            cmd.Parameters.AddWithValue("@countryid", countryid);
            if (imagepath != "")
            {
                cmd.Parameters.AddWithValue("@imagepath", imagepath);
            }
            else
                cmd.Parameters.AddWithValue("@imagepath", DBNull.Value);

            try
            {
                con.Open();
                RowAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { con.Close(); }

            return (RowAffected > 0);


        }

        public static bool DeleteContact(int contactid)
        {
            int RowAffected = 0;
            SqlConnection con = new SqlConnection(clsDbSettings.connectionString);
            string query = @"DELETE contacts    
                            WHERE
                            contactid = @contactid;";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@contactid", contactid);

            try
            {
                con.Open();
                RowAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { con.Close(); }

            return (RowAffected > 0);

        }

        public static DataTable GetListData()
        {
            DataTable dt = new DataTable();

            SqlConnection con = new SqlConnection(clsDbSettings.connectionString);
            string query = "Select * from contacts";

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { con.Close(); }
            return dt;
        }

        public static bool IsContactExist(int contactid)
        {
            bool isfound = false;
            SqlConnection con = new SqlConnection(clsDbSettings.connectionString);
            string query = "Select 1 from contacts where " +
                           "Contactid = @contactid;" ;

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@contactid", contactid);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                isfound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { con.Close(); }

            return isfound;
        }
    }
}
