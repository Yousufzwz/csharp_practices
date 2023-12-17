using DependencyInjection;

IWelcomeEmailSender emailSender = new HTMLEmailSender();

Membership firstMember = new Membership(emailSender);
firstMember.SignUp("abc@gmail.com", "12345");

