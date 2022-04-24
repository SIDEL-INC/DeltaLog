using DeltaLog.Interfaces;

namespace DeltaLog.Models
{
    public class DefaultFilePersistManager : IFilePersistManager
    {
        protected string Root => "";

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Guid Insert(DataModels.File value)
        {
            throw new NotImplementedException();
        }

        public DataModels.File Read(Guid Id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Guid id, DataModels.File value)
        {
            throw new NotImplementedException();
        }
    }
}
