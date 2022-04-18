using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City;

public class street
{
    public int ID;
    public string name;
}

public class home
{
    public int ID;
    public string number;
    public street id_street;
    public int amount;
    public int year_repair;
}

public class Database
{
    public List<street> streets;
    public List<home> homes;

    public Database()
    {

        streets = new List<street>
        {
            new street{ID = 1, name = "Вавилова"},
            new street{ID = 2, name = "Вольская"},
            new street{ID = 3, name = "Рабочая"},
            new street{ID = 4, name = "Чапаева"},
        };

        homes = new List<home>
        {
            new home{ID = 1, number = "3-а", id_street = streets[0], amount = 49, year_repair = 2008},
            new home{ID = 2, number = "12", id_street = streets[0], amount = 89, year_repair = 2018},
            new home{ID = 3, number = "15", id_street = streets[0], amount = 105, year_repair = 2017},
            new home{ID = 4, number = "5", id_street = streets[0], amount = 69, year_repair = 2011},
            new home{ID = 5, number = "14-б", id_street = streets[0], amount = 49, year_repair = 2008},
            new home{ID = 6, number = "23", id_street = streets[1], amount = 228, year_repair = 2018},
            new home{ID = 7, number = "3-а", id_street = streets[1], amount = 250, year_repair = 2019},
            new home{ID = 8, number = "3-б", id_street = streets[1], amount = 368, year_repair = 2019},
            new home{ID = 9, number = "15", id_street = streets[1], amount = 102, year_repair = 2015},
            new home{ID = 10, number = "13", id_street = streets[1], amount = 4, year_repair = 2007},
            new home{ID = 11, number = "55", id_street = streets[2], amount = 498, year_repair = 2021},
            new home{ID = 12, number = "7", id_street = streets[2], amount = 16, year_repair = 2010},
            new home{ID = 13, number = "11", id_street = streets[2], amount = 189, year_repair = 2014},
            new home{ID = 14, number = "25", id_street = streets[2], amount = 77, year_repair = 2012},
            new home{ID = 15, number = "13-а", id_street = streets[3], amount = 49, year_repair = 2009},
            new home{ID = 16, number = "13-б", id_street = streets[3], amount = 68, year_repair = 2016},
            new home{ID = 17, number = "3-а", id_street = streets[3], amount = 102, year_repair = 2022},
            new home{ID = 1, number = "17", id_street = streets[3], amount = 210, year_repair = 2020},
        };

    }
}