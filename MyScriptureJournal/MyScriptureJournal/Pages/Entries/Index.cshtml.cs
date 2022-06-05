using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Entries
{
#pragma warning disable CS8618
#pragma warning disable CS8604
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<JournalEntry> JournalEntry { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Book { get; set; }
        [BindProperty(SupportsGet = true)]
        public string BookTitle { get; set; }
        public SelectList Notes { get; set; }
        [BindProperty(SupportsGet = true)]
        public string NotesKeyword { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> bookQuery = from a in _context.JournalEntry
                                           orderby a.Book
                                           select a.Book;
            var entries = from b in _context.JournalEntry select b;
            if (!string.IsNullOrEmpty(SearchString))
            {
                entries = entries.Where(c => c.Book.Contains(SearchString));
            } 
            if (!string.IsNullOrEmpty(BookTitle))
            {
                entries = entries.Where(d => d.Book == BookTitle);
            }
            Book = new SelectList(await bookQuery.Distinct().ToListAsync());
            JournalEntry = await entries.ToListAsync();
        }
    }
#pragma warning restore CS8618
#pragma warning restore CS8604
}
