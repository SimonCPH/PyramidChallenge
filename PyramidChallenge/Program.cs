using System;

namespace PyramidChallenge
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pyramid Challenge");
            
            int[] r01 = { 215 };
            int[] r02 = { 192, 124 };
            int[] r03 = { 117, 269, 442 };
            int[] r04 = { 218, 836, 347, 235 };
            int[] r05 = { 320, 805, 522, 417, 345 };
            int[] r06 = { 229, 601, 728, 835, 133, 124 };
            int[] r07 = { 248, 202, 277, 433, 207, 263, 257 };
            int[] r08 = { 359, 464, 504, 528, 516, 716, 871, 182 };
            int[] r09 = { 461, 441, 426, 656, 863, 560, 380, 171, 923 };
            int[] r10 = { 381, 348, 573, 533, 448, 632, 387, 176, 975, 449 };
            int[] r11 = { 223, 711, 445, 645, 245, 543, 931, 532, 937, 541, 444 };
            int[] r12 = { 330, 131, 333, 928, 376, 733, 017, 778, 839, 168, 197, 197 };
            int[] r13 = { 131, 171, 522, 137, 217, 224, 291, 413, 528, 520, 227, 229, 928 };
            int[] r14 = { 223, 626, 034, 683, 839, 052, 627, 310, 713, 999, 629, 817, 410, 121 };
            int[] r15 = { 924, 622, 911, 233, 325, 139, 721, 218, 253, 223, 107, 233, 230, 124, 233 };
            
            Pyramid pyramid = new Pyramid();
            pyramid.AddRow(r01);
            pyramid.AddRow(r02);
            pyramid.AddRow(r03);
            pyramid.AddRow(r04);
            pyramid.AddRow(r05);
            pyramid.AddRow(r06);
            pyramid.AddRow(r07);
            pyramid.AddRow(r08);
            pyramid.AddRow(r09);
            pyramid.AddRow(r10);
            pyramid.AddRow(r11);
            pyramid.AddRow(r12);
            pyramid.AddRow(r13);
            pyramid.AddRow(r14);
            pyramid.AddRow(r15);
            
            MaxSumPathFinder maxSumPathFinder =
                new MaxSumPathFinder(pyramid);

            Path maxSumPath = maxSumPathFinder.MaxSumPath;

            Console.WriteLine("Max sum: " + maxSumPath.Sum);
            Console.Write("Path: ");
            foreach (IVertex vertex in maxSumPath.VertexList)
            {
                Console.Write(vertex.Value.ToString() + " ");
            }
            Console.WriteLine();

            
            Console.ReadLine();
        }
    }
}
