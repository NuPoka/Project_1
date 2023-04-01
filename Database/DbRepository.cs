using Project_1.Settings;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1.Database
{
    public class DbRepository
    {
        private readonly string conectionString;

        public DbRepository(ApplicationSettings settings)
        {
            this.conectionString = settings.ConnectionString;

        }
        public bool GetUser(string userName, string password)
        {
            using var cn = new SqlConnection(conectionString);
            using var command = new SqlCommand("select * from LoginTable where Username=@userName and Password=@password", cn);

            command.Parameters.AddWithValue(nameof(userName), userName);
            command.Parameters.AddWithValue(nameof(password), password);

            cn.Open();
            using var dr = command.ExecuteReader();
            return dr.Read();
        }

    }
}
