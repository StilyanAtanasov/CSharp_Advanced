uint[] matrixSize = Console.ReadLine()!.Split(", ").Select(uint.Parse).ToArray();
int[,] matrix = new int[matrixSize[0], matrixSize[1]];