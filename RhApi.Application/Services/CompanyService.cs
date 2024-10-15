using RhApi.Application.IServices;
using RhApi.Domain;
using RhApi.Domain.IRepository;

namespace RhApi.Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task<Company> Add(Company company)
        {
            await _companyRepository.AddAsync(company);
            return company;
        }

        public async Task<Company> GetById(int id)
        {
            var company = await _companyRepository.GetByIdAsync(id);
            if (company == null)
                throw new Exception("Empresa não encontrado.");
            return company;
        }

        public async Task<IEnumerable<Company>> GetUsers()
        {
            return await _companyRepository.GetAllAsync();
        }

        public async Task<bool> Remove(int id)
        {
            var company = await _companyRepository.GetByIdAsync(id);

            if (company == null)
                throw new Exception("Emnpresa não encontrado.");

            return true;
        }

        public Task<Company> Update(int id, Company company)
        {
            var companyRepository = _companyRepository.GetByIdAsync(id).Result;
            if (companyRepository == null)
                throw new Exception("Empresa não encontrado.");
            companyRepository = company;

            return Task.FromResult(company);
        }
    }
}
