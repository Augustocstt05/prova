using System.ComponentModel.DataAnnotations;

namespace prova.Models
{
    public class Personal
    {

        //define a chave primária da tabela Personal
        [Key]
        public int PersonalID { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Especialidade { get; set; }

        // Relacionamento: 1 Personal tem muitos Alunos e muitos Treinos
        public virtual ICollection<Aluno> Alunos { get; set; }
        public virtual ICollection<Treino> Treinos { get; set; }
    }
}
