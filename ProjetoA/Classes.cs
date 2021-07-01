using System.Runtime.CompilerServices;

//[assembly: InternalsVisibleTo("ProjetoB")]//é interna mas pode ser visivel para outro assembly(projetoB)
namespace ProjetoA
{
    #region Classes

    public class Publica
    {
        public void TestePublico() { }
        private void TestePrivado() { }
        internal void TesteInternal() { }
        protected void TesteProtegido() { }
        private protected void TestePrivadoProtegido() { }
        protected internal void TesteProtegidoInterno() { }
    }

    public sealed class Selada { }// class sealed nunca pode ser herdada para modificar

    class Privada { }// sem modificar de acesso torna a classe private

    internal class Interna { }

    abstract class Abstrata { }

    #endregion
    
    #region Testes

    class TesteClasses
    {
        public TesteClasses()
        {
            var publica = new Publica();//pode ser acessada
            var privada = new Privada();// so pode ser acessada se estiver no mesmo assembly
            var interna = new Interna();//pode instanciar se estiver dentro no mesmo assembly dll
            //var abstrata = new Abstrata(); // abstrata nao pode ser instanciada somente herdada
        }
    }

    //class TesteSelada : Selada { } // sealed nao pode ser herdada

    class TesteModificador1
    {
        public TesteModificador1()
        {
            var publica = new Publica();

            publica.TestePublico();
            publica.TesteInternal();//esta dentro do mesmo assembly (internal)
            publica.TesteProtegidoInterno();// esta dentro do mesmo assembly (internal)
            //publica.TesteProtegido(); // protected so pode ser chamada se estiver herdada
            //publica.TestePrivadoProtegido(); // protected so pode ser chamada se estiver herdada
            //publica.TestePrivado();// private somente a classe interna dona do metodo
        }
    }

    class TesteModificador2 : Publica
    {
        public TesteModificador2()
        {
            TestePublico();
            TesteInternal();//mesmo assembly
            TesteProtegido();////pode ser chamado se estiver herdando
            TesteProtegidoInterno();//mesmo assembly
            TestePrivadoProtegido();//pode ser chamado se estiver herdando
            //TestePrivado();// private somente a classe interna dona do metodo mesmo se herdado nao pode ser chamada
        }
    }

    #endregion
}

/*******************************************************/
// public:

// Access is not restricted.
/*******************************************************/
// protected:

// Access is limited to the containing class or types
// derived from the containing class.
/*******************************************************/
// internal:

// Access is limited to the current assembly.
/*******************************************************/
// protected internal:

// Access is limited to the current assembly or types
// derived from the containing class.
/*******************************************************/
// private:

// Access is limited to the containing type.
/*******************************************************/
// private protected:

// Access is limited to the containing class or types
// derived from the containing class within the current
// assembly.Available since C# 7.2.
/*******************************************************/
