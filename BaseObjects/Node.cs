namespace Experimental.BaseObjects
{
    /// <summary>
    /// Node
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Data
        /// </summary>
        public int Data { get; set; }
        /// <summary>
        /// Next
        /// </summary>
        public Node Next { get; set; }

        public Node()
        {

        }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="data"></param>
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }    
}
