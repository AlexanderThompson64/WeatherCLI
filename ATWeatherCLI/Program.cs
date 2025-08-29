// See https://aka.ms/new-console-template for more information

string firstName = "Alexander";
string lastName = "Thompson";
int age = 33;

static void SayHello(string firstName, string lastName, int age)
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("My first name is: " + firstName);
    Console.WriteLine("My last name is: " + lastName);
    Console.WriteLine("My age is: " + age);
    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
}

SayHello(firstName, lastName, age);

