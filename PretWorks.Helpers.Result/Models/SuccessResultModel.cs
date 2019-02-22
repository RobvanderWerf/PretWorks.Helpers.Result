
namespace PretWorks.Helpers.Result.Models
{
    public class SuccessResultModel : ResultModel
    {
        public SuccessResultModel() : base(true)
        {

        }
    }

    public class SuccessResultModel<TValue> : ResultModel<TValue> 
    {
        public SuccessResultModel() : base(true)
        {

        }
    }
}