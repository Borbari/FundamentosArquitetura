namespace OOP
{
    public abstract class Eletrodomestico //abstract para usar classe como Herança não podendo chamar somente ela
    {
        private readonly string _nome;
        private readonly int _voltagem;
        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        public abstract void Ligar();//abstract sem metodo, classe que receber herança obrigada a escrever seu metodo
        public abstract void Desligar(); //abstract sem metodo, classe que receber herança obrigada a escrever seu metodo

         public virtual void Testar()// virtual escreve o codigo padrao, podendo ser modificar na classe que receber a herança
        {
            // teste do equipamento
        }
    }
}