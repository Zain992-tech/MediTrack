using System;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace Patient_Record_Management_System
{
    public static class DatabaseInitializer
    {
        private const string DatabaseName = "Patient Record Management System";

        private const string ServerConnectionString =
            @"Server=(localdb)\MSSQLLocalDB;Integrated Security=True;";

        public static void Initialize()
        {
            string scriptPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Database",
                "CreateDatabase.sql"
            );

            if (!File.Exists(scriptPath))
            {
                throw new FileNotFoundException(
                    "Database creation script was not found.",
                    scriptPath
                );
            }

            using (SqlConnection connection =
                   new SqlConnection(ServerConnectionString))
            {
                connection.Open();

                // Check whether the database already exists.
                using (SqlCommand command = new SqlCommand(
                    "SELECT DB_ID(@DatabaseName)",
                    connection))
                {
                    command.Parameters.AddWithValue(
                        "@DatabaseName",
                        DatabaseName
                    );

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        // Database already exists.
                        return;
                    }
                }

                // Database doesn't exist, so create it.
                string script = File.ReadAllText(scriptPath);

                string[] batches = Regex.Split(
                    script,
                    @"^\s*GO\s*(?:--.*)?$",
                    RegexOptions.Multiline |
                    RegexOptions.IgnoreCase
                );

                foreach (string batch in batches)
                {
                    if (string.IsNullOrWhiteSpace(batch))
                        continue;

                    using (SqlCommand command =
                           new SqlCommand(batch, connection))
                    {
                        command.CommandTimeout = 120;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}