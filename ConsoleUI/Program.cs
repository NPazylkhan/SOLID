using ConsoleUI;
using OCPLibrary;

//StandardMessages.WelcomeMessage();

//Person user = PersonDataCapture.Capture();

//bool isUserValid = PersonValidator.Validate(user);

//if (!isUserValid)
//{
//    StandardMessages.EndApplication();
//    return;
//}

//AccountGenerator.CreateAccount(user);
//StandardMessages.EndApplication();

List<IApplicantModel> applicants = new List<IApplicantModel>
{
    new PersonModel{FirstName = "Tim", LastName ="Corey"},
    new ManagerModel{FirstName ="Sue", LastName = "Lee"},
    new ExecutiveModel{FirstName ="Nancy", LastName="Roman"}
};

List<EmployeeModel> employees = new List<EmployeeModel>();

foreach (var person in applicants)
{
    employees.Add(person.AccountProcessor.Create(person));
}

foreach (var emp in employees)
{
    Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} IsManager: {emp.IsManager} IsExecutive: {emp.IsExecutive}");
}

Console.ReadLine();