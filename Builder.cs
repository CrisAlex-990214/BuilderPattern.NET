namespace BuilderPattern.NET
{
    public abstract class VacationPlanBuilder
    {
        public VacationPlan VacationPlan { get; set; }
        protected VacationPlanBuilder(string title)
        {
            VacationPlan = new VacationPlan(title);
        }

        public abstract VacationPlanBuilder BookFlight(string flight);
        public abstract VacationPlanBuilder BookHotel(string hotel);
        public abstract VacationPlanBuilder RentCar(string car);
        public abstract VacationPlanBuilder AddPackage(string package);
    }
}
