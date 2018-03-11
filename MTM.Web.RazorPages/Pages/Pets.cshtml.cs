using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using MTM.Common.Repositories;
using MTM.Models.Models;

namespace MTM.Web.RazorPages.Pages
{
    public class PetsModel : PageModel
    {
        private PetRepo _repo;

        public List<Pet> MyPets;

        [BindProperty]
        public Pet Input { get; set; }

        public PetsModel(IConfiguration config) {
            _repo = new PetRepo(config.GetConnectionString("DefaultConnection"));
        }

        public void OnGet()
        {
            MyPets = _repo.GetAll().ToList();
        }

        public async Task<IActionResult> OnCreateOrUpdateAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return Page();
        }
    }
}