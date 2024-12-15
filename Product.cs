using System.Text;

namespace BuilderPattern.NET
{
    public class VacationPlan
    {
        private string Title { get; set; }
        public VacationPlan(string title)
        {
            Title = title;
        }

        public string Hotel { get; set; }
        public string Flight { get; set; }
        public string Car { get; set; }
        public List<string> Packages { get; set; } = new();

        public string PlanDetails()
        {
            return new StringBuilder($"Plan details for {Title}\n")
                .AppendLine($"Flight: {Flight}")
                .AppendLine($"Hotel: {Hotel}")
                .AppendLine($"Car: {Car}")
                .AppendLine($"Packages: {string.Join(',', Packages)}").ToString();
        }
    }
}
