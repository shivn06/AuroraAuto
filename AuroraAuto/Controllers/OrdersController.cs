using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AuroraAuto.Areas.Identity.Data;
using AuroraAuto.Models;

namespace AuroraAuto.Controllers
{
    public class OrdersController : Controller
    {
        private readonly AuroraAutoContext _context;

        public OrdersController(AuroraAutoContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            var auroraAutoContext = _context.Order.Include(o => o.Cart).Include(o => o.Customer).Include(o => o.Payment);
            return View(await auroraAutoContext.ToListAsync());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .Include(o => o.Cart)
                .Include(o => o.Customer)
                .Include(o => o.Payment)
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            ViewData["CartID"] = new SelectList(_context.Cart, "CartID", "CartID");
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerID", "Address");
            ViewData["PaymentID"] = new SelectList(_context.Set<Payment>(), "PaymentID", "PaymentID");
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderID,CustomerID,CartID,PaymentID")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CartID"] = new SelectList(_context.Cart, "CartID", "CartID", order.CartID);
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerID", "Address", order.CustomerID);
            ViewData["PaymentID"] = new SelectList(_context.Set<Payment>(), "PaymentID", "PaymentID", order.PaymentID);
            return View(order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["CartID"] = new SelectList(_context.Cart, "CartID", "CartID", order.CartID);
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerID", "Address", order.CustomerID);
            ViewData["PaymentID"] = new SelectList(_context.Set<Payment>(), "PaymentID", "PaymentID", order.PaymentID);
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,CustomerID,CartID,PaymentID")] Order order)
        {
            if (id != order.OrderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrderID))
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
            ViewData["CartID"] = new SelectList(_context.Cart, "CartID", "CartID", order.CartID);
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerID", "Address", order.CustomerID);
            ViewData["PaymentID"] = new SelectList(_context.Set<Payment>(), "PaymentID", "PaymentID", order.PaymentID);
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .Include(o => o.Cart)
                .Include(o => o.Customer)
                .Include(o => o.Payment)
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Order.FindAsync(id);
            if (order != null)
            {
                _context.Order.Remove(order);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.OrderID == id);
        }
    }
}
