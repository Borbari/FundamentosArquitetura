namespace OOP
{
    // Poli-morfismo
    public class CafeteiraEspressa : Eletrodomestico
    {
        public CafeteiraEspressa(string nome, int voltagem)// construtor passando atributo da herança como base
            : base(nome, voltagem) { }

        public CafeteiraEspressa() // construtor sem parametros base Padrao
            : base("Padrao", 220) {  }

        private static void AquecerAgua() { }

        private static void MoerGraos() { }

        public void PrepararCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
            // ETC...
        }

        public override void Testar()// override subescrever o metodo da herança
        {
            // teste de cafeteira
        }

        public override void Ligar()// override subescrever o metodo da herança
        {
            // Verificar recipiente de agua
        }

        public override void Desligar()// override subescrever o metodo da herança
        {
            // Resfriar aquecedor
        }
    }
}