using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    public class ExpenseContext:DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options):base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Expense> Expenses { get; set; }
    }
}
