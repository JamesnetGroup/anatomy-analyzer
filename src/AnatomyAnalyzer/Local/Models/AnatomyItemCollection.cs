namespace AnatomyAnalyzer.Local.Models
{
    public class AnatomyItemCollection : List<Type>
    {

        public void Add<T>()
        {
            Add(typeof(T));
        }
    }
}
