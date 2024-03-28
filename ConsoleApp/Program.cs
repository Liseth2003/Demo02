
using MyLibrary;

Employee Maria = new Secretary();
Maria.Name = "Maria";

Employee Pedro = new Manager();
Pedro.Name = "Pedro";

Employee Miguel = new Developer();

WriteEmployeeInfo(Maria);
WriteEmployeeInfo(Miguel);
WriteEmployeeInfo(Pedro);

//Polimorfismo
void WriteEmployeeInfo(Employee employee)
{
    Console.WriteLine($"{employee.Name} : {employee.CalculateMonthlyPayment()}");
    Console.WriteLine($"Days: {employee.GetPaymentDays()}");
}