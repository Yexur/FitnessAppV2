using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApplicationModels.FitnessAppV2.Models;
using FitnessAppV2.Data;
using FitnessAppV2.Logic;

namespace FitnessAppV2.Controllers
{
    public class FitnessClassesController : Controller
    {
        private readonly IFitnessClassLogic _fitnessClassLogic;

        public FitnessClassesController(IFitnessClassLogic fitnessClassLogic)
        {
            _fitnessClassLogic = fitnessClassLogic;    
        }

        // GET: FitnessClasses
        public async Task<IActionResult> Index()
        {
            return View(await _fitnessClassLogic.GetList());
        }

        //// GET: FitnessClasses/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var fitnessClass = await _context.FitnessClass.SingleOrDefaultAsync(m => m.Id == id);
        //    if (fitnessClass == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(fitnessClass);
        //}

        //// GET: FitnessClasses/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: FitnessClasses/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Capacity,Created,DateOfClass,EndTime,StartTime,Status,Updated")] FitnessClass fitnessClass)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(fitnessClass);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }
        //    return View(fitnessClass);
        //}

        //// GET: FitnessClasses/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var fitnessClass = await _context.FitnessClass.SingleOrDefaultAsync(m => m.Id == id);
        //    if (fitnessClass == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(fitnessClass);
        //}

        //// POST: FitnessClasses/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Capacity,Created,DateOfClass,EndTime,StartTime,Status,Updated")] FitnessClass fitnessClass)
        //{
        //    if (id != fitnessClass.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(fitnessClass);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!FitnessClassExists(fitnessClass.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction("Index");
        //    }
        //    return View(fitnessClass);
        //}

        //// GET: FitnessClasses/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var fitnessClass = await _context.FitnessClass.SingleOrDefaultAsync(m => m.Id == id);
        //    if (fitnessClass == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(fitnessClass);
        //}

        //// POST: FitnessClasses/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var fitnessClass = await _context.FitnessClass.SingleOrDefaultAsync(m => m.Id == id);
        //    _context.FitnessClass.Remove(fitnessClass);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}

        //private bool FitnessClassExists(int id)
        //{
        //    return _context.FitnessClass.Any(e => e.Id == id);
        //}
    }
}
