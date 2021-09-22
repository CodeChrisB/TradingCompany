//@GeneratedCode
namespace TradingCompany.Logic.Controllers.Persistence.ItemMaster
{
    sealed partial class ConditionController : GenericPersistenceController<TradingCompany.Contracts.Persistence.ItemMaster.ICondition, Entities.Persistence.ItemMaster.Condition>
    {
        static ConditionController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        internal ConditionController(DataContext.IContext context):base(context)
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        internal ConditionController(ControllerObject controller):base(controller)
        {
            Constructing();
            Constructed();
        }
    }
}
