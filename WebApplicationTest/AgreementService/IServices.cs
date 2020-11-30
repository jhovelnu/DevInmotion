using AgreementService.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AgreementService
{
    public interface IServices
    {
        Task<List<AgreementListModel>> GetAgreements();
    }
}
