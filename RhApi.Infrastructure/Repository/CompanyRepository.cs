using Microsoft.EntityFrameworkCore;
using RhApi.Domain;
using RhApi.Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhApi.Infrastructure.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(DbContext context) : base(context) { }
    }
}
