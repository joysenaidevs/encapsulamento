namespace encapsulamento.classe
{
    public class MasterCard : Cartao // herdando a superclasse
    {
        //A palavra-chave get define um método do acessador em uma propriedade ou um indexador que retorna o valor da propriedade ou o elemento do indexador.
        //Geralmente, o acessador get consiste em uma única instrução que retorna um valor

        //A palavra-chave set define um método acessador em uma propriedade ou indexador que atribui um valor ao elemento da propriedade ou do elemento.

        //Para casos simples em que os acessadores get e set de uma propriedade não realizam nenhuma outra operação, a não ser a configuração ou a recuperação de um valor em um campo de suporte particular, você pode tirar proveito do suporte do compilador do C# para propriedades autoimplementadas. O exemplo a seguir implementa Hours como uma propriedade autoimplementada.
     
        /*{
        public double Hours { get; set; }
        }
        */

        private int parcelas;

        //get e set -  Podemos definir que as classes obtenham ou insiram dados nela
        //sao responsaveis por dar acesso a um atributo em questao de leitura ou gravacao

        public int Parcelas{
            get { return parcelas; } //sintex completa - Pegar dados
            //get;
            set { parcelas = value; } // inserir dados
        }



        public string ComprarComDesconto(){
            return "desconto";

        }


    }
}