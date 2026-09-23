namespace Aula01.Models
{
    public class Carro
    {


        //PROPIEDADES(ATRIBUTOS/ CARACTERISTICAS)

        public string Marca { get; set; }


        public string Modelo { get; set; }

        public string Cor {  get; set; }

        //MÉTODOS (AÇÕES)

        public string Acelerar()
        {
            return $"o {Modelo}  {Marca}  está acelerando";
        }

    }
}
