namespace Lv.Design.Patterns.GOF.Structural.Decorator.Interfaces
{
    public abstract class IDecoratorRepository : IRepository
    {
        protected IRepository _repo;

        public IDecoratorRepository(IRepository repo)
        {
            this._repo = repo;
        }

        public void commit()
        {
            this._repo.commit();
        }

        public abstract void CommitADO();
    }
}
