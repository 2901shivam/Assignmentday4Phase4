// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using AssignmentDayFour;

List<Product> product = new List<Product>()
{
    new Product(){Id=1,PName="AntiHarfall Shampoo",Price=150,PBrand="Head Shoulder",ManufactureDate=new DateTime(day:12,month:11,year:2022),ExpDate=new DateTime(day:10,month:02,year:2024)},
    new Product(){Id=2,PName="GoodDay",Price=40,PBrand="Britania",ManufactureDate=new DateTime(day:12,month:11,year:2023),ExpDate=new DateTime(day:10,month:02,year:2025)},
    new Product(){Id=3,PName="Glucose Biscut",Price=10,PBrand="Parle G",ManufactureDate=new DateTime(day:12,month:11,year:2022),ExpDate=new DateTime(day:10,month:02,year:2024)},
    new Product(){Id=4,PName="Kit kat",Price=100,PBrand="Cadburry",ManufactureDate=new DateTime(day:12,month:11,year:2022),ExpDate=new DateTime(day:10,month:02,year:2024)},
    new Product(){Id=5,PName="FiveStar",Price=50,PBrand="Cadburry",ManufactureDate=new DateTime(day:12,month:11,year:2022),ExpDate=new DateTime(day:10,month:02,year:2024)},


};
foreach (Product prd in product)
{
    Console.WriteLine("Id" + prd.Id);
    Console.WriteLine("PName:" + prd.PName);
    Console.WriteLine("Price:" + prd.Price);
    Console.WriteLine("PBrand:" + prd.PBrand);
    Console.WriteLine("Manufacture" + prd.ManufactureDate);
    Console.WriteLine("Exp:" + prd.ExpDate);
}
