namespace Experimental.BaseObjects
{
    /// <summary>
    /// generic Node
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Gnode<T>
    {
        /// <summary>
        /// data
        /// </summary>
        private T data;
        private Gnode<T> next;

        /// <summary>
        /// Data
        /// </summary>
        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        /// <summary>
        /// Next
        /// </summary>
        public Gnode<T> Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
