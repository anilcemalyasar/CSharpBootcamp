using Introduction.Business;
using Introduction.DataAccess.Concretes;
using Introduction.Entities;

string msg = "Welcome to introduction tutorial";
Console.WriteLine(msg);

// variables --> camelCase
bool isAuthenticated = true;

if (isAuthenticated)
{
    Console.WriteLine("Hoşgeldin Anıl");
}
else
{
    Console.WriteLine("Buton -> Sisteme giriş yap");
}

string[] loans = { "Kredi1", "Kredi2", "Kredi3", "Kredi4" };
foreach (string s in loans)
{
    Console.WriteLine(s);
}

CourseManager courseManager = new CourseManager(new EfCourseDal());
List<Course> courses = courseManager.GetAll(); // normalde veri tabanından çekilir

for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "56789123422";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlama.io";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "123456789123";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "654779";
customer4.TaxNumber = "123456789456";

// Polymorphism
BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}




