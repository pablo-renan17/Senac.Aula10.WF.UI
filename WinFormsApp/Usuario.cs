using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp
{
    public class Usuario
    {
        // Id, Nome, Email, Senha
        // O banco de dados ira gerar o valor 1,2,3,4,5 (auto_incremento)
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}