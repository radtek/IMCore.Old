﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    public partial class MaterialCategoryOptionsMappings
    {
        [Column("MaterialCategoryId")]
        public int MaterialCategoryId { get; set; }
        [Column("OptionId")]
        public int OptionId { get; set; }

        [ForeignKey("MaterialCategoryId")]
        [InverseProperty("MaterialCategoryOptionsMappings")]
        public virtual MaterialCatagory MaterialCategory { get; set; }
        [ForeignKey("OptionId")]
        [InverseProperty("MaterialCategoryOptionsMappings")]
        public virtual Options Option { get; set; }
    }
}
