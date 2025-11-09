using System;

namespace House.Models
{
    /// <summary>
    /// Модель дома
    /// </summary>
    public class HouseModel
    {
        public int Id { get; set; }
        public int ResidentialComplexId { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public decimal HouseCostCoefficient { get; set; }
        public decimal ConstructionCost { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        // Additional properties for display
        public string ComplexName { get; set; }
        public string ComplexStatus { get; set; }
        public int SoldApartmentsCount { get; set; }
        public int SellingApartmentsCount { get; set; }

        // Alias for compatibility
        public decimal AdditionalCost
        {
            get => HouseCostCoefficient;
            set => HouseCostCoefficient = value;
        }
    }
}
