using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class MovieContext
    {
        public string ConnectionString { get; set; }
        public MovieContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<MovieItem> GetAllMovie()
        {
            List<MovieItem> list = new List<MovieItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM provided", conn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                using MySqlDataReader reader = mySqlDataReader;
                while (reader.Read())
                {
                    list.Add(new MovieItem()
                    {
                        id = reader.GetInt32("id"),
                        name = reader.GetString("name"),
                        genre = reader.GetString("genre"),
                        duration = reader.GetString("duration"),
                        releasedate = reader.GetDateTime("releasedate")
                    });
                }
            }
            return list;
        }

        public List<MovieItem> GetMovie(string id)
        {
            List<MovieItem> list = new List<MovieItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM provided WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            id = reader.GetInt32("id"),
                            name = reader.GetString("name"),
                            genre = reader.GetString("genre"),
                            duration = reader.GetString("duration"),
                            releasedate = reader.GetDateTime("releasedate")
                        });
                    }
                }
            }
            return list;
        }

        public List<MovieItem> PostMovie(string name, string genre, string duration, DateTime releasedate)
        {
            List<MovieItem> list = new List<MovieItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into provided(name,genre,duration,releasedate) values(@name,@genre,@duration,@releasedate);", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@genre", genre);
                cmd.Parameters.AddWithValue("@duration", duration);
                cmd.Parameters.AddWithValue("@releasedate", releasedate);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                using (MySqlDataReader reader = mySqlDataReader)
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            id = reader.GetInt32("id"),
                            name = reader.GetString("name"),
                            genre = reader.GetString("genre"),
                            duration = reader.GetString("duration"),
                            releasedate = reader.GetDateTime("releasedate")

                        });
                    }
                }
            }
            return list;
        }

        public List<MovieItem> PutMovie(string id, string name, string genre, string duration, DateTime releasedate)
        {
            List<MovieItem> list = new List<MovieItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("update provided set name=@name,genre=@genre,duration=@duration,releasedate=@releasedate where id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@genre", genre);
                cmd.Parameters.AddWithValue("@duration", duration);
                cmd.Parameters.AddWithValue("@releasedate", releasedate);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            id = reader.GetInt32("id"),
                            name = reader.GetString("name"),
                            genre = reader.GetString("genre"),
                            duration = reader.GetString("duration"),
                            releasedate = reader.GetDateTime("releasedate")
                        });
                    }
                }
            }
            return list;
        }

        public List<MovieItem> DeleteMovie(string id)
        {
            List<MovieItem> list = new List<MovieItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("delete from provided where id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            id = reader.GetInt32("id"),
                            name = reader.GetString("name"),
                            genre = reader.GetString("genre"),
                            duration = reader.GetString("duration"),
                            releasedate = reader.GetDateTime("releasedate")
                        });
                    }
                }
            }
            return list;
        }
    }
}