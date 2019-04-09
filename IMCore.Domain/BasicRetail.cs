﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class BasicRetail
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("LaborId")]
        public int LaborId { get; set; }
        [Column("BranchId")]
        public int? BranchId { get; set; }
        [Column("StoreId")]
        public int? StoreId { get; set; }
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [ForeignKey("BranchId")]
        [InverseProperty("Retails")]
        public virtual Branch Branch { get; set; }
        [ForeignKey("LaborId")]
        [InverseProperty("Retails")]
        public virtual BasicLabor Labor { get; set; }
        [ForeignKey("StoreId")]
        public virtual Client Store { get; set; }
    }
}
