
namespace Pensionato {
    class Quarto {
        // atributos
        public int Numero { get; set; }
        public bool Vago { get; set; }
        public Cliente Hospede;

        // construtores

        public Quarto(int num) {
            Numero = num;
            Vago = true;
        }

    }
}
