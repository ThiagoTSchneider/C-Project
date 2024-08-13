
namespace VScodeProject.Common.Models
{

    //Class convention <-- Class name follows the code written in the .cs
    public class PessoaFisica
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public string RepresentanteLegal { get; set; } = string.Empty;

        public void apresentar()
        {
            Console.WriteLine($"Nome:{Nome}");
            Console.WriteLine($"Idade:{Idade} ");
            Console.WriteLine($"Representante Legal:{RepresentanteLegal}");
        }
    }
}