using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boutique
{
     class DataComponent
    {
        static string CONNECTIONSTRING = @"Data Source=RILPT175;Initial Catalog=Franchise;User ID=sa;Password=sa123";
        private object textile;

        public List<Textile> GetAllTextiles()
        {
            var list = new List<Textile>();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                try
                {
                    var query = "SELECT * FROM Textile";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var textile = new Textile();
                        textile.did = Convert.ToInt32(reader[0]);
                        textile.dName = reader[1].ToString();
                        textile.dColor = reader[2].ToString();
                        textile.dPrice = Convert.ToDouble(reader[3]);
                        
                        list.Add(textile);
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    con.Close();
                }
                return list;
            }
        }

        public void AddTextile(Textile textile)
        {
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                var query = "INSERT INTO Textile VALUES(@id,@name,@color,@price)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", textile.did);
                cmd.Parameters.AddWithValue("@name", textile.dName);
                cmd.Parameters.AddWithValue("@color", textile.dColor);
                cmd.Parameters.AddWithValue("@price", textile.dPrice);
                
                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new Exception("Details not added!");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
        }
        public Textile FindTextile(int id)
        {
            Textile textile = new Textile();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                try
                {
                    con.Open();
                    var query = "SELECT * FROM Textile WHERE did =  " + id;
                    SqlCommand cmd = new SqlCommand(query, con);
                    var reader = cmd.ExecuteReader();
                   

                    if (reader.HasRows)
                    {
                        reader.Read();
                        textile.did = Convert.ToInt32(reader[0]);
                        textile.dName = reader[1].ToString();
                        textile.dColor = reader[2].ToString();
                        textile.dPrice = Convert.ToDouble(reader[3]);

                    }
                    else
                        throw new Exception("Dress not found!");
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    con.Close();
                }
                return textile;
            }
        }
        public void UpdateTextile(Textile textile)
        {
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                var query = $"UPDATE Textile set DPrice = { textile.dPrice }" + $" WHERE Did = {textile.did}";


                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new Exception("No Details were updated");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }
        public void DeleteTextile(int id)
        {
            Textile textile= new Textile();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                try
                {
                    con.Open();
                    var cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE FROM Textile WHERE Did = " + id;
                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows == 0)
                        throw new Exception("Cannot Delete Textile");
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
        }

     }
}

