using Entity.Models.Base;

namespace Utilities.Helpers.Business
{
    public static class InitializeLogical
    {
        public static void InitializeLogicalState(this object entity)
        {
            if (entity is BaseModel softDeletable)
            {
                softDeletable.IsDeleted = false;
            }
        }
    }
}