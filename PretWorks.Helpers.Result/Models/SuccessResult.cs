
namespace PretWorks.Helpers.Result.Models
{
    public class SuccessResult<TValue> : Result<TValue> 
    {
        public SuccessResult() : base(true)
        {

        }
    }
}