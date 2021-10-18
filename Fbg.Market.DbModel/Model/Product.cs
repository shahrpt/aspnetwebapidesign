//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fbg.Market.DbModel.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
            this.ProductImages = new HashSet<ProductImage>();
        }
    
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
        public Nullable<int> VID { get; set; }
        public Nullable<int> ColorCategoryId { get; set; }
        public string ShopifyPicUrl { get; set; }
        public string VendorName { get; set; }
    
        public virtual Brand Brand { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ProductStatu ProductStatu { get; set; }
        public virtual RefNRFColorCode RefNRFColorCode { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
