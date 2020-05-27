namespace AulaPOOcelular
{
    public class celular
    {
        public string cor;
        public string modelo;
        public int tamanho;
        public bool ligado;

        public string memoria;

        public bool desligado;
        public string Ligar(){
            if(ligado){
                return "celular ligado.";
            }
            else{
                return "Celular precisa ser ligado";
            }
                      
        }  
     
        public string FazerLigacao(){
            if(!ligado){
                return "Celular desligado";
            }
            else{
                return "ligando para...";
            }
        }
        public string EnviarMensagem(){
            if(ligado){
            return "enviar mensagem para...";
            }
            else{
                return "Celular está desligado";
            }
    }
    }
}