namespace RedisProject.September.Model
{
    public class ProductionDTO
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? ProductNumber { get; set; }
        public short MakeFlag { get; set; }
        public short FinishedGoodsFlag { get; set; }
        public string? Color { get; set; }
        public int SafetyStockLevel { get; set; }
        public int ReorderPoint { get; set; }
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public int Size { get; set; }
        public string? SizeUnitMeasureCode { get; set; }
        public string? WeightUnitMeasureCode { get; set; }
        public decimal Weight { get; set; }
        public int DaysToManufacture { get; set; }
        public string? ProductLine { get; set; }
        public string? Class { get; set; }
        public string? Style { get; set; }
        public DateTime SellStartDate { get; set; }
        public DateTime SellEndDate { get; set; }
        public string? DiscontinuedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
