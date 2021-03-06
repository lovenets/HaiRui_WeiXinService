//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class OfficialAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OfficialAccount()
        {
            this.Account_QRCode_Template = new HashSet<Account_QRCode_Template>();
            this.AutoReply = new HashSet<AutoReply>();
            this.AutoReply_Category = new HashSet<AutoReply_Category>();
            this.CashCouponRecord = new HashSet<CashCouponRecord>();
            this.Goods = new HashSet<Goods>();
            this.Goods_Order = new HashSet<Goods_Order>();
            this.Subscriber = new HashSet<Subscriber>();
            this.TemplateMessage = new HashSet<TemplateMessage>();
        }
    
        public System.Guid AccountID { get; set; }
        public string WeiXinName { get; set; }
        public string OriginalID { get; set; }
        public string WeiXinNumber { get; set; }
        public string AppID { get; set; }
        public string AppSecret { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.Guid> UserID { get; set; }
        public Nullable<bool> IsConfigure { get; set; }
        public string QRCodeBgImg { get; set; }
        public Nullable<int> SubscribeAddScore { get; set; }
        public Nullable<int> UnSubscribeReduceScore { get; set; }
        public string SubscribeWelcome { get; set; }
        public string ReSubscribeWelcome { get; set; }
        public string SignLanguage { get; set; }
        public Nullable<int> SubscribeParentAddScore { get; set; }
        public Nullable<int> UnSubscribeParentReduceScore { get; set; }
        public Nullable<int> SignAddScore { get; set; }
        public Nullable<bool> YouZanIsConfig { get; set; }
        public string YouZanAppID { get; set; }
        public string YouZanAppSecret { get; set; }
        public Nullable<decimal> YZIncomeFirstPercent { get; set; }
        public Nullable<decimal> YZIncomeSecondPercent { get; set; }
        public Nullable<decimal> YZIncomeCashLimit { get; set; }
        public string WeiXinToken { get; set; }
        public string SignTMsgId { get; set; }
        public Nullable<bool> YouZanEnable { get; set; }
        public string AreaLimit { get; set; }
        public string AreaLevel { get; set; }
        public string FirstFansName { get; set; }
        public string SecondFansName { get; set; }
        public string Mch_ID { get; set; }
        public string CashCoupon_SendName { get; set; }
        public Nullable<int> CashCoupon_MinScore { get; set; }
        public Nullable<int> CashCoupon_EveryAmount { get; set; }
        public string CashCoupon_Wishing { get; set; }
        public string CashCoupon_ActivityName { get; set; }
        public string CashCoupon_Remark { get; set; }
        public string Mch_API_Password { get; set; }
        public string Mch_Cert_Password { get; set; }
        public string Mch_Cert_Path { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account_QRCode_Template> Account_QRCode_Template { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutoReply> AutoReply { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutoReply_Category> AutoReply_Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashCouponRecord> CashCouponRecord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Goods> Goods { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Goods_Order> Goods_Order { get; set; }
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subscriber> Subscriber { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TemplateMessage> TemplateMessage { get; set; }
    }
}
