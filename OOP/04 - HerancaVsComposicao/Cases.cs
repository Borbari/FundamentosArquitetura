using System;

namespace OOP
{
    #region Caso 1

    public class PessoaFisica : Pessoa //caso de Heranca: a classe que herda devera ter o sempre o mesmo comportamento no caso (PessoaFisica ainda sera uma Pessoa)
    {
        public string Cpf { get; set; }
    }

    public class PessoaFisica2 // caso de Composicao:
    {
        public Pessoa Pessoa { get; set; }
        public string Cpf { get; set; }
    }

    public class TestesHerancaComposicao
    {
        public TestesHerancaComposicao()
        {
            var pessoaHeranca = new PessoaFisica // Heranca melhor didatica
            {
                Nome = "Joao",
                DataNascimento = DateTime.Now,
                Cpf = "32165498765"
            };

            var pessoaComposicao = new PessoaFisica2 // Composicao
            {
                Pessoa = new Pessoa
                {
                    Nome = "Joao",
                    DataNascimento = DateTime.Now,
                },
                Cpf = "32165498765"
            };

            var nomeHeranca = pessoaHeranca.Nome;// Heranca chama pela a instancia o obejto
            var nomeComposicao = pessoaComposicao.Pessoa.Nome;// Composicao chama pela instancia do objeto e pela Classe
        }
    }

    #endregion

    #region Caso 2

    public interface IRepositorio<T> //reposotorio generico, T pode ser qualquer classe
    {
        void Adicionar(T obj);

        void Excluir(T obj);
    }

    public interface IRepositorioPessoa //repositorio especializado, interface feita para classe Pessoa
    {
        void Adicionar(Pessoa obj);
    }

    public class Repositorio<T> : IRepositorio<T>//reposotorio generico que implementa tambem os metodos gerico para o reposotorio
    {
        public void Adicionar(T obj)
        {

        }

        public void Excluir(T obj)
        {

        }
    }

    public class RepositorioHerancaPessoa : Repositorio<Pessoa>, IRepositorioPessoa // classe herda do Repositorio e implementa a interface
    {

    }

    public class RepositorioComposicaoPessoa : IRepositorioPessoa // implementa a interface IRepositorioPessoa uso do metodo Adicionar();
    {
        private readonly IRepositorio<Pessoa> _repositorioPessoa;//interface generica do tipo pessoa

        public RepositorioComposicaoPessoa(IRepositorio<Pessoa> repositorioPessoa)//IRepositorio ejetado como parametro
        {
            _repositorioPessoa = repositorioPessoa;
        }

        public void Adicionar(Pessoa obj)
        {
            _repositorioPessoa.Adicionar(obj);
        }
    }

    public class TestesHerancaComposicao2
    {
        public TestesHerancaComposicao2()
        {
            var repoH = new RepositorioHerancaPessoa();//passa os dois metodos generico
            repoH.Adicionar(new Pessoa());
            repoH.Excluir(new Pessoa());//permite o desenvolver excluir um item que vc nao quer excluir

            var repoC = new RepositorioComposicaoPessoa(new Repositorio<Pessoa>());//esperando qualquer classe que representa o contrato
            repoC.Adicionar(new Pessoa());//escolhe o metodo que quer passar
        }
    }

    #endregion
}