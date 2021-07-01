namespace OOP
{
    public interface IRepositorio //interface espécie de contratado obrigando usar os metodos da interface 
    {
        void Adicionar();
    }

    public class Repositorio : IRepositorio
    {
        //public Repositorio(int a)
        //{
            
        //}

        public void Adicionar()
        {
            // Adiciona item
  
        }
    }

    public class RepositorioFake : IRepositorio
    {
        public void Adicionar()
        {
            // Adiciona item
        }
    }

    public class UsoImplementacao //implementa uma classe concreta e chama seu metodo sem parametros
    {
        public void Processo()
        {
            var repositorio = new Repositorio();
            repositorio.Adicionar();
        }
    }

    public class UsoAbstracao //implementa uma classe concreta e chama seu metodo com parametros
    {
        private readonly IRepositorio _repositorio;//usando um _repositorio que esta sendo usado pelo o proprio contrato (IRepositorio)

        public UsoAbstracao(IRepositorio repositorio)//injetando a instancia de uma classe no construtor da classe(UsoAbstracao) 
        {
            _repositorio = repositorio;//podendo usar metodos com parametros da classe que esta sendo instanciada
        }

        public void Processo()
        {
            _repositorio.Adicionar();
        }
    }

    public class TesteInterfaceImplementacao//implementa a classe sem o uso do construtor
    {
        public TesteInterfaceImplementacao()
        {
            var repoImp = new UsoImplementacao();
            repoImp.Processo();

            var repoAbs = new UsoAbstracao(new Repositorio());//passando o objeto, chamando a classe sem depedencia do construtor
            repoAbs.Processo();

            var repoAbsFake = new UsoAbstracao(new RepositorioFake());
            repoAbsFake.Processo();
        }
    }
}
