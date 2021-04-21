using System.Linq;
using Project_66bit.Contexts;
using Project_66bit.Models;

namespace Project_66bit.Mocks
{
    public static class SampleData
    {
        public static void Initialize(CategoryContext context)
        {
            if (!context.Types.Any())
            {
                context.Types.AddRange(
                    new Type
                    {
                        Name = "Общие"
                    },
                    new Type
                    {
                        Name = "Командировки"
                    },
                    new Type
                    {
                        Name = "Подарки"
                    },
                    new Type
                    {
                        Name = "Корпоратив"
                    });
            }

            context.SaveChanges();
            if (!context.Categories.Any())
            {
                var general = context.Types.FirstOrDefault(f => f.Name == "Общие");
                var asigments = context.Types.FirstOrDefault(f => f.Name == "Командировки");
                var corp = context.Types.FirstOrDefault(f => f.Name == "Корпоратив");
                context.Categories.AddRange(
                    new Category
                    {
                        Name = "Еда",
                        Type = general
                    },
                    new Category
                    {
                        Name = "Техника",
                        Type = general
                    },
                    new Category
                    {
                        Name = "Еда",
                        Type = general
                    },
                    new Category
                    {
                        Name = "Билеты",
                        Type = asigments
                    },
                    new Category
                    {
                        Name = "Такси",
                        Type = asigments
                    },
                    new Category
                    {
                        Name = "Проживание",
                        Type = asigments
                    },
                    new Category
                    {
                        Name = "Питание",
                        Type = asigments
                    },
                    new Category
                    {
                        Name = "Аренда",
                        Type = corp
                    },
                    new Category
                    {
                        Name = "Еда",
                        Type = corp
                    },
                    new Category
                    {
                        Name = "Напитки",
                        Type = corp
                    },
                    new Category
                    {
                        Name = "Алкоголь",
                        Type = corp
                    }
                );
            }

            context.SaveChanges();
        }
    }
}