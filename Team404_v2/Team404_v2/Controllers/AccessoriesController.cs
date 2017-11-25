using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Team404_v2.Models;

namespace Team404_v2.Controllers
{
    public class AccessoriesController : Controller
    {
        // GET: Accessories
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Adapter()
        {
			//AdaptersVM model = new AdaptersVM();
			//AAdapters Item1 = new AAdapters();
			//Item1.ItemTitle = "Item 1 Title Goes Here";
			//Item1.ItemLink = "View Item Detials";
			//Item1.MiniDescription.Add("UPC:xxxxxxxxx");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//model.AdaptersItems.Add(Item1);

			var model = new AdaptersVM();
			var ctx = new MyModel();
			foreach (var item in ctx.AAdapters)
			{
				model.AAdapters.Add(item);
			}

			return View(model);
        }

        public ActionResult Chargers()
        {
			//ChargersVM model = new ChargersVM();
			//AChargers Item1 = new AChargers();
			//Item1.ItemTitle = "Item 1 Title Goes Here";
			//Item1.ItemLink = "View Item Detials";
			//Item1.MiniDescription.Add("UPC:xxxxxxxxx");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//model.AChargers.Add(Item1);

			var model = new ChargersVM();
			var ctx = new MyModel();
			foreach (var item in ctx.AChargers)
			{
				model.AChargers.Add(item);
			}

			return View(model);
		}

		public ActionResult HeadPhones()
        {
			//PhonesVM model = new PhonesVM();
			//APhones Item1 = new APhones();
			//Item1.ItemTitle = "Item 1 Title Goes Here";
			//Item1.ItemLink = "View Item Detials";
			//Item1.MiniDescription.Add("UPC:xxxxxxxxx");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//model.PhonesItems.Add(Item1);

			var model = new PhonesVM();
			var ctx = new MyModel();
			foreach (var item in ctx.APhones)
			{
				model.APhones.Add(item);
			}

			return View(model);
		}

		public ActionResult MiscCables()
        {
			//MiscCablesVM model = new MiscCablesVM();
			//AMiscCables Item1 = new AMiscCables();
			//Item1.ItemTitle = "Item 1 Title Goes Here";
			//Item1.ItemLink = "View Item Detials";
			//Item1.MiniDescription.Add("UPC:xxxxxxxxx");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//model.AMiscCables.Add(Item1);

			var model = new MiscCablesVM();
			var ctx = new MyModel();
			foreach (var item in ctx.AMiscCables)
			{
				model.AMiscCables.Add(item);
			}

			return View(model);
		}

		public ActionResult StorageDevices()
		{
		//    StorageDevicesVM model = new StorageDevicesVM();
		//    AStorageDevices Item1 = new AStorageDevices();
		//    Item1.ItemTitle = "Item 1 Title Goes Here";
		//    Item1.ItemLink = "View Item Detials";
		//    Item1.MiniDescription.Add("UPC:xxxxxxxxx");
		//    Item1.MiniDescription.Add("Bullet goes here");
		//    Item1.MiniDescription.Add("Bullet goes here");
		//    Item1.MiniDescription.Add("Bullet goes here");
		//    Item1.MiniDescription.Add("Bullet goes here");
		//    model.StorageDevicesItems.Add(Item1);

		var model = new StorageDevicesVM();
		var ctx = new MyModel();
			foreach (var item in ctx.AStorageDevices)
			{
				model.AStorageDevices.Add(item);
			}

			return View(model);
}
    }
}