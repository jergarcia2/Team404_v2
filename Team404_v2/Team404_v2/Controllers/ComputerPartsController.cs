using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Team404_v2.Models;

namespace Team404_v2.Controllers
{
    public class ComputerPartsController : Controller
    {
        // GET: ComputerParts
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cases()
        {

			var model = new CasesVM();
			var ctx = new MyModel();
			foreach (var item in ctx.CPCases)
			{
				model.CPCases.Add(item);

			}
				
				
				
				//CasesVM model = new CasesVM();
            //CPCases ctxz= new CPCases();
		
			//Item1.ItemTitle = "DIYPC Skyline-06-WG Black/Green Dual USB 3.0 ATX Full Tower Gaming Computer Case";
			//Item1.ItemLink = "View Item Details";
			//Item1.Price1Name = "Newegg";
			//Item1.Price2Name = "Amazon";
			//Item1.ItemPrice = 87.99;
			//Item1.ItemPrice2 = 107.01;
			//Item1.MiniDescription.Add("Steel ATX Full Tower");
			//Item1.MiniDescription.Add("Hot Swap Docking");
			//Item1.MiniDescription.Add("Built in Green LED Fans: 5mm x 120mm");
			//Item1.LongDescription.Add("Full black interior, Intel TAC 2.0");
			//Item1.LongDescription.Add("Advanced cable management design ");
			//Item1.LongDescription.Add("Advanced Bottom-Mounted PSU Design ");
			//Item1.LongDescription.Add("Top mounted IO ports - 2x USB 3.0 for up-to-date high speed data transfer ");
			//Item1.LongDescription.Add("Top-mounted HDD hot swap docking station provides superb file transfer  ");
			//Item1.LongDescription.Add("Screw-less design for 5.25 Devices & 3.5 HDDs");
			//Item1.LongDescription.Add("Front panel dust-proof mesh design; dust filter on top/bottom panel");
			//Item1.LongDescription.Add("8 PCI slots provide flexibility for multiple graphics cards solutions.");
			//Item1.Wishlist = "Add to Wishlist";
			//Item1.RemoveDetails = "Hide Details";


			//model.CasesItems.Add(Item1);

            return View(model);
        }

        public ActionResult CoolingSystems()
        {
			//CoolingSystemsVM model = new CoolingSystemsVM();
			//CPCoolingSystems Item1 = new CPCoolingSystems();
			//Item1.ItemTitle = "Item 1 Title Goes Here";
			//Item1.ItemLink = "View Item Details";
			//Item1.MiniDescription.Add("UPC:xxxxxxxxx");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//model.PCCoolingSystems.Add(Item1);

			//return View(model);
			var model = new CoolingSystemsVM();
			var ctx = new MyModel();
			foreach (var item in ctx.CPCoolingSystems)
			{
				model.PCCoolingSystems.Add(item);
			}

			return View(model);
		
	}


        public ActionResult Memory()
        {
			var model = new MemoryVM();
			var ctx = new MyModel();
			foreach (var item in ctx.CPMemory)
			{
				model.CPMemory.Add(item);

			}
			//MemoryVM model = new MemoryVM();
			//CPMemory Item1 = new CPMemory();
			//Item1.ItemTitle = "Item 1 Title Goes Here";
			//Item1.ItemLink = "View Item Details";
			//Item1.MiniDescription.Add("UPC:xxxxxxxxx");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//model.MemoryItems.Add(Item1);

			return View(model);
        }

        public ActionResult Motherboards()
        {
			//MotherboardVM model = new MotherboardVM();
			//CPMotherboard Item1 = new CPMotherboard();
			//Item1.ItemTitle = "Item 1 Title Goes Here";
			//Item1.ItemLink = "View Item Details";
			//Item1.MiniDescription.Add("UPC:xxxxxxxxx");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//model.CPMotherboard.Add(Item1);

			var model = new MotherboardVM();
			var ctx = new MyModel();
			foreach (var item in ctx.CPMotherboard)
			{
				model.CPMotherboard.Add(item);
			}

			return View(model);
		}

		public ActionResult PowerSupply()
        {
			var model = new PowerSupplyVM();
			var ctx = new MyModel();
			foreach (var item in ctx.CPPowerSupply)
			{
				model.CPPowerSupply.Add(item);
			}

			return View(model);
		
	}

        public ActionResult Processors()
        {
			var model = new ProcessorsVM();
			var ctx = new MyModel();
			foreach (var item in ctx.CPProcessors)
			{
				model.CPProcessors.Add(item);
			}

			return View(model);
		}

		public ActionResult SoundCards()
        {
			var model = new SoundCardsVM();
			var ctx = new MyModel();
			foreach (var item in ctx.CPSoundCards)
			{
				model.CPSoundCards.Add(item);
			}

			return View(model);
		
	}

        public ActionResult VideoCards()
        {
			var model = new VideoCardsVM();
			var ctx = new MyModel();
			foreach (var item in ctx.CPVideoCards)
			{
				model.CPVideoCards.Add(item);
			}

			return View(model);
		}
	}
}