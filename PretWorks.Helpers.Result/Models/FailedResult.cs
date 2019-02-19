namespace PretWorks.Helpers.Result.Models
{
    public class FailedResult<TValue> : Result<TValue>
    {
        public FailedResult() : base(false)
        {

        }
    }
}