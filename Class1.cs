using System;
using Oracle.ManagedDataAccess.Client;

class Program
{
    static void Main()
    {
        string connectionString = "User Id=your_user;Password=your_password;Data Source=your_datasource";

        using (OracleConnection conn = new OracleConnection(connectionString))
        {
            conn.Open();

            using (OracleCommand cmd = new OracleCommand("my_package.get_employee_name", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Input parameter
                cmd.Parameters.Add("p_emp_id", OracleDbType.Int32).Value = 101;

                // Output parameter
                var output = new OracleParameter("p_name", OracleDbType.Varchar2, 100);
                output.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(output);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Employee Name: " + output.Value.ToString());
            }
        }
    }
}