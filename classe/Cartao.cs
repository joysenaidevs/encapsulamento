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
        public string Bandeira{
            get{ return bandeira;} // Pegar dados
            set{ bandeira = value;} //inserir dados
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