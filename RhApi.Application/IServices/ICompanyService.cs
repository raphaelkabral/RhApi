using RhApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhApi.Application.IServices
{
    public interface ICompanyService
    {
        Task<Company> Add(Company company);
        Task<Company> Update(int id, Company company);
        Task<bool> Remove(int id);
        Task<Company> GetById(int id);
        Task<IEnumerable<Company>> GetUsers();
    }
}
