namespace BuilderPattern.NET
{
    public class CustomVacationPlanBuilder(string title) : VacationPlanBuilder(title)
    {
        public override VacationPlanBuilder AddPackage(string package)
        {
            VacationPlan.Packages.Add(package);
            return this;
        }

        public override VacationPlanBuilder BookFlight(string flight)
        {
            VacationPlan.Flight = flight;
            return this;
        }

        public override VacationPlanBuilder BookHotel(string hotel)
        {
            VacationPlan.Hotel = hotel;
            return this;
        }

        public override VacationPlanBuilder RentCar(string car)
        {
            VacationPlan.Car = car;
            return this;
        }
    }
}
