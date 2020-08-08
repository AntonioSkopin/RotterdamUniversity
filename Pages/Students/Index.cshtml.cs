using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace RotterdamUniversity.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly RotterdamUniversity.Data.SchoolContext _context;

        public IndexModel(RotterdamUniversity.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Students { get;set; }

        public async Task OnGetAsync()
        {
            Students = await _context.Students.ToListAsync();
        }
    }
}