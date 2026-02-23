using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Parcel_Delivery_System.Models;
using Parcel_Delivery_System.Data; 

namespace Parcel_Delivery_System.Controllers
{
    public class ParcelsController : Controller
    {
		private readonly ApplicationDbContext _context;

		public ParcelsController(ApplicationDbContext context)
		{
			_context = context;
		}


		public async Task<IActionResult> Index(string searchString)
		{
			var parcels = from p in _context.Parcels
						  select p;

			if (!String.IsNullOrEmpty(searchString))
			{
				parcels = parcels.Where(p => p.TrackingNumber.Contains(searchString));
			}

			return View(await parcels.ToListAsync());
		}


		public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
			var parcel = await _context.Parcels.FindAsync(id);
            if (parcel == null)
            {
                return NotFound();
            }

            return View(parcel);
        }

        
        public IActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TrackingNumber,SenderName,ReceiverName,Status")] Parcel parcel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parcel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parcel);
        }

        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
			var parcel = await _context.Parcels.FindAsync(id);
			if (parcel == null)
            {
                return NotFound();
            }
            return View(parcel);
        }

         
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TrackingNumber,SenderName,ReceiverName,Status")] Parcel parcel)
        {
            if (id != parcel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parcel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParcelExists(parcel.Id))
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
            return View(parcel);
        }

        // GET: Parcels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parcel = await _context.Parcels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parcel == null)
            {
                return NotFound();
            }

            return View(parcel);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var parcel = await _context.Parcels.FindAsync(id);
            if (parcel != null)
            {
                _context.Parcels.Remove(parcel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParcelExists(int id)
        {
            return _context.Parcels.Any(e => e.Id == id);
        }

		public IActionResult Track(string trackingNumber)
		{
			if (string.IsNullOrEmpty(trackingNumber))
				return View(null);

			var parcel = _context.Parcels
								 .FirstOrDefault(p => p.TrackingNumber == trackingNumber);

			return View(parcel); 
		}
	}
}
