

namespace PriceCompare.XmlParser
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
        string ManufactureCountry { get; set; }
        string ManufacturerItemDescription { get; set; }
        string UnitQty { get; set; }
        double Quantity { get; set; }
        bool IsWeighted { get; set; }
        string UnitOfMeasure { get; set; }
        int QtyInPackage { get; set; }
        double ItemPrice { get; set; }
        double UnitOfMeasurePrice { get; set; }
        bool AllowDiscount { get; set; }
        int ItemStatus { get; set; }
    }
}