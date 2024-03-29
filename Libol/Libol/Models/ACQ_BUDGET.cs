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
    
    public partial class ACQ_BUDGET
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACQ_BUDGET()
        {
            this.ACQ_BUDGET_ACCUMULATE = new HashSet<ACQ_BUDGET_ACCUMULATE>();
            this.ACQ_BUDGET_CREDIT = new HashSet<ACQ_BUDGET_CREDIT>();
            this.ACQ_BUDGET_DEBIT = new HashSet<ACQ_BUDGET_DEBIT>();
        }
    
        public int ID { get; set; }
        public string Currency { get; set; }
        public string BudgetCode { get; set; }
        public string Purpose { get; set; }
        public decimal Balance { get; set; }
        public Nullable<decimal> RealBalance { get; set; }
        public string BudgetName { get; set; }
        public Nullable<int> Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACQ_BUDGET_ACCUMULATE> ACQ_BUDGET_ACCUMULATE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACQ_BUDGET_CREDIT> ACQ_BUDGET_CREDIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACQ_BUDGET_DEBIT> ACQ_BUDGET_DEBIT { get; set; }
    }
}
