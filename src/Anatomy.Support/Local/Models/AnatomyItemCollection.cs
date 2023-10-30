namespace Anatomy.Support.Local.Models
{
    public class AnatomyItemCollection : List<object>
    {
        public void Add<T>() where T : class
        {
            Add(typeof(T));
        }

        public void AddInstance(object instance)
        {
            if (instance != null)
            {
                base.Add(instance);
            }
            else
            {
                throw new ArgumentNullException(nameof(instance));
            }
        }
    }
}