using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiFilme.Models
{
    [Table("tb_ator")]
    public partial class TbAtor
    {
        public TbAtor()
        {
            TbFilmeAtor = new HashSet<TbFilmeAtor>();
        }

        [Key]
        [Column("id_ator")]
        public int IdAtor { get; set; }
        [Column("nm_ator", TypeName = "varchar(70)")]
        public string NmAtor { get; set; }
        [Column("dt_nascimento", TypeName = "date")]
        public DateTime? DtNascimento { get; set; }
        [Column("vl_altura", TypeName = "decimal(10,2)")]
        public decimal? VlAltura { get; set; }

        [InverseProperty("IdAtorNavigation")]
        public virtual ICollection<TbFilmeAtor> TbFilmeAtor { get; set; }
    }
}
