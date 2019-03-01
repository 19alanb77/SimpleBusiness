using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace Connections
{
    class Connection
    {
        public static IEnumerable<T> Read<T>(string procedure)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-DK6MQNKH\\SQLEXPRESS;Initial Catalog=projekt_baza;User ID=sa;Password=kajak"))
            {
                var value = connection.Query<T>(procedure, commandType: CommandType.StoredProcedure);

                return value;
            }
        }

        public static IEnumerable<T> ReadById<T>(string procedure, object args)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-DK6MQNKH\\SQLEXPRESS;Initial Catalog=projekt_baza;User ID=sa;Password=kajak"))
            {
                 var value = connection.Query<T>(procedure, args, commandType: CommandType.StoredProcedure);

                return value;
            }
        }

        public static T Insert<T>(string procedure, object args)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-DK6MQNKH\\SQLEXPRESS;Initial Catalog=projekt_baza;User ID=sa;Password=kajak"))
            {
                var value = connection.ExecuteScalar<T>(procedure, args, commandType: CommandType.StoredProcedure);

                return value;
            }
        }
        
        public static T Update<T>(string procedure, object args)
        {   
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-DK6MQNKH\\SQLEXPRESS;Initial Catalog=projekt_baza;User ID=sa;Password=kajak"))
            {
                try { 
                var value = connection.ExecuteScalar<T>(procedure, args, commandType: CommandType.StoredProcedure);

                return value;
                }catch (SqlException e) when (e.Number == 266) {  Console.WriteLine("Wyrzucono wyjatek SQLException!"); return default(T); }
            }
        }
    
        public static T Remove<T>(string procedure, object args)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-DK6MQNKH\\SQLEXPRESS;Initial Catalog=projekt_baza;User ID=sa;Password=kajak"))
            {
                var value = connection.ExecuteScalar<T>(procedure, args, commandType: CommandType.StoredProcedure);

                return value;
            }
        }

        public static IEnumerable<T> ReadView<T>(string select)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-DK6MQNKH\\SQLEXPRESS;Initial Catalog=projekt_baza;User ID=sa;Password=kajak"))
            {
                var value = connection.Query<T>(select);

                return value;
            }
        }

        public static IEnumerable<T> Function<T>(string function, object args)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-DK6MQNKH\\SQLEXPRESS;Initial Catalog=projekt_baza;User ID=sa;Password=kajak"))
            {
                    var value = connection.Query<T>(function, args, commandType: CommandType.Text);
                    return value;

            }
        }
    }
}
