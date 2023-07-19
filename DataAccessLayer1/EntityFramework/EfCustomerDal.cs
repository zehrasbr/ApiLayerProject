using Casgem.DataAccessLayer.Repositories;
using DataAccessLayer1.Abstract;
using DataAccessLayer1.Concrete;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer1.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>,ICustomerDal
    {
        public EfCustomerDal(Context context) : base(context)
        {
        }
    }
}
