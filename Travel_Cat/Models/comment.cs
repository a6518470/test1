//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Travel_Cat.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class comment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public comment()
        {
            this.comment_emoji_details = new HashSet<comment_emoji_details>();
            this.message = new HashSet<message>();
        }
    
        public long comment_id { get; set; }
        public string tourism_id { get; set; }
        public string comment_title { get; set; }
        public string comment_content { get; set; }
        public System.DateTime comment_date { get; set; }
        public string comment_photo { get; set; }
        public int comment_stay_total { get; set; }
        public string travel_partner { get; set; }
        public short comment_rating { get; set; }
        public string travel_month { get; set; }
        public bool comment_status { get; set; }
        public string member_id { get; set; }
    
        public virtual member member { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment_emoji_details> comment_emoji_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<message> message { get; set; }
    }
}
