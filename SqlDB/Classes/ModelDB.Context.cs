﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlDB.Classes
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TestEntities : DbContext
    {
        private static TestEntities _context; //приватное статичное поле для контекста
        public TestEntities()
            : base("name=TestEntities")
        {
        }
    
        public static TestEntities GetContext() //метод для обработки поля
        {
            if (_context == null)
                _context = new TestEntities();
            return _context;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Person> Person { get; set; }
    }
}