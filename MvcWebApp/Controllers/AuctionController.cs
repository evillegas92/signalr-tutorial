using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcWebApp.Models;
using MvcWebApp.Repository;

namespace MvcWebApp.Controllers
{
    public class AuctionController : Controller
    {
        private readonly IAuctionRepo auctionRepo;

        public AuctionController(IAuctionRepo auctionRepo)
        {
            this.auctionRepo = auctionRepo;
        }

        // GET: AuctionController
        public ActionResult Index()
        {
            IEnumerable<Auction> auctions = this.auctionRepo.GetAllAuctions();
            return View(auctions);
        }

        // GET: AuctionController/Details/5
        public ActionResult Details(int id)
        {
            Auction auction = this.auctionRepo.GetAuction(id);
            if (auction == null)
                return NotFound();
            return View(auction);
        }

        // GET: AuctionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuctionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuctionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AuctionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: AuctionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
