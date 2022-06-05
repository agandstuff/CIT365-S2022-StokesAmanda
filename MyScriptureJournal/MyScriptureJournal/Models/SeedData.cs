using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;

namespace MyScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                if (context == null || context.JournalEntry == null)
                {
                    throw new ArgumentNullException("Null MyScriptureJournalContext");
                }

                // Look for any movies.
                if (context.JournalEntry.Any())
                {
                    return;   // DB has been seeded
                }

                context.JournalEntry.AddRange(
                    new JournalEntry
                    {
                        Book = "1 Nephi",
                        Chapter = 3,
                        Verse = 7,
                        Notes = "I will go and do",
                        ReadDate = DateTime.Parse("2022-1-26")
                    },

                    new JournalEntry
                    {
                        Book = "2 Nephi",
                        Chapter = 2,
                        Verse = 27,
                        Notes = "Free to choose",
                        ReadDate = DateTime.Parse("2022-2-5")
                    },

                    new JournalEntry
                    {
                        Book = "Helaman",
                        Chapter = 5,
                        Verse = 12,
                        Notes = "Rock of our Redeemer",
                        ReadDate = DateTime.Parse("2022-4-8")
                    },

                    new JournalEntry
                    {
                        Book = "Moroni",
                        Chapter = 7,
                        Verse = 45,
                        Notes = "Charity suffereth long.",
                        ReadDate = DateTime.Parse("2022-5-18")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
