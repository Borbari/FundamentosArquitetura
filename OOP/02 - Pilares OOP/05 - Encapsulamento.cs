
namespace OOP
{
    public class AutomacaoCafe
    {
        public void ServirCafe()//criando metodo encapsulando a class CafeteiraEspressa com seus metodos abstract
        {
            var espresso = new CafeteiraEspressa();
            espresso.Ligar();
            espresso.PrepararCafe();//chamando metodo publico com metodos privados da classe
            espresso.Desligar();
        }
    }
}