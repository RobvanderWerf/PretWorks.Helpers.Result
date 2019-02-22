namespace PretWorks.Helpers.Result.Models
{
    public class FailedResultModel : ResultModel
    {
        public FailedResultModel() : base(false)
        {

        }
    }

    public class FailedResultModel<TValue> : ResultModel<TValue>
    {
        public FailedResultModel() : base(false)
        {

        }
    }
}