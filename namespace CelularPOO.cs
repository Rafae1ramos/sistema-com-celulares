namespace CelularPOO.Models
{
    public abstract class Celular
    {
        public string Marca { get; protected set; }
        public string Modelo { get; protected set; }
        public string Cor { get; protected set; }

        public Celular(string marca, string modelo, string cor)
        {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
        }

        public abstract void Ligar();
        public abstract void Desligar();
        public abstract void TirarFoto();
        public abstract void ConectarInternet();
        public abstract void InstalarApp(string app);

        public void MostrarInformacoes()
        {
            Console.WriteLine($"Marca: {Marca} | Modelo: {Modelo} | Cor: {Cor}");
        }
    }
}

