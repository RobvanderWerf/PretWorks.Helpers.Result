
namespace PretWorks.Helpers.Result.Models
{
    public class SuccessResult : Result
    {
        public SuccessResult() : base(true)
        {

        }
    }

    public class SuccessResult<TValue> : Result<TValue> 
    {
        public SuccessResult() : base(true)
        {

        }
    }
}