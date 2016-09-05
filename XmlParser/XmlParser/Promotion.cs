using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PriceCompare.XmlParser
{
    class Promotion:IPromotion
    {
        [XmlElement("ChainId")]
        public long ChainId { get; set; }

        [XmlElement("SubChainId")]
        public int SubChainId { get; set; }

        [XmlElement("StoreId")]
        public long StoreId { get; set; }

        [XmlElement("BikoretNo")]
        public int BikoretNo { get; set; }

        [XmlElement("PriceUpdateDate")]
        public string PriceUpdateDate { get; set; }

        [XmlElement("PromotionId")]
        public int PromotionId { get; set; }

        [XmlElement("AllowMultipleDiscounts")]
        public int AllowMultipleDiscounts { get; set; }

        [XmlElement("PromotionDescription")]
        public StringBuilder PromotionDescription { get; set; }

        [XmlElement("PromotionUpdateDate")]
        public StringBuilder PromotionUpdateDate { get; set; }

        [XmlElement("PromotionStartDate")]
        public StringBuilder PromotionStartDate { get; set; }

        [XmlElement("PromotionStartHour")]
        public StringBuilder PromotionStartHour { get; set; }

        [XmlElement("PromotionEndDate")]
        public StringBuilder PromotionEndDate { get; set; }

        [XmlElement("PromotionEndHour")]
        public StringBuilder PromotionEndHour { get; set; }

        [XmlElement("DiscountedPricePerMida")]
        public double DiscountedPricePerMida { get; set; }

        [XmlElement("MinPurchaseAmnt")]
        public double MinPurchaseAmnt { get; set; }

        [XmlElement("MinQty")]
        public int MinQty { get; set; }

        [XmlElement("MaxQty")]
        public int MaxQty { get; set; }

        [XmlElement("RewardType")]
        public int RewardType { get; set; }

        [XmlElement("DiscountRate")]
        public double DiscountRate { get; set; }

        [XmlElement("DiscountType")]
        public int DiscountType { get; set; }

        [XmlElement("DiscountedPrice")]
        public double DiscountedPrice { get; set; }

        [XmlElement("MinNoOfItemOfered")]
        public int MinNoOfItemOfered { get; set; }

        [XmlElement("PromotionItems")]
        public PromotionItem[] PromotionItems { get; set; }

        [XmlElement("AdditionalRestrictions")]
        public AdditionalRestrictions AdditionalRestrictions { get; set; }

        [XmlElement("Remarks")]
        public StringBuilder Remarks { get; set; }

        [XmlArray("Clubs")]
        [XmlArrayItem("Club", typeof(Club))]
        public Club[] Clubs { get; set; }
    }
}
