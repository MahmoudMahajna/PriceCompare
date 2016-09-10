namespace PriceCompare.Model.Interfaces
{
    public interface IPrice
    {
        long ItemCode { get; set; }
        int StoreId { get; set; }
        long ChainId { get; set; }
        string ItemName { get; set; }
        float ItemPrice { get; set; }
        double Quantity { get; set; }
        double UnitOfMeasurePrice { get; set; }
        Item Item { get; set; }
        Store Store { get; set; }
    }
}