using System;
using System.Data.SqlClient;

namespace HostelNET.Models
{
    public class Work_SQL
    {
        #region Variables
        private string name;
        public string Name
        {
            get
            {
                if (name == null)
                {
                    name = "null";
                }
                return name;
            }
            set
            {
                name = value;
            }
        }

        private string email;
        public string Email
        {
            get
            {
                if (email == null)
                {
                    email = "null";
                }
                return email;
            }
            set
            {
                email = value;
            }
        }

        public int Type { get; set; }

        private string description;
        public string Description
        {
            get
            {
                if (description == null)
                {
                    description = "null";
                }
                return description;
            }
            set
            {
                description = value;
            }
        }
        #endregion

        public void Work_InsertInto()
        {
            try
            {
                var connectionString = new Connection().connectionString_SQL;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlCommand = $"INSERT [dbo].[ApplicationForAccession] VALUES ({Name},{Email}, {Type}, {Description})";
                    using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
