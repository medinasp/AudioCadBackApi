using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AudioCad.Models
{
    public class Projeto
    {
        [Key]
        public int ProjetoId { get; set; }

        public string Nome { get; set; }

        public int ClienteId { get; set; }

        public string Status { get; set; }

        [Display(Name = "Data Criação")]
        public DateTime DataCriacao { get; set; }

        [Display(Name = "Data Alteração")]
        public DateTime? DataAlteracao { get; set; }
    }
}
