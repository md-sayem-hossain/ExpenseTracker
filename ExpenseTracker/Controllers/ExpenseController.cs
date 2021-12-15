using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Models;

namespace ExpenseTracker.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ExpenseContext _context;

        public ExpenseController(ExpenseContext context)
        {
            _context = context;
        }

        // GET: Expense
        public async Task<IActionResult> Index()
        {
            try
            {
                var expenseList = from a in _context.Expenses
                                  join b in _context.Categories
                                  on a.CategoryId equals b.CategoryId
                                  into Cat
                                  from b in Cat.DefaultIfEmpty()

                                  select new Expense
                                  {
                                      ExpenseId = a.ExpenseId,
                                      ExpanceAmmount = a.ExpanceAmmount,
                                      ExpenseDate = a.ExpenseDate,
                                      CategoryId = a.CategoryId,
                                      Category = b == null ? "" : b.CategoryName
                                  };
                                  

                return View(expenseList);
            }
            catch (Exception)
            {

                return View(await _context.Expenses.ToListAsync());
            }
            
        }



       
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            LoadCat();
            if (id == 0)
            {
                return View(new Expense());
            }
            else
            {
                var expense = await _context.Expenses.FindAsync(id);
                if (expense == null)
                {
                    return NotFound();
                }
                return View(expense);
            }
           
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("ExpenseId,ExpanceAmmount,CategoryId,ExpenseDate")] Expense expense)
        {   

            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    _context.Add(expense);
                    await _context.SaveChangesAsync();
                }
                else
                {
                     try
                    {
                        _context.Update(expense);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!ExpenseExists(expense.ExpenseId))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                  
                        }
                    }
                }
                return Json(new { isValid = true, html= Helper.RenderRazorViewToString(this, "_ViewAll", _context.Expenses.ToList())});
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", expense) }); ;
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var expense = await _context.Expenses.FindAsync(id);
            _context.Expenses.Remove(expense);
            await _context.SaveChangesAsync();
            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.Expenses.ToList()) });
        }

        private void LoadCat()
        {
            try
            {
                List<Category> categories = new List<Category>();
                categories = _context.Categories.ToList();
                categories.Insert(0, new Category { CategoryId = 0, CategoryName = "Please Select a category" });
                ViewBag.catList = categories;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private bool ExpenseExists(int id)
        {
            return _context.Expenses.Any(e => e.ExpenseId == id);
        }




    }
}
