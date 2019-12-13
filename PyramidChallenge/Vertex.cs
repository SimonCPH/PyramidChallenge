using System;
using System.Collections.Generic;

namespace PyramidChallenge
{
    public interface IVertex
    {
        int Value { get; }
        IVertex LeftChild { get; set; }
        IVertex RightChild { get; set; }
        bool IsLeave { get; }
    }

    public class Vertex : IVertex
    {
        public int Value { get; }
        public IVertex LeftChild { get; set ; }
        public IVertex RightChild { get; set ; }
        public bool IsLeave
        {
            get { return LeftChild == null && RightChild == null; }
        }

        public Vertex(int value)
        {
            this.Value = value;
        }

    }
}
