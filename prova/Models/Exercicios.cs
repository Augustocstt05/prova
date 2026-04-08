using System.ComponentModel.DataAnnotations;

namespace prova.Models
{
    public class Exercicios
    {

        //define a chave primária da tabela Exercicios
        [Key]
        public int ExercicioID { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Categoria { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Treino> Treinos { get; set; }
    }
}
