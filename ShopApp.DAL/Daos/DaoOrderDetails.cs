using Microsoft.Extensions.Logging;
using ShopApp.DAL.Context;
using ShopApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Daos
{
    public class DaoOrderDetails : IDaoOrderDetails
    {
        private readonly ILogger _logger;
        private readonly ShopContext _shopContext;

        public DaoOrderDetails(ShopContext context, ILogger<DaoSuppliers> logger)
        {
            _logger = logger;
            _shopContext = context;
        }
    }
}
