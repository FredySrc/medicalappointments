using medical_appointments.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using medical_appointments.Models;

namespace medical_appointments.Controllers
{
    public class PatientControllers : Controller
    {
        private readonly ApplicationDbContext db;

        public PatientControllers(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> Index(String search)
        {
            if (search == null)
            {
                return View(await db.Patients.ToListAsync());
            }

            return View(await db.Patients
                .Where(p => p.PatientFullName.Contains(search))
                .ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Patient patient)
        {
            if (ModelState.IsValid)
            {
                db.Add(patient);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(patient);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await db.Patients.FirstOrDefaultAsync(patient => patient.PatientId == id);

            if (patient == null)
            {
                return NotFound();
            }

            return View(patient);

        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await db.Patients.FindAsync(id);

            if (patient == null)
            {
                return NotFound();
            }

            return View(patient);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Patient patient)
        {
            if (id != patient.PatientId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(patient);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }

            return View(patient);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await db.Patients.FirstOrDefaultAsync(d => d.PatientId == id);
            if (patient == null)
            {
                return NotFound();
            }

            return View(patient);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var patient = await db.Patients.FindAsync(id);
            db.Patients.Remove(patient);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
