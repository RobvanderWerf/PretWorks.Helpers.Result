namespace PretWorks.Helpers.Result.Models
{
    public class FailedResult : Result
    {
        public FailedResult() : base(false)
        {

        }
    }

    public class FailedResult<TValue> : Result<TValue>
    {
        public FailedResult() : base(false)
        {

        }
    }
}