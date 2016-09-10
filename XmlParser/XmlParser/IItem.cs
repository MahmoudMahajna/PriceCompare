

namespace XmlParser
{
    public interface IItem
    {
        long ChainId { get; set; }
        int SubChainId { get; set; }
        int StoreId { get; set; }
        int BikoretNo { get; set; }
        string PriceUpdateDate { get; set; }
        long ItemCode { get; set; }
        int ItemType { get; set; }
        string ItemName { get; set; }
        string ManufacturerName { get; set; }
        double Quantity { get; set; }
        bool IsWeighted { get; set; }
        float ItemPrice { get; set; }
        double UnitOfMeasurePrice { get; set; }
    }
}