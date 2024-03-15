﻿namespace BuiPhuKhuyen_397_Tuan2.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();

        Product GetById(int id);

        void Add(Product product);

        void Update(Product product);

        void Delete(int id);
    }
}
