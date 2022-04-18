using System;
using City;
//using City.EF;
using System.Data.SqlClient;

static void AdoNET()
{
    var connection = new SqlConnection("Server=MSI; Database=City2; Trusted_Connection=True;");
    connection.Open();

    var command = connection.CreateCommand();
    command.CommandText = "SELECT a.number, b.name, a.amount, a.year_repair FROM homes a JOIN streets b ON a.id_streetID = b.ID";

    var reader = command.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"Номер дома:{reader.GetString(0)} название:{reader.GetString(reader.GetOrdinal("name"))}");
    }
    reader.Close();
    Console.WriteLine($"Список домов, отсортированных по давности ремонта:");
    command = connection.CreateCommand();
    command.CommandText = "SELECT a.number, b.name FROM homes a JOIN streets b ON a.id_streetID = b.ID order by(a.year_repair)";

    reader = command.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"Номер дома:{reader.GetString(0)} название:{reader.GetString(reader.GetOrdinal("name"))}");
    }
    reader.Close();

    Console.WriteLine($"Список домов, отсортированных по степени необходимости в ремонте:");
    command = connection.CreateCommand();
    command.CommandText = "SELECT a.number, b.name FROM homes a JOIN streets b ON a.id_streetID = b.ID order by (select(a.amount * (2022 - a.year_repair)))desc";

    reader = command.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"Номер дома:{reader.GetString(0)} название:{reader.GetString(reader.GetOrdinal("name"))}");
    }
    reader.Close();

    Console.WriteLine($"Список домов, ремонтированных позже среднего по базе:");
    command = connection.CreateCommand();
    command.CommandText = "SELECT a.number, b.name FROM homes a, streets b where a.id_streetID = b.ID and a.year_repair < (select avg(year_repair) from homes)";

    reader = command.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"Номер дома:{reader.GetString(0)} название:{reader.GetString(reader.GetOrdinal("name"))}");
    }
    reader.Close();
    Console.WriteLine($"Список домов, ремонтированных позже среднего по базе:");
    command = connection.CreateCommand();
    command.CommandText = "SELECT a.number, b.name FROM homes a, streets b where a.id_streetID = b.ID and a.year_repair < (select avg(year_repair) from homes)";

    reader = command.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"Номер дома:{reader.GetString(0)} название:{reader.GetString(reader.GetOrdinal("name"))}");
    }
    connection.Close();
}

static void Requests()
{
    Database db = new Database();
    Console.WriteLine($"Список домов, отсортированных по давности ремонта:");
    foreach (home e in db.homes.OrderBy(e => e.year_repair))
    {
        Console.WriteLine($"{e.number} {e.id_street.name}");
    }

    Console.WriteLine($"Список домов, отсортированных по степени потребности в ремонте:");
    foreach (home e in db.homes.OrderByDescending(e => ((2022 - e.year_repair) * e.amount)))
    {
        Console.WriteLine($"{e.number} {e.id_street.name}");
    }

    Console.WriteLine($"Список домов, ремонтированных позже среднего по базе:");
    decimal sum = 0;
    decimal ave = 0;
    foreach (var e in db.homes)
    {
        ave += e.year_repair;
        sum++;
    }
    foreach (home e in db.homes.Where(e => e.year_repair < ave/sum))
    {
        Console.WriteLine($"{e.number} {e.id_street.name} {e.year_repair}");
    }

    Console.WriteLine($"Дома ремонтированные позднее 5-ти лет:");
    foreach (var g in db.homes.Where(e => e.year_repair < 2017).GroupBy(e => e.id_street.name)
            .Select(x => new { street_name = x.Key, count = x.Count() }))
    {
        Console.WriteLine($"{g.street_name} {g.count}");
    }

    Console.WriteLine($"Самый старый по ремонту дом:");
    decimal oldHome = 2030;
    foreach (home e in db.homes)
    {
        if (e.year_repair < oldHome)
        {
            oldHome = e.year_repair;
        }
    }
    foreach (home e in db.homes.Where(e => e.year_repair == oldHome))
    {
        Console.WriteLine($"{e.number} {e.id_street.name} {e.year_repair}");
    }
    Console.WriteLine($"Произвелся ремонт:");
    foreach (home e in db.homes.Where(e => e.year_repair == oldHome))
    {
        e.year_repair = 2022;
        Console.WriteLine($"{e.number} {e.id_street.name} {e.year_repair}");
    }

    Console.WriteLine($"Самый маленький по числу квартир дом удалить \n До:");
    foreach (home e in db.homes)
    {
        Console.WriteLine($"{e.number} {e.id_street.name}");
    }
    int kv = db.homes.Min(e => Convert.ToInt32(e.amount));
    foreach (home e in db.homes)
    {
        if (e.amount == kv)
        {
            db.homes.Remove(e);
            break;
        }
    }
    Console.WriteLine("После:");
    foreach (home e in db.homes)
    {
        Console.WriteLine($"{e.number} {e.id_street.name}");
    }

    Console.WriteLine($"Наименее заселенная улица:");
    int zasel = db.homes.Min(e => Convert.ToInt32(e.id_street.name.Count()) * Convert.ToInt32(e.amount));
    {
        foreach (home e in db.homes)
        {
            if (Convert.ToInt32(e.id_street.name.Count()) * Convert.ToInt32(e.amount) == zasel)
            {
                int max_id = db.homes.Count() + 1;
                db.homes.Add(new home { ID = max_id, number = "33", id_street = e.id_street, amount = 100, year_repair = 2022 });
                break;
            }

        }
    }
    Console.WriteLine("После:");
    foreach (home e in db.homes)
    {
        Console.WriteLine($"{e.number} {e.id_street.name}");
    }

}

