﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("CheckCBDetail")]
    public partial class CheckCbdetail
    {
        [Column("CheckCBDetailID")]
        public int CheckCbdetailId { get; set; }
        [Column("CheckID")]
        public int CheckId { get; set; }
        [Column("ChargeBackID")]
        public int ChargeBackId { get; set; }
        [Column(TypeName = "numeric(19, 2)")]
        public decimal Amount { get; set; }

        [ForeignKey("ChargeBackId")]
        [InverseProperty("CheckCbdetail")]
        public virtual ChargeBacks ChargeBack { get; set; }
        [ForeignKey("CheckId")]
        [InverseProperty("CheckCbdetail")]
        public virtual Checks Check { get; set; }
    }
}