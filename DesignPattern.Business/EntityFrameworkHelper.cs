using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Core.Common;

namespace DesignPattern.Business
{
    public class EntityFrameworkHelper : DbContext
    {
        private readonly string ConnectionString;
        SqlConnection connection;
        public EntityFrameworkHelper()
        {
            ConnectionString = ConnectionHelper.ConnectionString;
            this.connection = new SqlConnection(ConnectionString);
        }


    }
}
