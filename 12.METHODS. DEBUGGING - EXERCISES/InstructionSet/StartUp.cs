﻿namespace InstructionSet
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            long result = 0;

            while (command != "END")
            {
                string[] codeArgs = command.Split(' ');

                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = ++operandOne;
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = --operandOne;
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = (long)operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = (long)operandOne * operandTwo;
                            break;
                        }
                }
                command = Console.ReadLine();
                Console.WriteLine(result);
            }
        }
    }
}
