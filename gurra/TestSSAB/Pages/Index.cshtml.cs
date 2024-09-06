using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using TestSSAB.Models;

namespace TestSSAB.Pages
{
    public class IndexModel : PageModel
    {

        public List<Storage> Storages { get; set; }

        public void OnGet()
        {
            Storages = new List<Storage>();

            if(Storages.Count == 0 || Storages == null)
            {
                Storages = CreateStorageData();
            }
        }

        public List<Storage> CreateStorageData()
        {
            List<Storage> storages = new List<Storage>(); 

            Models.Storage slot1 = new Storage() { StorageName = "Plats 1", 
                CurrentStock = 0, Created = DateTime.Now, MaxCapacity = 10};

            Models.Storage slot2 = new Storage()
            {
                StorageName = "Plats 2",
                CurrentStock = 0,
                Created = DateTime.Now,
                MaxCapacity = 20
            };

            Models.Storage slot3 = new Storage()
            {
                StorageName = "Plats 3",
                CurrentStock = 0,
                Created = DateTime.Now,
                MaxCapacity = 30
            };

            Models.Storage slot4 = new Storage()
            {
                StorageName = "Plats 4",
                CurrentStock = 0,
                Created = DateTime.Now,
                MaxCapacity = 30
            };

            storages.Add(slot1);
            storages.Add(slot2);
            storages.Add(slot3);

            return storages;
        }
    }
}
