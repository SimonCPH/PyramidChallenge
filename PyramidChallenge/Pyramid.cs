using System;
using System.Collections.Generic;

namespace PyramidChallenge
{
    public class Pyramid
    {
        
        private IList<IList<IVertex>> rows;

        public int Height
        {
            get { return rows.Count; }
        }
        public IVertex Top
        {
            get {
                if (rows.Count == 0)
                {
                    throw new InvalidOperationException("Cant access top. The pyramid is empty.");
                }
                return rows[0][0];
            }
        }

        public Pyramid()
        {
            rows = new List<IList<IVertex>>();
        }

        public void AddRow(IList<int> newIntegerRow)
        {
            if (Height == 0 && newIntegerRow.Count != 1)
            {
                throw new ArgumentException("First row must be a single number");
            }

            IList<IVertex> newVertexRow =
                Pyramid.CreateVertexList(newIntegerRow);
            
            if (Height > 0)
            {
                IList<IVertex> parrentRow = rows[Height - 1];
                if (newVertexRow.Count != parrentRow.Count + 1)
                {
                    throw new ArgumentException(
                        "Lenght of row must be one heigher than the last one - and equal to the new height of the pyramid");
                }
                SetChildRelationsInParrentRow(parrentRow, newVertexRow);
            }

            rows.Add(newVertexRow);
        }

        private static void SetChildRelationsInParrentRow(
            IList<IVertex> parrentRow,
            IList<IVertex> newRow)
        {
            for (int i = 0; i < parrentRow.Count; i++)
            {
                IVertex parrent = parrentRow[i];
                IVertex child1 = newRow[i];
                IVertex child2 = newRow[i + 1];

                if (!Pyramid.EqualParity(parrent.Value, child1.Value))
                {
                    parrent.LeftChild = child1;
                }
                if (!Pyramid.EqualParity(parrent.Value, child2.Value))
                {
                    parrent.RightChild = child2;
                }
            }
        }

        private static bool EqualParity(int a, int b)
        {
            //if (a+b) is even, then a and b have the same parity
            return (a + b) % 2 == 0;
        }

        public static IList<IVertex> CreateVertexList(IList<int> newIntegerRow)
        {
            if (newIntegerRow == null)
            {
                throw new ArgumentException("Input list of integers cant be null");
            }

            IList<IVertex> vertexList = new List<IVertex>();
            foreach (int number in newIntegerRow)
            {
                vertexList.Add(new Vertex(number));
            }
            return vertexList;
        }
    }
}

