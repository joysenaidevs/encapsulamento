namespace encapsulamento.classe
{
    public class Cartao
    {
        private string numero; // private: atributo ou metodo só é visivel dentro da propria classe
        private string bandeira = "MasterCard";
        public string Bandeira{
            get{ return bandeira;} // Pegar dados
            set{ bandeira = value;} //inserir dados
        }
        protected string token = "qwetyui";
        private string cvv;
        protected float limite = 5000; // protected:  a classe e os herdeiros

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