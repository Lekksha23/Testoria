using Microsoft.EntityFrameworkCore;
using Testoria.Data.Entities;

namespace Testoria.Data
{
    internal static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    Id = 1,
                    Number = 23,
                    Text = "Тоха чорт",
                    Difficulty = 666,
                    TestId = 1
                });
        }
    }
}