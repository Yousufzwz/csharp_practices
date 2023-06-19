
using Interface_Practices;

IWelcomeEmailSender welcomeEmail = new HTMLEmailSender();
Membership membership = new Membership(welcomeEmail);
membership.Signup("xyz@gmail.com", "9876");

Person person = new Person();
person.Name = "Zakariya";
person.Address = "Gulshan";
person.Talk("hi");
person.Walk();
