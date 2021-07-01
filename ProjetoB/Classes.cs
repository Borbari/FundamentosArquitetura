using ProjetoA;

namespace ProjetoB
{
    class TesteClasses
    {
        public TesteClasses()
        {
            //[assembly: InternalsVisibleTo("ProjetoB")] descomentar codigo projetoA para funcionamento
            var publica = new Publica();
            //var privada = new Privada();//so para seu assembly ProjetoA
            //var interna = new Interna();//so para seu assembly ProjetoA
            //var abstrata = new Abstrata();
        }
    }

    class TesteModificador1
    {
        public TesteModificador1()
        {
            var publica = new Publica();
            //[assembly: InternalsVisibleTo("ProjetoB")] descomentar codigo projetoA para funcionamento
            publica.TestePublico();
            //publica.TesteInternal();
            //publica.TesteProtegidoInterno();
            //publica.TesteProtegido();
            //publica.TestePrivadoProtegido();
            //publica.TestePrivado();
        }
    }

    class TesteModificador2 : Publica
    {
        public TesteModificador2()
        {
            //[assembly: InternalsVisibleTo("ProjetoB")] descomentar codigo projetoA para funcionamento
            TestePublico();
            TesteProtegido();
            TesteProtegidoInterno();
            //TesteInternal();
            //TestePrivadoProtegido();
            //TestePrivado();
        }
    }
}


