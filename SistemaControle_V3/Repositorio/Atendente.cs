using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle_V3
{
    [Table("Atendente")]
    [Index(nameof(NomeAtendente), Name = "UQ__Atendent__6126F03611DBD54D", IsUnique = true)]
    public partial class Atendente
    {
        [Key]
        public int IdAtendente { get; set; }
        [Required]
        [StringLength(100)]
        public string NomeAtendente { get; set; }
    }
}
