//using System;
//namespace DSA2_Assignment2
//{
//	public class Link
//	{
//		string node;
//		public static string links;
//		int distance;
//		float maxSpeed;
//	}
//}

using System;

namespace DSA2_Assignment2
{
    public class Link
    {
        public Link(string _vertex1, string _vertex2, int distanceBetween, int maxSpeed)
        {
            vertex_1 = _vertex1;
            vertex_2 = _vertex2;
            distance = distanceBetween;
            maximumSpeed = maxSpeed;
            int cost = distance / maximumSpeed;
        }


        public string vertex_1;
        public string vertex_2;
        public int distance;
        public int maximumSpeed;
        //public float time = cost;
    }
}


