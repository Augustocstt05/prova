using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prova.Models
{
    public class Aluno
    {

        //define a chave primária da tabela Aluno
        [Key]
        public int AlunoID { get; set; }

        [Required]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        public DateTime Data_Nascimento { get; set; }

        public string E_Mail { get; set; }
        public string Instagram { get; set; }
        public string Telefone { get; set; }
        public string Observacoes { get; set; }

        // Chave Estrangeira para Personal
        public int PersonalID { get; set; }
        [ForeignKey("PersonalID")]
        public virtual Personal Personal { get; set; }

        public virtual ICollection<Treino> Treinos { get; set; }
    }
}
