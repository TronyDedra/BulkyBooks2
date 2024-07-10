using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class CompanyRepository(ApplicationDbContext db) : Repository<Company>(db), ICompanyRepository
    {
        public ApplicationDbContext _db = db;

        public void Update(Company company)
        {
            _db.Companies.Update(company);
            var compFromDb = _db.Companies.FirstOrDefault(u => u.Id == company.Id);
            if (company != null)
            {
                compFromDb.Id = company.Id;
                compFromDb.PhoneNumber = company.PhoneNumber;
                compFromDb.City = company.City;
                compFromDb.Region = company.Region;
                compFromDb.StreetAddress = company.StreetAddress;
                compFromDb.PostalCode = company.PostalCode;
            }
        }
    }
}
