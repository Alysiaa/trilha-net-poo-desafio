namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo;
        protected string IMEI;
        protected int Memoria;

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama: Implementado!

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades: Implementado!
        }

        public void Ligar()
        {
            Console.WriteLine("Digite o número de telefone para ligar: ");
            string Numero = Console.ReadLine();
            Console.WriteLine($"Ligando para o número: {Numero}");

        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

    }
}