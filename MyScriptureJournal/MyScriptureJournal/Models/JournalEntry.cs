using System.ComponentModel.DataAnnotations;

namespace MyScriptureJournal.Models
{
    public class JournalEntry
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string Book { get; set; } = string.Empty;
        public int Chapter { get; set; }
        public int Verse { get; set; }
        public string Notes { get; set; } = string.Empty;

        [DataType(DataType.Date), Display(Name = "Reading Completed"), DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReadDate { get; set; }
    }
}
