namespace BuilderPattern.NET
{
    public class TravelAgency
    {
        public void FullVacationPlan(VacationPlanBuilder builder, VacationPlanDto dto)
        {
            builder.BookFlight(dto.Flight);
            builder.BookHotel(dto.Hotel);
            builder.RentCar(dto.Car);
            dto.Packages.ForEach(p => builder.AddPackage(p));
        }

    }

    public class VacationPlanDto
    {
        public string Flight { get; set; }
        public string Hotel { get; set; }
        public string Car { get; set; }
        public List<string> Packages { get; set; }
    }
}
