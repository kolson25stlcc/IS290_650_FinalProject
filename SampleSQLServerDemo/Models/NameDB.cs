using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration; //Use this namespace to read JSON configuration files

//use the new Microsoft.Data.SqlClient package for .Net Core 3.0+ to 
//access SQL Server database. Install using Nutget Package manager
//Search for Microsoft.Data.SqlClient and check pre-releases
//Go to https://channel9.msdn.com/Shows/On-NET/Working-with-the-new-MicrosoftDataSqlClient

using SampleDemo.Models;

namespace SampleDemo.Models
{
    public static class NameDB
    {
        
        public static List<Name> GetNames()
        {
            
            string connString = GetConnectionString();

            List<Name> myList = new List<Name>();
            //String connString = @"server=(localdb)\MSSQLLocalDB;Initial Catalog=ArtistCollection;Integrated Security=True;Connect Timeout=30;";

            String sql = "select id, firstname, lastname from names order by id";

            SqlConnection db = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;

            try
            {
                using (db = new SqlConnection(connString))
                {
                    db.Open();
                    using (cmd = new SqlCommand(sql, db))
                    {
                        using (dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Name objTmp = new Name();
                                objTmp.ID = Convert.ToInt16(dr["id"].ToString());
                                objTmp.FirstName = dr["firstname"].ToString();
                                objTmp.LastName = dr["lastname"].ToString();
                                myList.Add(objTmp);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }                     

            return myList;
        }

        public static Name GetName(int id)
        {
            string connString = GetConnectionString();

            String sql = "select id, firstname, lastname from names where id = @id";

            SqlConnection db = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            Name objTemp = null;

            try
            {
                using (db = new SqlConnection(connString))
                {
                    db.Open();
                    using (cmd = new SqlCommand(sql, db))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                objTemp = new Name();
                                objTemp.ID = Convert.ToInt16(dr["id"].ToString());
                                objTemp.FirstName = dr["firstname"].ToString();
                                objTemp.LastName = dr["lastname"].ToString();                                
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return objTemp;
        }
        public static bool AddName(Name objModel)
        {
            string connString = GetConnectionString();
            String sql = "insert into names values (@id, @firstname, @lastname)";
            SqlConnection db = null;
            SqlCommand cmd = null;
            int rowsAffected = 0;

            try
            {
                using (db = new SqlConnection(connString))
                {
                    db.Open();
                    using (cmd = new SqlCommand(sql, db))
                    {
                        cmd.Parameters.AddWithValue("@id", objModel.ID);
                        cmd.Parameters.AddWithValue("@firstname", objModel.FirstName);
                        cmd.Parameters.AddWithValue("@lastname", objModel.LastName);
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                    if (rowsAffected >=1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        
        public static bool UpdateName(Name objModel)
        {
            string connString = GetConnectionString();
            String sql = string.Empty;               
            SqlConnection db = null;
            SqlCommand cmd = null;
            int rowsAffected = 0;

            try
            {
                using (db = new SqlConnection(connString))
                {
                    db.Open();
                    sql = "UPDATE Names " + Environment.NewLine +
                          "set firstname = @firstname " + Environment.NewLine + "," +
                          "    lastname =  @lastname  " + Environment.NewLine +
                          "where id = @id ";
                    using (cmd = new SqlCommand(sql, db))
                    {
                        cmd.Parameters.AddWithValue("@firstname", objModel.FirstName);
                        cmd.Parameters.AddWithValue("@lastname", objModel.LastName);
                        cmd.Parameters.AddWithValue("@id", objModel.ID);
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                    if (rowsAffected >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }       

        }

        public static bool DeleteName(int id)
        {
            string connString = GetConnectionString();
            String sql = string.Empty;
            SqlConnection db = null;
            SqlCommand cmd = null;
            int rowsAffected = 0;

            try
            {
                using (db = new SqlConnection(connString))
                {
                    db.Open();
                    sql = "Delete Names " + Environment.NewLine +                          
                          "where id = @id ";
                    using (cmd = new SqlCommand(sql, db))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                    if (rowsAffected >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }            

        }

        //Get the database connectionstring from the appsettings.json file
        private static string GetConnectionString()
        {
            string connectionString = String.Empty;

            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", false)
            .Build();

            connectionString = configuration.GetSection("connectionString").Value;            
            return connectionString;
        }

    }
}
