using Microsoft.Extensions.Logging;
using ShopApp.DAL.Context;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Daos
{
    public class DaoEmployees : IDaoEmployees
    {
        private readonly ILogger _logger;
        private readonly ShopContext _shopContext;

        public DaoEmployees(ShopContext context, ILogger<DaoSuppliers> logger)
        {
            _logger = logger;
            _shopContext = context;
        }
        public void CreateEmployees(EmployeesCreateOrUpdateModel employees)
        {
            throw new NotImplementedException();
        }

        public List<GetEmployees> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public GetEmployees GetEmployeesById(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployees(EmployeesRemoveModel employees)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployees(EmployeesCreateOrUpdateModel employees)
        {
            throw new NotImplementedException();
        }
    }
}
