using System;

namespace _02_OOP
{
    public class Persona
    {
        private int a;

        // property = campo privato + getter method (pubblico) + setter method (pubblico)
        // property sono realizzazione dei design pattern di encapsulation e information hiding
        /// <summary>
        ///     Il nome di battesimo della persona.
        /// </summary>
        public string Nome { get; set; }


        // boilerplate
        //private string cognome;
        //public string GetCognome()
        //{
        //    return this.cognome;
        //}
        //public void SetCognome(string cognome)
        //{
        //    this.cognome = cognome;
        //}
        public string Cognome { get; set; }


        // Console.WriteLine("ciao"); // => NON FUNZ!
        /// <summary>
        /// Questo metodo stamp anome e cognome sulla console.
        /// </summary>
        public void StampaDatiAnagrafici()
        {
            Console.WriteLine($"Nome: {this.Nome} {this.Cognome}");
        }
    }
}
