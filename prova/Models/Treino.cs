using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prova.Models
{
    public class Treino
    {
        //define a chave primária da tabela TreinoS
        [Key]
        public int TreinoID { get; set; }

        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        [DataType(DataType.Time)]
        public DateTime Hora { get; set; }

        // Relacionamento com Personal
        public int PersonalID { get; set; }
        [ForeignKey("PersonalID")]
        public virtual Personal Personal { get; set; }

        // Relacionamento com Aluno
        public int AlunoID { get; set; }
        [ForeignKey("AlunoID")]
        public virtual Aluno Aluno { get; set; }

        // Relacionamento com Exercicio
        public int ExercicioID { get; set; }
        [ForeignKey("ExercicioID")]
        public virtual Exercicios Exercicio { get; set; }
    }
}
