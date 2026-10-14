#region állatok listája

List<Pet> pets = [
    new()
    {
        Id = 1,
        Name = "Pötyi",
        Species = "macska",
        BirthYear = 2016,
        FavFoods = ["macskakaja"],
        Gender = true,
    },
    new()
    {
        Id = 2,
        Name = "Rio",
        Species = "papagáj",
        BirthYear = 2021,
        FavFoods = ["magok", "szotyi"],
        Gender = true,
    },
    new()
    {
        Id = 3,
        Name = "Nigga",
        Species = "macska",
        BirthYear = 2025,
        FavFoods = ["macskakaja"],
        Gender = true,
    },
    new()
    {
        Id = 4,
        Name = "Gyere ide",
        Species = "kutya",
        BirthYear = 2001,
        FavFoods = ["csont"],
        Gender = true,
    },
    new()
    {
        Id = 5,
        Name = "Nem",
        Species = "hörcsög",
        BirthYear = 2026,
        FavFoods = ["fű", "proteinszelet"],
        Gender = false,
    },
    new()
    {
        Id = 6,
        Name = "Muki",
        Species = "macska",
        BirthYear = 2026,
        FavFoods = ["csirke", "száraztáp"],
        Gender = false,
    },
    new()
    {
        Id = 7,
        Name = "Nóra",
        Species = "húg",
        BirthYear = 2012,
        FavFoods = ["saláta", "láma"],
        Gender = false,
    },
    new()
    {
        Id = 8,
        Name = "Semmi",
        Species = "degu",
        BirthYear = 2010,
        FavFoods = ["répa", "magok"],
        Gender = false,
    },
    new()
    {
        Id = 9,
        Name = "Hami",
        Species = "hörcsög",
        BirthYear = 2025,
        FavFoods = ["répa", "magok"],
        Gender = true,
    },
    new()
    {
        Id = 10,
        Name = "Rudolf",
        Species = "teknős",
        BirthYear = 2014,
        FavFoods = ["táp"],
        Gender = true,
    },
    new()
    {
        Id = 11,
        Name = "Ice",
        Species = "macska",
        BirthYear = 2018,
        FavFoods = ["kolbász"],
        Gender = false,
    },
    new()
    {
        Id = 11,
        Name = "Picur",
        Species = "hörcsög",
        BirthYear = 2016,
        FavFoods = ["random"],
        Gender = true,
    },
    new()
    {
        Id = 12,
        Name = "Harapós",
        Species = "octavia",
        BirthYear = 2009,
        FavFoods = ["95' benzin", "100' benzin"],
        Gender = true,
    },
    new()
    {
        Id = 14,
        Name = "Lucifer",
        Species = "macska",
        BirthYear = 2023,
        FavFoods = ["macskaleves"],
        Gender = true,
    },
    new()
    {
        Id = 15,
        Name = "Kira",
        Species = "kutya",
        BirthYear = 2012,
        FavFoods = ["kutyakaja", "szalámi"],
        Gender = false,
    },
    new()
    {
        Id = 16,
        Name = "Zorro",
        Species = "kutya",
        BirthYear = 2019,
        FavFoods = ["kutyakaja", "halrúd"],
        Gender = true,
    },
    new()
    {
        Id = 17,
        Name = "Apolló",
        Species = "kutya",
        BirthYear = 2023,
        FavFoods = ["kígyóuborka", "görögdinnye", "áfonya", "kutyakaja"],
        Gender = true,
    },
    new()
    {
        Id = 18,
        Name = "Manci",
        Species = "macska",
        BirthYear = 2023,
        FavFoods = ["sonka", "sajt"],
        Gender = true,
    },
    new()
    {
        Id = 19,
        Name = "Grabowsky",
        Species = "hörcsög",
        BirthYear = 2021,
        FavFoods = ["uborka", "saláta", "répa"],
        Gender = true,
    }];

#endregion

// sorozatszámítás (összegzés --> átlag)     SUM()   
// megszámlálás                              COUNT()
// szélsőérték helymeghatározás (min, max)   MIN(). MAX()

// eldöntés                                  ANY(), ALL(),
// kiválasztás                               
// lineáris keresés                            

// rendezés(ek)                              ORDER BY
// másolás                                   SELECT
// kiválogatás                               WHERE
// szétválogatás ('csoportosítás')           GROUP BY

// [halmaztételek (unió, metszet, különbség...)]

// C# -> LINQ (Language INtegrated Querry)

//sum és az avg: hogy egy olyan
//propertyt vagy kifejezést kell neki megdni, amin értelmezett
// az összeadás (numerikus prop.)

int sum = pets.Sum(x => x.Age);
Console.WriteLine($"állatok összéletkora: {sum} év");

double avg = pets.Average(x => x.Age);
Console.WriteLine($"állatok átlagéletkora: {avg:0.00} év");

// <condition> kell a labda után -> azt a számot adja vissza,
// ahány object esetén a condition is true

int count = pets.Count(x => x.Species == "macska");
Console.WriteLine($"macskák száma: {count}");

// min, max -> csak az ÉRTÉKET adja vissza (általában nem ez kell)
// minby, maxby -> azt az obj-t adja vissza, amihez a zárójelben
// tartozó értékek részhalmazán a min/max érték tartozik
// olyan tulajdonságot kell kiválasztani, ami teljesíti az IComperable if-et.

List<string> dolgokAmiketSzeretek = [];

string? dolgo = dolgokAmiketSzeretek.MaxBy(x => x);
Console.WriteLine(dolgo is null);


Pet? lva = pets.MaxBy(x => x.FavFoods.Count);
Console.WriteLine($"legidősebb állat: {lva}");

// any/all -> valamilyen condidiont vár, bool értékkel tér vissza
// any -> van-e olyan eleme, amire teljesül, hogy <condition>
// all -> a kollekció minden egyes elemére teljesül-e az, hogy

bool vank = pets.Any(x => x.Species == "kenguru");
Console.WriteLine(vank ? "van kenguru" : "nincs kenguru");