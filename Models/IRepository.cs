using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Models
{
    public interface IRepository
    {
        List<Product> GetList();

        Product GetProductById(int id);
    }
}
