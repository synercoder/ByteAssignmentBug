using System;

namespace ByteAssignmentBug
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            Span<byte> span = new byte[1];
            span[0] = random.NextDouble() < 0.5
                ? 0x66
                : 0x6E;

            Console.WriteLine($"The byte in the span is: {span[0]:X2}");

            Console.WriteLine("Done...");
            Console.ReadLine();
        }
    }
}
