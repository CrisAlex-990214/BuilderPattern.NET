// See https://aka.ms/new-console-template for more information

using BuilderPattern.NET;

var concreteBuilder = new CustomVacationPlanBuilder("Full Vacation Plan");

var planDetails = new VacationPlanDto
{
    Car = "940-DOIFD",
    Flight = "AIF9-FD",
    Hotel = "AOFC",
    Packages = ["City Tour", "Hiking"]
};

new TravelAgency().FullVacationPlan(concreteBuilder, planDetails);

Console.WriteLine(concreteBuilder.VacationPlan.PlanDetails());
Console.WriteLine("--------------");

concreteBuilder = new CustomVacationPlanBuilder("Custom Vacation Plan");
concreteBuilder.BookFlight("IF9F-DFD")
               .BookHotel("AIV9-DF")
               .AddPackage("Camping");

Console.WriteLine(concreteBuilder.VacationPlan.PlanDetails());
Console.ReadKey();
