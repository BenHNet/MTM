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
        public Pet PetInput { get; set; }

        public PetsModel(IConfiguration config)
        {
            _repo = new PetRepo(config.GetConnectionString("DefaultConnection"));
        }

        public void OnGet()
        {
            MyPets = _repo.GetAll().ToList();
        }

        public IActionResult OnPostCreateOrUpdate()
        {
            if (!ModelState.IsValid)
            {
                MyPets = _repo.GetAll().ToList();
                return Page();
            }

            if (PetInput.Id == Guid.Empty)
                _repo.Create(PetInput);
            else
                _repo.Update(PetInput);

            return RedirectToPage("/Pets");
        }

        public IActionResult OnPostDelete()
        {
            if (!ModelState.IsValid)
            {
                MyPets = _repo.GetAll().ToList();
                return Page();
            }

            _repo.Delete(PetInput.Id);

            return RedirectToPage("/Pets");
        }
    }
}