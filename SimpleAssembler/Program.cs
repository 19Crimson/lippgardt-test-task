using System;
using System.Collections.Generic;

namespace SimpleAssembler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize test inputs
            string[][] testInputs = new string[][]
            {
                new string[] { "mov a 5", "inc a", "dec a", "dec a", "jnz a -1", "inc a" },
                new string[] {"mov a -10", "mov b a", "inc a", "dec b", "jnz a -2"},
                new string[] {"mov t 25", "dec t", "mov k t", "dec t", "jnz t -1" }
            };

            // Testing the Interpret() func with test inputs
            testRunInterpret(testInputs);
        }

        // Implementation of simple assembler impreteter
        public static Dictionary<string, int> Interpret(string[] program)
        {
            var registers = new Dictionary<string, int>();

            for (int i = 0; i < program.Length; i++)
            {
                string[] instruction = program[i].Split(' ');
                string command = instruction[0];
                string register = instruction[1];

                switch (command)
                {
                    case "mov":
                        registers[register] = int.TryParse(instruction[2], out int value) ? value : registers[instruction[2]];
                        break;
                    case "inc":
                        registers[register]++;
                        break;
                    case "dec":
                        registers[register]--;
                        break;
                    case "jnz":
                        if (int.TryParse(register, out int val) && val != 0 || registers.ContainsKey(register) && registers[register] != 0)
                            i += Convert.ToInt32(instruction[2]) - 1;
                        break;
                }
            }
            return registers;
        }


        static void testRunInterpret(string[][] testInputs)
        {
            for (int i = 0; i < testInputs.Length; i++)
            {
                Dictionary<string, int> resultDict = Interpret(testInputs[i]);

                Console.WriteLine($"Testing input: {String.Join(", ", testInputs[i])}");
                Console.WriteLine("The values of returned registers are:");

                foreach (KeyValuePair<string, int> keyValue in resultDict)
                {
                    Console.WriteLine($"register: {keyValue.Key}, value: {keyValue.Value}");
                }

                Console.WriteLine("\n");
            }
        }
    }
}
