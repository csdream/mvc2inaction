namespace Website.Rules.Adapters
{
   public class UnitOfWorkAdapter : Tarantino.RulesEngine.IUnitOfWork
   {
      readonly Core.IUnitOfWork _coreUnitOfWork;

      public UnitOfWorkAdapter(Core.IUnitOfWork coreUnitOfWork)
      {
         _coreUnitOfWork = coreUnitOfWork;
      }

      public void Dispose()
      {
         _coreUnitOfWork.Dispose();
      }

      public void Invalidate()
      {
         _coreUnitOfWork.RollBack();
      }
   }
}