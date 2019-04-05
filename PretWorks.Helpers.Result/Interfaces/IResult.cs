using System;
using System.Collections.Generic;

namespace PretWorks.Helpers.Result.Interfaces
{
    public interface IResult
    {
        /// <summary>
        /// Result succeeded
        /// </summary>

        bool Success { get; set; }

        /// <summary>
        /// Result failed
        /// </summary>
        bool Failed { get; set; }

        /// <summary>
        /// Messages
        /// </summary>
        List<string> Messages { get; set; }

        /// <summary>
        /// Messages to string (delimited by space if multiple messages)
        /// </summary>
        string ToString();

        /// <summary>
        /// Messages to multi line string
        /// </summary>
        /// <param name="delimiter"></param>
        /// <returns></returns>
        string ToDelimitedString(string delimiter);

        /// <summary>
        /// Optional keys
        /// </summary>
        Dictionary<string, string> Keys { get; set; }

        Exception Exception { get; set; }
    }

    public interface IResult<TValue> : IResult
    {
       
        /// <summary>
        /// The result
        /// </summary>
        TValue Value { get; set; }
    }
}