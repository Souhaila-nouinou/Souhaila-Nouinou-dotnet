using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Pages.Stages
{
    public class CreateModel : ProfNamePageModel 
    {
        private readonly ContosoUniversity.Data.SchoolContext _context;

        public CreateModel(ContosoUniversity.Data.SchoolContext context)
        {
            
            _context = context;
        }

        public IActionResult OnGet()
        {
            PopulateProfDropDownList(_context);
            PopulateStudentDropDownList(_context);
            return Page();
        }

        [BindProperty]
        public Stage Stage { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
        //   if (!ModelState.IsValid)
        //     {
        //         return Page();
        //     }

        //     _context.Stages.Add(Stage);
        //     await _context.SaveChangesAsync();

        //     return RedirectToPage("./Index");

//-----------------


            var emptyStage = new Stage();

            if (await TryUpdateModelAsync<Stage>(
                 emptyStage,
                 "stage",   // Prefix for form value.
                 s => s.StageID, s => s.EnseignantID, s=> s.Binome , s=>s.Encadrant  ,s => s.sujet))
            {
                _context.Stages.Add(emptyStage);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            // Select DepartmentID if TryUpdateModelAsync fails.
            PopulateProfDropDownList(_context, emptyStage.EnseignantID);
            PopulateProfDropDownList(_context, emptyStage.Binome);
            return Page();
//-----------------------




        }


    }
}
