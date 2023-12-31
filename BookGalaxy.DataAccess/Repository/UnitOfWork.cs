﻿using BookGalaxy.DataAccess.Data;
using BookGalaxy.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookGalaxy.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public ICategoryRepository Category { get; private set; }
        //public ICompanyRepository Company { get; private set; }
        public IProductRepository Product { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
           // ProductImage = new ProductImageRepository(_db);
            //ApplicationUser = new ApplicationUserRepository(_db);
            //ShoppingCart = new ShoppingCartRepository(_db);
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
           
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
