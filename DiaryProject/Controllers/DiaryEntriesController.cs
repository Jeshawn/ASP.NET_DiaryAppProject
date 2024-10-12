using DiaryProject.Data;
using DiaryProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryProject.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _dbcontext;

        public DiaryEntriesController(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IActionResult Index()
        {
            List<DiaryEntries> diaryEntries = _dbcontext.DiaryEntries.ToList();

            return View(diaryEntries);
        }

        public IActionResult AddNewDiaryEntry()
        {
            //Creates a new Diary Entry object in a table

            return View();
        }
    }
}
