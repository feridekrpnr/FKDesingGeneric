using FKDesignEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignBusiness.Abstract
{
    public interface IFaqServices
    {
        Task<IEnumerable<Faq>> GetAllFaqs(); //tüm soruları getir
        Task<Faq> GetFaqById(int id); //idsi ? olan soruyu getir
        Task<Faq> CreateFaq(Faq faq); //entity
        Task UpdateFaq(Faq faqToBeUpdate, Faq faq);
        Task DeleteFaq(Faq faq);
    }
}
