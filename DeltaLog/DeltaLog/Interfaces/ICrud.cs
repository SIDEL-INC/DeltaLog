namespace DeltaLog.Interfaces
{
    public interface ICrud<K, T>
    {
        public K Insert(T value);
        public bool Delete(K id);
        public T Read(K Id);
        public bool Update(K id, T value);
    }
}
