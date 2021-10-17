using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.InputModel
{
    public class JogoInputModel
    {
        
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "O nome do jogo deve conter entre 3 e 100 caracteres")]
        public string Nome { get; set; }

        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 1, ErrorMessage = "O nome da produtora deve conter entre 1 e 100 caracteres")]
        public string Produtora { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage = "O nome do jogo deve conter entre 3 e 100 caracteres")]
        public double Preco { get; set; }
    }
}
