using System;

class Program
{
    static void Main(string[] args)
    {

        const string usernameCorect = "Filip";
        const string parolaCorecta = "I love info";

        bool autentificat = false;

        while (!autentificat)
        {
            Console.Write("Introduceți username: ");
            string username = Console.ReadLine();

            Console.Write("Introduceți parola: ");
            string parola = Console.ReadLine();

            if (username == usernameCorect && parola == parolaCorecta)
            {
                Console.WriteLine("Bine ai venit, " + usernameCorect);
                autentificat = true;

            }
            else
            {
                Console.WriteLine("Autentificare eșuată. Vă rugăm să încercați din nou.");
            }
        }
    }
}