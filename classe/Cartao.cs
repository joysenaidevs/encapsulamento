namespace encapsulamento.classe
{
    public class Cartao
    {
        private string numero; // private: atributo ou metodo só é visivel dentro da propria classe
        public string Numero{
            get {return numero;}
            set {numero = value;}
        }
        private string bandeira = "MasterCard";

        //propiedade
        public string Bandeira{
            //metodo acessor
            get{ return bandeira;} // Pegar dados - retorna um valor - leitura dos dados
            set{ bandeira = value;} //inserir dados - altera a propiedade - definir um valor - registro dos dados
        }
        protected string token = "qwetyui";
        public string Token{
            get {return token;}
            // ou só get;
        }
        private string cvv;
        public string Cvv{
            get {return cvv;}
            set {cvv = value;}
        }
        protected float limite = 5000; // protected:  a classe e os herdeiros
        public float Limite{
            get { return limite; }
        }

        //DECLARACAO DOS METODOS
        public string RegistrarCompra(bool validado){
            return "compra registrada";
        }

        private bool ValidarCompra(float saldo){
            return true;
        }

        protected string ValidarToken(string token){
            return "validacao";

        }

    }
}