//Requests();
AdoNET();

//static void EFDemo()
//{
//    Models db = new Models();
//    db.CreateDbIfNotExists();
//}


//static void Main(string[] args)
//{
//    //    Models db = new Models();
//    //    var streets = db.streets.ToList();
//    //    db.streets.AddRange(entities: new street[] {new street { ID = 1, name = "Вавилова" },
//    //                                                new street { ID = 2, name = "Вольская" },
//    //                                                new street { ID = 3, name = "Рабочая" },
//    //                                                new street { ID = 4, name = "Чапаева" } });
//    //    db.homes.AddRange(entities: new home[] {new home { ID = 1, number = "3-а", id_street = streets[1], amount = 49, year_repair = 2008},
//    //                                            new home{ID = 2, number = "12", id_street = streets[1], amount = 89, year_repair = 2018},
//    //                                            new home{ID = 3, number = "15", id_street = streets[1], amount = 105, year_repair = 2017},
//    //                                            new home{ID = 4, number = "5", id_street = streets[1], amount = 69, year_repair = 2011},
//    //                                            new home{ID = 5, number = "14-б", id_street = streets[1], amount = 49, year_repair = 2008},
//    //                                            new home{ID = 6, number = "23", id_street = streets[2], amount = 228, year_repair = 2018},
//    //                                            new home{ID = 7, number = "3-а", id_street = streets[2], amount = 250, year_repair = 2019},
//    //                                            new home{ID = 8, number = "3-б", id_street = streets[2], amount = 368, year_repair = 2019},
//    //                                            new home{ID = 9, number = "15", id_street = streets[2], amount = 102, year_repair = 2015},
//    //                                            new home{ID = 10, number = "13", id_street = streets[2], amount = 4, year_repair = 2007},
//    //                                            new home{ID = 11, number = "55", id_street = streets[3], amount = 498, year_repair = 2021},
//    //                                            new home{ID = 1, number = "7", id_street = streets[3], amount = 16, year_repair = 2010},
//    //                                            new home{ID = 1, number = "11", id_street = streets[3], amount = 189, year_repair = 2014},
//    //                                            new home{ID = 1, number = "25", id_street = streets[3], amount = 77, year_repair = 2012},
//    //                                            new home{ID = 1, number = "13-а", id_street = streets[4], amount = 49, year_repair = 2009},
//    //                                            new home{ID = 1, number = "13-б", id_street = streets[4], amount = 68, year_repair = 2016},
//    //                                            new home{ID = 1, number = "3-а", id_street = streets[4], amount = 200, year_repair = 2022},
//    //                                            new home{ID = 1, number = "17", id_street = streets[4], amount = 210, year_repair = 2020} });

//}
//EFDemo();
