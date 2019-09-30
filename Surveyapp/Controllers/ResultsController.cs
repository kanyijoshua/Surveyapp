using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Surveyapp.Models;

namespace Surveyapp.Controllers
{
    public class ResultsController : Controller
    {
        private readonly SurveyContext _context;

        public ResultsController(SurveyContext context)
        {
            _context = context;
        }

        // GET: Results
        public async Task<IActionResult> Index()
        {
            var surveyContext = _context.Survey.Include(s => s.Surveyer);
            return View(await surveyContext.ToListAsync());
        }

        // GET: Results/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var survey = await _context.Survey
                .Include(s => s.Surveyer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (survey == null)
            {
                return NotFound();
            }

            return View(survey);
        }
        public async Task<IActionResult> SurveyCategory(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var SurveyCategory = _context.SurveyCategory
                .Include(s=>s.Survey)
                .Where(m => m.SurveyId == id);
                //.FirstOrDefaultAsync(m => m.SurveyId == id);
            if (SurveyCategory==null)
            {
                return View("error");
            }

            return View("Details",await SurveyCategory.ToListAsync());
        }

        // GET: Results/Create
        public IActionResult Create()
        {
            ViewData["SurveyerId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Results/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,name,Startdate,EndDate,status,SurveyerId")] Survey survey)
        {
            if (ModelState.IsValid)
            {
                _context.Add(survey);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SurveyerId"] = new SelectList(_context.Users, "Id", "Id", survey.SurveyerId);
            return View(survey);
        }

        // GET: Results/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var survey = await _context.Survey.FindAsync(id);
            if (survey == null)
            {
                return NotFound();
            }
            ViewData["SurveyerId"] = new SelectList(_context.Users, "Id", "Id", survey.SurveyerId);
            return View(survey);
        }

        // POST: Results/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,name,Startdate,EndDate,status,SurveyerId")] Survey survey)
        {
            if (id != survey.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(survey);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SurveyExists(survey.Id))
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
            ViewData["SurveyerId"] = new SelectList(_context.Users, "Id", "Id", survey.SurveyerId);
            return View(survey);
        }

        // GET: Results/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var survey = await _context.Survey
                .Include(s => s.Surveyer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (survey == null)
            {
                return NotFound();
            }

            return View(survey);
        }

        // POST: Results/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var survey = await _context.Survey.FindAsync(id);
            _context.Survey.Remove(survey);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SurveyExists(int id)
        {
            return _context.Survey.Any(e => e.Id == id);
        }
    }
}
