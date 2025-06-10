using System;

namespace AudioProgram
{
    // Define the AUDIO class
    class AUDIO
    {
        public int Tone { get; set; }
        public int Time { get; set; }

        // Constructor
        public AUDIO(int tone, int time)
        {
            Tone = tone;
            Time = time;
        }

        // Method to play the sound
        public void PlaySound()
        {
            Console.Beep(Tone, Time);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, welcome to my AI generated program.");
            Console.Write("Enter the frequency (in Hz): ");
            int tone = int.Parse(Console.ReadLine());

            Console.Write("Enter the duration (in milliseconds): ");
            int time = int.Parse(Console.ReadLine());

            AUDIO audio = new AUDIO(tone, time);
            audio.PlaySound();

            Console.WriteLine("Sound played successfully!");
        }
    }
}
