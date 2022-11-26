using ECommerce.Data.Base;
using ECommerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.Data.Services
{
    public class CategoryServices : EntityBaseRepository<Category>,ICategoryServices
    {
       
        public CategoryServices(EcommerceDbContext context):base(context)
        {
            
        }
        
    }
}
