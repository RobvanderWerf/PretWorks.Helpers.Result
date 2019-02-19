using System.Collections.Generic;
using System.Text;
using PretWorks.Helpers.Result.Interfaces;

namespace PretWorks.Helpers.Result.Models
{
    public class SuccessResult<TValue> : IResult<TValue>
    {
        public bool Success { get; set; } = true;

        public bool Failed { get; set; } = false;

        public List<string> Messages { get; set; } = new List<string>();

        public override string ToString()
        {
            return ToDelimitedString(" ");
        }

        public string ToDelimitedString(string delimiter)
        {
            var builder = new StringBuilder();

            foreach (var message in Messages)
            {
                builder.AppendFormat("{0}{1}", message, delimiter);
            }

            return builder.ToString();
        }

        public Dictionary<string, string> Keys { get; set; } = new Dictionary<string, string>();
        public TValue Value { get; set; }
    }
}