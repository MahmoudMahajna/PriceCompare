using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCompare.XmlParser
{
    public interface IPromotion
    {
          long ChainId { get; set; }
          int SubChainId { get; set; }
          long StoreId { get; set; }
          int BikoretNo { get; set; }
          string PriceUpdateDate { get; set; }
          int PromotionId { get; set; }
          int AllowMultipleDiscounts { get; set; }
          StringBuilder PromotionDescription { get; set; }
          StringBuilder PromotionUpdateDate { get; set; }
          StringBuilder PromotionStartDate { get; set; }
          StringBuilder PromotionStartHour { get; set; }
          StringBuilder PromotionEndDate { get; set; }
          StringBuilder PromotionEndHour { get; set; }
          double DiscountedPricePerMida { get; set; }
          double MinPurchaseAmnt { get; set; }
          int MinQty { get; set; }
          int MaxQty { get; set; }
          int RewardType { get; set; }
          double DiscountRate { get; set; }
          int DiscountType { get; set; }
          double DiscountedPrice { get; set; }
          int MinNoOfItemOfered { get; set; }
          PromotionItem[] PromotionItems { get; set; }
          AdditionalRestrictions AdditionalRestrictions { get; set; }
          StringBuilder Remarks { get; set; }
          Club[] Clubs { get; set; }
    }
}
