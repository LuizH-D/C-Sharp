

namespace Pensionato {
    class Cliente {
        // atributos
        public string Nome { get; set; }
        public string Email { get; set; }

        // construtores
        public Cliente(string nome, string email) {
            Nome = nome;
            Email = email;
        }

        // métodos

        public override string ToString() {
            return $"{Nome}, {Email}";
        
        }
    }
}
