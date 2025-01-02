using System.Dynamic;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo{ get;}
        private string Imei {get;}
        private int Memoria {get;}

        

        public Smartphone(string numero, string modelo, string imei, int memoria )
        {
            Numero = numero;
            Memoria = memoria; 
            Imei = imei; 
            Memoria = memoria; 

           
        }

        protected Smartphone(string modelo, string imei, int memoria)
        {
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}