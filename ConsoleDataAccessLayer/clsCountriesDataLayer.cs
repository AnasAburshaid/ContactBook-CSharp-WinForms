using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace ConsoleDataAccessLayer
{
    public class clsCountriesDataLayer
    {
        public static bool GetCountryInfoByID(ref int countryid, ref string countryname, ref string code,ref string phonecode)
        {

            bool Isfound = false;
            SqlConnection con = new SqlConnection(clsDbSettings.connectionString);
            string query = "Select * from countries where countryid = @countryid";
            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@countryid", countryid);

            try
            {
                con.Open();
                SqlDataReader r = command.ExecuteReader();

                if (r.Read())
                {
                    Isfound = true;
                    countryid = (int)r["countryid"];
                    countryname = (string)r["countryname"];

                    if ((string)r["code"] != null)
                        code = (string)r["code"];
                    else
                        code = "";

                    if ((string)r["phonecode"] != null)
                        phonecode = (string)r["phonecode"];
                    else
                        phonecode = "";

                }
                r.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return Isfound;
        }

        public static bool GetCountryInfoByName(ref int countryid, ref string countryname, ref string code, ref string phonecode)
        {

            bool Isfound = false;
            SqlConnection con = new SqlConnection(clsDbSettings.connectionString);
            string query = "Select * from countries where countryname = @countryname";
            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@countryname", countryname);

            try
            {
                con.Open();
                SqlDataReader r = command.ExecuteReader();

                if (r.Read())
                {
                    Isfound = true;
                    countryid = (int)r["countryid"];
                    countryname = (string)r["countryname"];

                    if ((string)r["code"] != null)
                        code = (string)r["code"];
                    else
                        code = "";

                    if ((string)r["phonecode"] != null)
                        phonecode = (string)r["phonecode"];
                    else
                        phonecode = "";
                }
                r.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return Isfound;
        }

        public static bool IsCountryExist(int countryid)
        {
            bool Isfound = false;
            SqlConnection con = new SqlConnection(clsDbSettings.connectionString);
            string query = "Select 1 from countries where countryid = @countryid";
            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@countryid", countryid);

            try
            {
                con.Open();
                SqlDataReader r = command.ExecuteReader();

                Isfound = r.HasRows;
                r.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return Isfound;
        }

        public static bool IsCountryExist(string countryname)
        {
            bool Isfound = false;
            SqlConnection con = new SqlConnection(clsDbSettings.connectionString);
            string query = "Select 1 from countries where countryname = @countryname";
            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@countryname", countryname);

            try
            {
                con.Open();
                SqlDataReader r = command.ExecuteReader();

                Isfound = r.HasRows;
                r.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return Isfound;
        }


        public static int AddNewCountry(string countryname , string code , string phonecode)
        {
            int countryid = -1;
            SqlConnection con = new SqlConnection(clsDbSettings.connectionString);
            string query = @"Insert into countries (countryname,code,phonecode)" +
                            "values (@countryname , @code , @phonecode);" +
                            " select SCOPE_IDENTITY();";
            
            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@countryname", countryname);
            if(code != null) 
                command.Parameters.AddWithValue("@code", code);
            else
                command.Parameters.AddWithValue("@code", DBNull.Value);

            if(phonecode != null)
                 command.Parameters.AddWithValue("@phonecode", phonecode);
            else
                command.Parameters.AddWithValue("@phonecode", DBNull.Value);

            try
            {
                con.Open();
                object Result = command.ExecuteScalar();
                if(Result != null && int.TryParse(Result.ToString(),out int id))
                {
                    countryid = id;
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return countryid;
        }
        public static bool DeleteCountry(int countryid)
        {
            int RowsAffected = 0;
            SqlConnection con = new SqlConnection(clsDbSettings.connectionString);
            string query = @"Delete countries " +
                            "WHERE countryid = @countryid;";

            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@countryid", countryid);

            try
            {
                con.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return (RowsAffected > 0);
        }

        public static bool UpdateContact(int countryid,string countryname,string code,string phonecode)
        {
            int RowsAffected = 0;
            SqlConnection con = new SqlConnection(clsDbSettings.connectionString);
            string query = @"Update countries
                            SET countryname = @countryname ,
                                code = @code,
                                phonecode = @phonecode
                            Where countryid = @countryid ;";

            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@countryid", countryid);
            command.Parameters.AddWithValue("@countryname", countryname);
            if (code != null)
                command.Parameters.AddWithValue("@code", code);
            else
                command.Parameters.AddWithValue("@code", DBNull.Value);

            if (phonecode != null)
                command.Parameters.AddWithValue("@phonecode", phonecode);
            else
                command.Parameters.AddWithValue("@phonecode", DBNull.Value);


            try
            {
                con.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return (RowsAffected > 0);
        }

        public static DataTable GetAllCountries()
        {
            SqlConnection con = new SqlConnection(clsDbSettings.connectionString);
            string query = "Select * from countries ";
            SqlCommand command = new SqlCommand(query, con);

            DataTable dt = new DataTable();

            try
            {
                con.Open();
                SqlDataReader r = command.ExecuteReader();
                if(r.HasRows)
                    dt.Load(r);

                r.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return dt;
        }
    }

    

}

