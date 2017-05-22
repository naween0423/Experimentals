namespace Experimental.BaseObjects
{
    /// <summary>
    /// Generic Tree
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Gtree<T>
    {
        /// <summary>
        /// Data
        /// </summary>
        public T Data;

        /// <summary>
        /// Left
        /// </summary>
        public Gtree<T> Left;

        /// <summary>
        /// Right
        /// </summary>
        public Gtree<T> Right;

        /// <summary>
        /// Constructor Initiallizes the Data 
        /// and Assigns Left and Right to null.
        /// </summary>
        /// <param name="value"></param>
        public Gtree(T value)
        {
            Data = value;
            Left = null;
            Right = null;
        }
    }
}
