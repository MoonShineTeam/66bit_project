using System.Collections.Generic;
using System.Dynamic;
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
                context.Types.AddRange(Types.Select(f => f.Value));
            }

            context.SaveChanges();
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category
                    {
                        Name = "Еда",
                        Type = Types["Общие"]
                    },
                    new Category
                    {
                        Name = "Техника",
                        Type = Types["Общие"]
                    },
                    new Category
                    {
                        Name = "Билеты",
                        Type = Types["Командировки"]
                    },
                    new Category
                    {
                        Name = "Такси",
                        Type = Types["Командировки"]
                    },
                    new Category
                    {
                        Name = "Проживание",
                        Type = Types["Командировки"]
                    },
                    new Category
                    {
                        Name = "Питание",
                        Type = Types["Командировки"]
                    },
                    new Category
                    {
                        Name = "Аренда",
                        Type = Types["Корпоратив"]
                    },
                    new Category
                    {
                        Name = "Еда",
                        Type = Types["Корпоратив"]
                    },
                    new Category
                    {
                        Name = "Напитки",
                        Type = Types["Корпоратив"]
                    },
                    new Category
                    {
                        Name = "Алкоголь",
                        Type = Types["Корпоратив"]
                    }
                );
            }

            context.SaveChanges();
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
                context.Expenses.AddRange(
                    new Expense
                    {
                        Bill = bills.FirstOrDefault(f => f.UserId == 1),
                        Type = Types["Общие"],
                        Category = context.Categories.FirstOrDefault(f => f.Type == Types["Общие"] && f.Name == "Еда"),
                        Sum = 12300,
                        Paid = 0,
                        Description = "Sample Desctiption for this",
                        Cheque = "Link to cheque 1"
                    },
                    new Expense
                    {
                        Bill = bills.FirstOrDefault(f => f.UserId == 1),
                        Type = Types["Корпоратив"],
                        Category = context.Categories.FirstOrDefault(f => f.Type == Types["Корпоратив"] && f.Name == "Алкоголь"),
                        Sum = 1300,
                        Paid = 0,
                        Description = "Sample Desctiption for PIVO",
                        Cheque = "Link to cheque 2"
                    },
                    new Expense
                    {
                        Bill = bills.FirstOrDefault(f => f.UserId == 2),
                        Type = Types["Командировки"],
                        Category =
                            context.Categories.FirstOrDefault(f => f.Type == Types["Командировки"] && f.Name == "Билеты"),
                        Sum = 15236.31,
                        Paid = 236.31,
                        Description = "Sample Desctiption for командировки",
                        Cheque = "Link to cheque 1"
                    },
                    new Expense
                    {
                        Bill = bills.FirstOrDefault(f => f.UserId == 3),
                        Type = Types["Общие"],
                        Category = context.Categories.FirstOrDefault(f => f.Type == Types["Общие"] && f.Name == "Техника"),
                        Sum = 322.28,
                        Paid = 0,
                        Description = "Sample Description for general",
                        Cheque = "Link to cheque 1"
                    }
                );
                context.SaveChanges();
            }
        }

        private static Dictionary<string, Type> _types;

        private static Dictionary<string, Type> Types
        {
            get
            {
                if (_types != null) return _types;
                var list = new Type[]
                {
                    new() {Name = "Общие"},
                    new() {Name = "Командировки"},
                    new() {Name = "Подарки"},
                    new() {Name = "Корпоратив"}
                };

                _types = new Dictionary<string, Type>();
                foreach (var type in list)
                {
                    _types.Add(type.Name, type);
                }

                return _types;
            }
        }
    }
}