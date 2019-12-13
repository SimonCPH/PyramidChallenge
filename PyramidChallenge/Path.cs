using System;
using System.Collections.Generic;

namespace PyramidChallenge
{
    public class Path
    {
        public int Sum { get; private set; }
        public IList<IVertex> VertexList { get; }
        public int Length
        {
            get { return VertexList.Count; }
        }

        public Path()
        {
            VertexList = new List<IVertex>();
        }

        public Path(Path pathToCopy)
        {
            Sum = 0;
            VertexList = new List<IVertex>();
            foreach (IVertex vertex in pathToCopy.VertexList)
            {
                this.Push(vertex);
            }
        }

        public void Push(IVertex vertex)
        {
            VertexList.Add(vertex);
            Sum += vertex.Value;
        }

        public void Pop()
        {
            Sum -= VertexList[VertexList.Count - 1].Value;
            VertexList.RemoveAt(VertexList.Count - 1);
        }
    }
}
