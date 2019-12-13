using System;
using System.Collections.Generic;

namespace PyramidChallenge
{
    public class MaxSumPathFinder
    {
        private readonly Pyramid pyramid;
        private Path tempPath;
        private Path maxSumPath;
        
        public Path MaxSumPath
        {
            get {
                tempPath = new Path();
                maxSumPath = new Path();
                FindMaxSumPathFrom(pyramid.Top);
                return maxSumPath;
            }
        }

        public MaxSumPathFinder(Pyramid pyramid)
        {
            this.pyramid = pyramid;
        }

        // Find a path with maximum sum of its vertices
        // 
        // The strategi is depth first traversal
        // Intensional sideeffect:
        //      maxSumPath : A path with maximum sum of its vertices
        private void FindMaxSumPathFrom(IVertex startVertex)
        {
            tempPath.Push(startVertex);

            if (startVertex.IsLeave)
            {
                if (tempPath.Length == pyramid.Height
                && tempPath.Sum  > maxSumPath.Sum)
                { 
                    maxSumPath = new Path(tempPath);
                }
            }
            else
            {
                if (startVertex.LeftChild != null)
                {
                    FindMaxSumPathFrom(startVertex.LeftChild);
                }

                if (startVertex.RightChild != null)
                {
                    FindMaxSumPathFrom(startVertex.RightChild);
                }
            }
           
            tempPath.Pop();
        }
    }
}
