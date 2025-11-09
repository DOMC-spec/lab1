using System;

namespace House.Models
{
    /// <summary>
    /// Модель жилищного комплекса
    /// </summary>
    public class ResidentialComplex
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Status { get; set; }
        public decimal ComplexCostCoefficient { get; set; }
        public decimal ConstructionCost { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
