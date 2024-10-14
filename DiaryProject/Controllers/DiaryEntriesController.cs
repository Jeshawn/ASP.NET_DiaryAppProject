using AspNetCoreGeneratedDocument;
using DiaryProject.Data;
using DiaryProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public IActionResult EditDiaryEntry(int? id) //Need to implement this view
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }

            DiaryEntries? diaryEntry = _dbcontext.DiaryEntries.Find(id);

            if (ModelState.IsValid)
            {

                if (diaryEntry == null)
                {
                    return NotFound();
                }

            }
            return View(diaryEntry);
        }
        
        [HttpPost]
        public IActionResult AddNewDiaryEntry(DiaryEntries diaryEntry)
        {
            if (diaryEntry == null || diaryEntry.Title.Length < 5)
            {
                ModelState.AddModelError("Title", "Title is too short.");
                return View();
            }

            if(ModelState.IsValid) //Checks if fields in model are all valid
            {
                _dbcontext.DiaryEntries.Add(diaryEntry);
                _dbcontext.SaveChanges();
                //Creates a new Diary Entry object in a table
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditDiaryEntry(DiaryEntries diaryEntry)
        {
            if (diaryEntry == null || diaryEntry.Title.Length < 5)
            {
                ModelState.AddModelError("Title", "Title is too short.");
                return View();
            }

            if (ModelState.IsValid) //Checks if fields in model are all valid
            {
                _dbcontext.DiaryEntries.Update(diaryEntry);
                _dbcontext.SaveChanges();
                //Creates a new Diary Entry object in a table
            }
            return RedirectToAction("Index");
        }

        public IActionResult DeleteDiaryEntry(int? id) //Need to implement this view
        {
            DiaryEntries? diaryEntry = _dbcontext.DiaryEntries.Find(id);
            if (diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult DeleteDiaryEntry(DiaryEntries? diaryEntry)
        {
            if(diaryEntry == null)
            {
                NotFound();
            }

            _dbcontext.DiaryEntries.Remove(diaryEntry);
            _dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
