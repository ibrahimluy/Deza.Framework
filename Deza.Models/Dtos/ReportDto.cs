using Deza.Stone;

namespace Deza.Models.Dtos
{
    public class ReportDto : IDto
    {
        public int companyId { get; set; }

        public int deviceId { get; set; }

        public long tc { get; set; }

        public string name { get; set; }

        public string surName { get; set; }

        public string reportDate { get; set; }
    }
}
