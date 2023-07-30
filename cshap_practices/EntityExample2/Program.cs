// See https://aka.ms/new-console-template for more information

using EntityExample2;

CategoryDbContext newContext = new CategoryDbContext();

//newContext.Products.Add(new Product { Name = "US-POLO", Tag = "PL-021", IsActive = true });
//newContext.Products.Add(new Product { Name = "Loafer-Shoe", Tag = "S-101", IsActive = true });
//newContext.Essential.Add(new Essential { Name = "Eraser" });

//newContext.SaveChanges();

Product p1 = newContext.Products.Where(x => x.Name =="Loafer-Shoe").FirstOrDefault();
Console.WriteLine(p1.Name);

p1.Tag = "981A";
newContext.SaveChanges();

newContext.Remove(p1);
newContext.SaveChanges();   