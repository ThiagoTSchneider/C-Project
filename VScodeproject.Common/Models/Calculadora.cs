
namespace VScodeProject.Common.Models
{
    //Class convention <-- Class name follows the code written in the .cs
    public class Calculadora
    {
        public void addition(int x, int y) //Method for addition
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void subtraction(int x, int y) //Method for subtraction
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void multiplication(int x, int y) //Method for multiplication
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void division(int x, int y) //Method for division
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void modules(int x, int y) //Method for modules
        {
            Console.WriteLine($"{x} % {y} = {x % y}");
        }
        public void power(int x, int y)
        {
            double pow = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pow}");
        }
        public void squareRoot(int x)
        {
            double sqrt = Math.Sqrt(x);
            Console.WriteLine($"Square root of {x} = {sqrt}");
        }
        public void Sine(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double sen = Math.Sin(radiano);
            Console.WriteLine($"Sine of {angulo}° = {Math.Round(sen, 4)}");
        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"coseno of {angulo}° = {Math.Round(coseno, 4)}");
        }
        public void tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"tangente of {angulo}° = {Math.Round(tangente, 4)}");
        }
    }

}