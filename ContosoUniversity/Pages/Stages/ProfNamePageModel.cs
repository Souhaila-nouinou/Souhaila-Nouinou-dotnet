using ContosoUniversity.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ContosoUniversity.Pages.Stages
{
       public class ProfNamePageModel : PageModel
    {
        public SelectList ProfList { get; set; }

        public void PopulateProfDropDownList(SchoolContext _context,
            object selectedProf = null)
        {
            var profQuery = from d in _context.Instructors
                                   orderby d.LastName // Sort by name.
                                   select d;

            ProfList = new SelectList(profQuery.AsNoTracking(),
                        "ID", "LastName", selectedProf);
        }

                public SelectList StudentList { get; set; }

        public void PopulateStudentDropDownList(SchoolContext _context,
            object selectedStudent = null)
        {
            var studentQuery = from d in _context.Students
                                   orderby d.LastName // Sort by name.
                                   select d;

            StudentList = new SelectList(studentQuery.AsNoTracking(),
                        "ID", "LastName", selectedStudent);
        }
    }
 
}