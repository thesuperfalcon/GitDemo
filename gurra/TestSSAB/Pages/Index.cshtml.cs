using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

            storages.Add(slot1);
            return storages;
        }
    }
}
