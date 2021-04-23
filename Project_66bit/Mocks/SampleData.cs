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
                var assigments = context.Types.FirstOrDefault(f => f.Name == "Командировки");
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
                        Name = "Билеты",
                        Type = assigments
                    },
                    new Category
                    {
                        Name = "Такси",
                        Type = assigments
                    },
                    new Category
                    {
                        Name = "Проживание",
                        Type = assigments
                    },
                    new Category
                    {
                        Name = "Питание",
                        Type = assigments
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

        public static void Initialize(ExpenseContext context, CategoryContext categories)
        {
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        Name = "Дмитрий",
                        Surname = "Рогожников",
                        Middlename = "Юрьевич"
                    },
                    new User
                    {
                        Name = "Семен",
                        Surname = "Щелков",
                        Middlename = "Алексеевич"
                    },
                    new User
                    {
                        Name = "Василий",
                        Surname = "Пупкин",
                        Middlename = null
                    });
            }
            context.SaveChanges();

            if (!context.Bills.Any())
            {
                var users = context.Users;
                context.Bills.AddRange(
                    new Bill
                    {
                        TotalSum = 0,
                        User = users.FirstOrDefault(f => f.Id == 1)
                    },
                    new Bill
                    {
                        TotalSum = 0,
                        User = users.FirstOrDefault(f => f.Id == 2)
                    }, 
                    new Bill
                    {
                        TotalSum = 0,
                        User = users.FirstOrDefault(f => f.Id == 3)
                    }
                );
                
            }
            context.SaveChanges();

            if (!context.Expenses.Any())
            {
                var bills = context.Bills;
                var general = categories.Types.FirstOrDefault(f => f.Name == "Общие");
                var assigments = categories.Types.FirstOrDefault(f => f.Name == "Командировки");
                var corp = categories.Types.FirstOrDefault(f => f.Name == "Корпоратив");
                context.Expenses.AddRange(
                    new Expense
                    {
                        Bill = bills.FirstOrDefault(f => f.UserId == 1),
                        Type = general,
                        Category = categories.Categories.Where(f => f.Type == general).FirstOrDefault(f => f.Id == 1),
                        Sum = 12300,
                        Paid = 0,
                        Description = "Sample Desctiption for this",
                        Cheque = "Link to cheque 1"
                    },
                    new Expense
                    {
                        Bill = bills.FirstOrDefault(f => f.UserId == 1),
                        Type = corp,
                        Category = categories.Categories.Where(f => f.Type == corp).FirstOrDefault(f => f.Name == "Алкоголь"),
                        Sum = 1300,
                        Paid = 0,
                        Description = "Sample Desctiption for PIVO",
                        Cheque = "Link to cheque 2"
                    },
                    new Expense
                    {
                        Bill = bills.FirstOrDefault(f => f.UserId == 2),
                        Type = assigments,
                        Category = categories.Categories.Where(f => f.Type == assigments).FirstOrDefault(f => f.Id == 2),
                        Sum = 15236.31,
                        Paid = 236.31,
                        Description = "Sample Desctiption for командировки",
                        Cheque = "Link to cheque 1"
                    },
                    new Expense
                    {
                        Bill = bills.FirstOrDefault(f => f.UserId == 3),
                        Type = general,
                        Category = categories.Categories.Where(f => f.Type == general).FirstOrDefault(f => f.Id == 2),
                        Sum = 322.28,
                        Paid = 0,
                        Description = "Sample Desctiption for general",
                        Cheque = "Link to cheque 1"
                    }
                    );
            }
            context.SaveChanges();
        }
    }
}