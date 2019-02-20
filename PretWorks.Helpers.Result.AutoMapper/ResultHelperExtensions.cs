using AutoMapper;
using PretWorks.Helpers.Result.Interfaces;

namespace PretWorks.Helpers.Result.AutoMapper
{
    public static class ResultHelperExtensions
    {
        /// <summary>
        /// Map value to TValue using automapper
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="result"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IResult<TValue> WithMappedValue<TValue>(this IResult<TValue> result, object value)
        {
            result.Value = Mapper.Map<TValue>(result);

            return result;
        }
    }
}