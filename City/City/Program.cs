using System;
using City;
//using City.EF;
using System.Data.SqlClient;

static void AdoNET()
{
    var connection = new SqlConnection("Server=MSI; Database=City2; Trusted_Connection=True;");
    connection.Open();


    Console.WriteLine($"\n1. Список домов, отсортированных по давности ремонта:");
    var command = connection.CreateCommand();
    command.CommandText = "SELECT a.number, b.name FROM homes a JOIN streets b ON a.id_streetID = b.ID order by(a.year_repair)";

    var reader = command.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"Номер дома:{reader.GetString(0)} название:{reader.GetString(reader.GetOrdinal("name"))}");
    }
    reader.Close();

    Console.WriteLine($"\n2. Список домов, отсортированных по степени необходимости в ремонте:");
    command = connection.CreateCommand();
    command.CommandText = "SELECT a.number, b.name FROM homes a JOIN streets b ON a.id_streetID = b.ID order by (select(a.amount * (2022 - a.year_repair)))desc";

    reader = command.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"Номер дома:{reader.GetString(0)} название:{reader.GetString(reader.GetOrdinal("name"))}");
    }
    reader.Close();

    Console.WriteLine($"\n3. Список домов, ремонтированных позже среднего по базе:");
    command = connection.CreateCommand();
    command.CommandText = "SELECT a.number, b.name FROM homes a, streets b where a.id_streetID = b.ID and a.year_repair < (select avg(year_repair) from homes)";

    reader = command.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"Номер дома:{reader.GetString(0)} название:{reader.GetString(reader.GetOrdinal("name"))}");
    }
    reader.Close();

    Console.WriteLine($"\n4. Дома ремонтированные позднее 5-ти лет:");
    command = connection.CreateCommand();
    command.CommandText = "SELECT b.name, count(a.number) as home_count FROM homes a, streets b where a.id_streetID = b.ID group by b.name order by count(a.number)";

    reader = command.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"Название улицы: {reader.GetString(0)} кличество домов: {reader.GetInt32(reader.GetOrdinal("home_count"))}");
    }
    reader.Close();

    Console.WriteLine($"\n5. Самый старый по ремонту дом и произвести в нем ремонт:");
    Console.WriteLine($"До выполнения ремонта:");
    command = connection.CreateCommand();
    command.CommandText = "SELECT a.number, b.name, a.year_repair FROM homes a, streets b where a.id_streetID = b.ID";

    reader = command.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"Номер дома: {reader.GetString(0)} название улицы:{reader.GetString(reader.GetOrdinal("name"))} год ремонта {reader.GetInt32(reader.GetOrdinal("year_repair"))}");
    }
    reader.Close();
    command = connection.CreateCommand();
    command.CommandText = "SELECT a.ID FROM homes a, streets b where a.year_repair = (select min(year_repair) from homes)";
    reader = command.ExecuteReader();
    //while (reader.Read())
    //{
    //    var connection_del = new SqlConnection(@"Server = MSI; Database = City; Trusted_Connection = True;");
    //    connection_del.Open();
    //    var command_del = connection_del.CreateCommand();
    //   command_del.CommandText = $"UPDATE homes SET year_repair = 2022 WHERE id ={reader.GetInt32(reader.GetOrdinal("ID"))};";
    //    command_del.ExecuteReader();
    //    connection_del.Close();
    //}
    reader.Close();
    Console.WriteLine($"\nПосле выполнения ремонта:");
    command = connection.CreateCommand();
    command.CommandText = "SELECT a.number, b.name, a.year_repair FROM homes a, streets b where a.id_streetID = b.ID";

    reader = command.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"Номер дома: {reader.GetString(0)} название улицы:{reader.GetInt32(reader.GetOrdinal("year_repair"))}");
    }
    reader.Close();

 

    Console.WriteLine($"\n6. Самый маленький по числу квартир дом удалить:");
    Console.WriteLine($"До удаления дома:");
    command = connection.CreateCommand();
    command.CommandText = "SELECT a.number, b.name, a.amount FROM homes a, streets b where a.id_streetID = b.ID";
    reader = command.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"Номер дома: {reader.GetString(0)} название улицы:{reader.GetString(reader.GetOrdinal("name"))} год ремонта {reader.GetInt32(reader.GetOrdinal("amount"))}");
    }
    reader.Close();
    command = connection.CreateCommand();
    command.CommandText = "SELECT a.ID FROM homes a, streets b where a.amount = (select min(amount) from homes)";
    reader = command.ExecuteReader();
    //while (reader.Read())
    //{
    //    var connection_del = new SqlConnection(@"Server = MSI; Database = City; Trusted_Connection = True;");
    //    connection_del.Open();
    //    var command_del = connection_del.CreateCommand();
    //    command_del.CommandText = $"DELETE homes WHERE ID = {reader.GetInt32(reader.GetOrdinal("ID"))};";
    //    command_del.ExecuteReader();
    //    connection_del.Close();
    //}
    reader.Close();
    Console.WriteLine($"\nПосле удаления дома:");
    command = connection.CreateCommand();
    command.CommandText = "SELECT a.number, b.name, a.amount FROM homes a, streets b where a.id_streetID = b.ID";

    reader = command.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"Номер дома: {reader.GetString(0)} название улицы:{reader.GetInt32(reader.GetOrdinal("amount"))}");
    }
    reader.Close();


    Console.WriteLine($"\n7. Поставить дом на наименее заселенной улице:");
    Console.WriteLine($"До постройки дома, самая наименее заселённая:");
    command = connection.CreateCommand();
    command.CommandText = "select top(1) a.name, SUM(b.amount) as sum from streets a, homes b where a.ID = b.id_streetID GROUP BY a.name order by sum(b.amount)";
    reader = command.ExecuteReader();
    //while (reader.Read())
    //{
    //    Console.WriteLine($"Название улицы: {reader.GetString(0)} количество квартир:{reader.GetInt32(reader.GetOrdinal("sum"))}");
    //}
    //reader.Close();
    command = connection.CreateCommand();
    command.CommandText = $"select id from streets where name = '{reader.GetString(reader.GetOrdinal("name"))}'";
    //reader = command.ExecuteReader();
    //while (reader.Read())
    //{
    //    var connection_del = new SqlConnection(@"Server = MSI; Database = City; Trusted_Connection = True;");
    //    connection_del.Open();
    //    var command_del = connection_del.CreateCommand();
    //    command_del.CommandText = $"INSERT INTO homes VALUES(25, {reader.GetInt32(reader.GetOrdinal("ID"))}, 300, 2022);";
    //    command_del.ExecuteReader();
    //    connection_del.Close();
    //}
    //reader.Close();
    Console.WriteLine($"\nПосле постройки дома:");
    command = connection.CreateCommand();
    command.CommandText = "SELECT a.number, b.name, a.amount FROM homes a, streets b where a.id_streetID = b.ID";

    reader = command.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"Номер дома: {reader.GetString(0)} название улицы:{reader.GetString(reader.GetOrdinal("name"))}");
    }
    reader.Close();


    connection.Close();
}

static void Requests()
{
    Database db = new Database();
    Console.WriteLine($"1. Список домов, отсортированных по давности ремонта:");
    foreach (home e in db.homes.OrderBy(e => e.year_repair))
    {
        Console.WriteLine($"{e.number} {e.id_street.name}");
    }

    Console.WriteLine($"2. Список домов, отсортированных по степени потребности в ремонте:");
    foreach (home e in db.homes.OrderByDescending(e => ((2022 - e.year_repair) * e.amount)))
    {
        Console.WriteLine($"{e.number} {e.id_street.name}");
    }

    Console.WriteLine($"3. Список домов, ремонтированных позже среднего по базе:");
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

    Console.WriteLine($"4. Дома ремонтированные позднее 5-ти лет:");
    foreach (var g in db.homes.Where(e => e.year_repair < 2017).GroupBy(e => e.id_street.name)
            .Select(x => new { street_name = x.Key, count = x.Count() }))
    {
        Console.WriteLine($"{g.street_name} {g.count}");
    }

    Console.WriteLine($"5. Самый старый по ремонту дом:");
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

    Console.WriteLine($"6. Самый маленький по числу квартир дом удалить \n До:");
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

    Console.WriteLine($"7. Наименее заселенная улица:");
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
