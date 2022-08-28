using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess.Models
{
    public partial class SalesManagementContext : DbContext
    {
        public SalesManagementContext(string connectionString)
        {
            this.Database.SetConnectionString(connectionString);
        }
    }

}
