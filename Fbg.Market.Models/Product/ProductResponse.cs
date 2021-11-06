using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fbg.Market.Models.Product
{
    public class ProductResponse
    {
        public Nullable<int> BID { get; set; }
        public int PID { get; set; }
        public string SKUCode { get; set; }
        public string UPCCode { get; set; }
        public string PName { get; set; }
        public string PColor { get; set; }
        public string PSize { get; set; }
        public short PCategory { get; set; }
        public string PSubCategory { get; set; }
        public Nullable<int> NRFColorCodeID { get; set; }
        public Nullable<int> SID { get; set; }
        public string PDescription { get; set; }
        public string PSpecs { get; set; }
        public string PCoutryofOrigin { get; set; }
        public bool PDiscontinued { get; set; }
        public Nullable<decimal> PFOBCost { get; set; }
        public Nullable<decimal> PLandedCost { get; set; }
        public decimal PWholesalePrice { get; set; }
        public Nullable<decimal> PMSRPPrice { get; set; }
        public string PPicture { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
        public Nullable<int> ProductStatusId { get; set; }
        public int VID { get; set; }
        public Nullable<int> ColorCategoryId { get; set; }
        public string ShopifyPicUrl { get; set; }
        public string VendorName { get; set; }
    
    }
}
