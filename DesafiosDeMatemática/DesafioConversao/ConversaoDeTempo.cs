using System;

    class MinhaClasse2 
    {
        static void Main(string[] args) 
        {
            var timeInSeconds = int.Parse(Console.ReadLine());

        
            var hours = timeInSeconds / 3600;
            var minutes = (timeInSeconds - (hours * 3600)) / 60;
            var seconds = timeInSeconds - (hours * 3600) - (minutes *60);

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }