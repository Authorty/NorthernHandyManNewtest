//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheNorthernHandyManReDone11_3_18.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Image
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Image()
        {
            this.ImageGroups = new HashSet<ImageGroup>();
        }
    
        public int Id { get; set; }
        public string ImageName { get; set; }
        public Nullable<int> FolderName { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public byte[] ImageData { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImageGroup> ImageGroups { get; set; }
    }
}