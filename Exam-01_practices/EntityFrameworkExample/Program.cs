// See https://aka.ms/new-console-template for more information

using EntityFrameworkExample;

CategoryDbContext context = new CategoryDbContext();

//context.Products.Add(new Product { Name = "Rayban_Sunglass", Tag = "G-01X", IsActive = true });
//context.Products.Add(new Product { Name = "Casio_Watch", Tag = "WA-BX", IsActive = true });
//context.Products.Add(new Product { Name = "Laundry_Detergent", Tag = "LD-11", IsActive = true });
//context.Customers.Add(new Customer { Name = "Ahmad", Address= "LA_Street_9A"});
//context.Customers.Add(new Customer { Name = "Zakariya", Address = "Green_Road_1A" });

//context.SaveChanges();


Product p1=context.Products.Where(p=>p.Id == 3).FirstOrDefault();
Console.WriteLine(p1.Name);

p1.Name = "Lithium Battery";
p1.Tag = "LB-890";
context.SaveChanges();

context.Remove(p1);
context.SaveChanges();