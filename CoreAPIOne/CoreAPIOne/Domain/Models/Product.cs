using static CoreAPIOne.Domain.Enums.Enum;

namespace CoreAPIOne.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short QuantityInPackage { get; set; }
        public EUnitOfMeasurement UnitOfMeasurement { get; set; }

        //Representation for : Product has one and only one category
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}