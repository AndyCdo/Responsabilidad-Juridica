using System;

namespace Responsabilidad_Juridica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que tipo de persona es: ");
            string personaNoJ= Convert.ToString(Console.ReadLine());
            string mensaje= "";
            mensaje= tipoPersona(personaNoJ);
            Console.WriteLine(mensaje);
        }
        static string tipoPersona(string persona){
            if (persona == "Persona Natural"){
                return "No Declara Renta";
            }
            else if (persona == "Persona Juridica"){
                return "Declara Renta";
            }
            else
            {
                return " ";
            }
        }
    }
}
