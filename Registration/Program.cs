using Registration.Domain;

User user1 = new User("Jeff Jackson", "jeff@gmail.com", "jeff1234");
User user2 = new User("Sam Wills", "sam@gmail.com", "Sammy123");
Student student1 = new Student(99, "Ted Burt", "ted_b@gmail.com", "tburt321");
Console.WriteLine(user1.UserInfo());
Console.WriteLine(user2.UserInfo());
Console.WriteLine(student1.UserInfo());
Console.WriteLine(user1.PasswordChecker()); //false cunki boyuk herf yoxdur
Console.WriteLine(user2.PasswordChecker());