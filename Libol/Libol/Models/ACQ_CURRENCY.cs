//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Libol.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ACQ_CURRENCY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACQ_CURRENCY()
        {
            this.ACQ_BUDGET_CREDIT = new HashSet<ACQ_BUDGET_CREDIT>();
            this.ACQ_BUDGET_DEBIT = new HashSet<ACQ_BUDGET_DEBIT>();
            this.ACQ_ITEM = new HashSet<ACQ_ITEM>();
            this.ACQ_PO = new HashSet<ACQ_PO>();
            this.CAT_EDATA_FILE = new HashSet<CAT_EDATA_FILE>();
            this.CIR_FINE = new HashSet<CIR_FINE>();
            this.EDELIV_FILE = new HashSet<EDELIV_FILE>();
        }
    
        public string CurrencyCode { get; set; }
        public float Rate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACQ_BUDGET_CREDIT> ACQ_BUDGET_CREDIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACQ_BUDGET_DEBIT> ACQ_BUDGET_DEBIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACQ_ITEM> ACQ_ITEM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACQ_PO> ACQ_PO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAT_EDATA_FILE> CAT_EDATA_FILE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIR_FINE> CIR_FINE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EDELIV_FILE> EDELIV_FILE { get; set; }
    }
}