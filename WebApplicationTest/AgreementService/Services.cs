using AgreementService.Models;
using Dao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgreementService
{
    public class Services: IServices
    {
        private readonly DBContext _agreementDBContext;

        public Services(DBContext agreementDBContext)
        {
            _agreementDBContext = agreementDBContext;            
        }

        public async Task<List<AgreementListModel>> GetAgreements()
        {
            return await _agreementDBContext.Agreements.Select(
                s => new AgreementListModel
                {
                    Id = s.Id,
                    Name = s.Name,
                    Description = s.Description,
                    Amount = s.Amount
                }).ToListAsync();
        }
    }
}
