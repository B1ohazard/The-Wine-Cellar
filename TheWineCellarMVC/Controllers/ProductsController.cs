using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TheWineCellarMVC.Models;
using TheWineCellarMVC.ViewModels;

namespace TheWineCellarMVC.Controllers
{
    public class ProductsController : Controller
    {
        // Private readonly variables for access to the database context, the product interface and the userManager
        private readonly AppDBContext _context;
        private readonly IProductRepository productRepository;
        private readonly UserManager<IdentityUser> _userManager; // Allows you to manage and access accounts

        public ProductsController(AppDBContext context, IProductRepository productRepository, UserManager<IdentityUser> userManager)
        {
            _context = context;
            this.productRepository = productRepository;
            _userManager = userManager;
        }

        // The list of product overview is only viewable by the Employee and the Administrator
        [Authorize(Roles = "Employee, Administrator")]
        public IActionResult List(string SearchProductTypeString, string SearchEmailString)
        {
            var productEmployeeListViewModel = new ProductSearchListViewModel();
            productEmployeeListViewModel.Products = productRepository.GetAllProducts;

            var productEmpLoyeeListViewModelType = new ProductSearchListViewModel();
            productEmpLoyeeListViewModelType.Products = productRepository.GetAllProducts.Where(s => s.Category == SearchProductTypeString);

            var productEmpLoyeeListViewModelEmail = new ProductSearchListViewModel();
            productEmpLoyeeListViewModelEmail.Products = productRepository.GetAllProducts.Where(s => s.FarmerEmail == SearchEmailString);

            if ((SearchProductTypeString == null) && (SearchEmailString == null))
            {
                return View(productEmployeeListViewModel);
            }
            else if ((SearchProductTypeString != null) && (SearchEmailString == null))
            {
                return View(productEmpLoyeeListViewModelType);
            }
            else
            if ((SearchProductTypeString == null) && (SearchEmailString != null))
            {
                return View(productEmpLoyeeListViewModelEmail);
            }
            else
            {
                return View(productEmployeeListViewModel);
            }
        }

        // Only Farmers and the Administrator are able to add new products
        [Authorize(Roles = "Farmer, Administrator")]
        // GET: Products
        public async Task<IActionResult> Index()
        {
           var usersId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            return View(await _context.Products.Where(f => f.FarmerId == usersId).ToListAsync()); 
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,ProductName,ProductDescription,ProductPrice,ProductQuantity,ProductImage,Date,Category,FarmerEmail,FarmerId")] Product product)
        {
            if (ModelState.IsValid)
            {
                product.FarmerEmail = _userManager.GetUserName(User);
                product.FarmerId = _userManager.GetUserId(User);
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,ProductName,ProductDescription,ProductPrice,ProductQuantity,ProductImage,Date,Category,FarmerEmail,FarmerId")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}
