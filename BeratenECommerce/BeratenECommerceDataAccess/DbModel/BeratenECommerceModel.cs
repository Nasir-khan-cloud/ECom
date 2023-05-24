using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq.Expressions;

namespace BeratenECommerceDataAccess.DbModel
{
    public class BeratenECommerceModel: DbContext
    {
        public BeratenECommerceModel(DbContextOptions<BeratenECommerceModel> options) : base(options)
        {
        }
    }
}
