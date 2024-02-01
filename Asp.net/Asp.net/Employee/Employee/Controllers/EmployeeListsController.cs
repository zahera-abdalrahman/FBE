using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Employee.Data;
using Employee.Models;
using Microsoft.AspNetCore.Identity;

namespace Employee.Controllers
{
    public class EmployeeListsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeListsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EmployeeLists
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Employee.Include(e => e.Department).Include(e => e.Manager);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: EmployeeLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Employee == null)
            {
                return NotFound();
            }

            var employeeList = await _context.Employee
                .Include(e => e.Department)
                .Include(e => e.Manager)
                .FirstOrDefaultAsync(m => m.EmployeeID == id);
            if (employeeList == null)
            {
                return NotFound();
            }

            return View(employeeList);
        }

        // GET: EmployeeLists/Create
        public IActionResult Create()
        {
            ViewData["DepartmentId"] = new SelectList(_context.Department, "DepartmentId", "DepartmentName");
            ViewData["ManagerId"] = new SelectList(_context.Manager, "ManagerId", "ManagerName");
            return View();
        }

        // POST: EmployeeLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeID,FirstName,LastName,Birthdate,PhoneNumber,NationalID,Nationality,MaritalStatus,PersonalPhoto,EntryDate,DepartmentId,ManagerId")] EmployeeList employeeList)
        {
            if (ModelState.IsValid)
            {
                // Add employee to the database
                _context.Add(employeeList);
                await _context.SaveChangesAsync();            

                return RedirectToAction(nameof(Index));
            }

            ViewData["DepartmentId"] = new SelectList(_context.Department, "DepartmentId", "DepartmentName", employeeList.DepartmentId);
            ViewData["ManagerId"] = new SelectList(_context.Manager, "ManagerId", "ManagerName", employeeList.ManagerId);
            return View(employeeList);
        }
        // GET: EmployeeLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Employee == null)
            {
                return NotFound();
            }

            var employeeList = await _context.Employee.FindAsync(id);
            if (employeeList == null)
            {
                return NotFound();
            }
            ViewData["DepartmentId"] = new SelectList(_context.Department, "DepartmentId", "DepartmentName", employeeList.DepartmentId);
            ViewData["ManagerId"] = new SelectList(_context.Manager, "ManagerId", "ManagerName", employeeList.ManagerId);
            return View(employeeList);
        }

        // POST: EmployeeLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeID,FirstName,LastName,Birthdate,PhoneNumber,NationalID,Nationality,MaritalStatus,PersonalPhoto,EntryDate,DepartmentId,ManagerId")] EmployeeList employeeList)
        {
            if (id != employeeList.EmployeeID)
            {
                return NotFound();
            }

            //if (ModelState.IsValid)
            //{
                try
                {
                    _context.Update(employeeList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeListExists(employeeList.EmployeeID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            //}
            //ViewData["DepartmentId"] = new SelectList(_context.Department, "DepartmentId", "DepartmentId", employeeList.DepartmentId);
            //ViewData["ManagerId"] = new SelectList(_context.Manager, "ManagerId", "ManagerId", employeeList.ManagerId);
            //return View(employeeList);
        }

        // GET: EmployeeLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Employee == null)
            {
                return NotFound();
            }

            var employeeList = await _context.Employee
                .Include(e => e.Department)
                .Include(e => e.Manager)
                .FirstOrDefaultAsync(m => m.EmployeeID == id);
            if (employeeList == null)
            {
                return NotFound();
            }

            return View(employeeList);
        }

        // POST: EmployeeLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Employee == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Employee'  is null.");
            }
            var employeeList = await _context.Employee.FindAsync(id);
            if (employeeList != null)
            {
                _context.Employee.Remove(employeeList);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeListExists(int id)
        {
          return (_context.Employee?.Any(e => e.EmployeeID == id)).GetValueOrDefault();
        }
    }
}
