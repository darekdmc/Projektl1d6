using Projektl1d6;

Employee employee1 = new Employee("Jan", "Kowalski", 20);
Employee employee2 = new Employee("Janusz", "Bizensu", 30);
Employee employee3 = new Employee("Marek", "Kondrat", 70);

employee1.AddScore(1);
employee1.AddScore(5);
employee1.AddScore(5);
employee1.AddScore(5);
employee1.AddScore(5);

employee2.AddScore(2);
employee2.AddScore(3);
employee2.AddScore(3);
employee2.AddScore(3);
employee2.AddScore(2);

employee3.AddScore(1);
employee3.AddScore(1);
employee3.AddScore(2);
employee3.AddScore(2);
employee3.AddScore(5);

var result = employee1.Result;
Console.WriteLine(result);
