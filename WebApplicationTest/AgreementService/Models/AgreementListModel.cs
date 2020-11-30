using System;
using System.Collections.Generic;
using System.Text;

namespace AgreementService.Models
{
    public class AgreementListModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
    }
}
