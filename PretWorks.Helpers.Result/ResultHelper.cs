using System;
using System.Collections.Generic;
using PretWorks.Helpers.Result.Interfaces;
using PretWorks.Helpers.Result.Models;

namespace PretWorks.Helpers.Result
{
    public static class ResultHelper
    {
        /// <summary>
        /// Create success result
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static IResult<TValue> Success<TValue>()
        {
            return new SuccessResult<TValue>();
        }

        /// <summary>
        /// Create success result with value
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IResult<TValue> Success<TValue>(TValue value)
        {
            return new SuccessResult<TValue>
            {
                Value = value
            };
        }

        /// <summary>
        /// Create success result with value
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static IResult<TValue> Failed<TValue>()
        {
            return new FailedResult<TValue>();
        }

        /// <summary>
        /// Add value to result
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="result"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IResult<TValue> WithValue<TValue>(this IResult<TValue> result, TValue value)
        {
            result.Value = value;

            return result;
        }

        /// <summary>
        /// Add message to result
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="result"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static IResult<TValue> WithMessage<TValue>(this IResult<TValue> result, string message)
        {
            result.Messages.Add(message);

            return result;
        }

        /// <summary>
        /// Add multiple message to result
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="result"></param>
        /// <param name="messages"></param>
        /// <returns></returns>
        public static IResult<TValue> WithMessages<TValue>(this IResult<TValue> result, List<string> messages)
        {
            result.Messages.AddRange(messages);

            return result;
        }

        /// <summary>
        /// Add key / value to result
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="result"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IResult<TValue> WithKey<TValue>(this IResult<TValue> result, string key, string value)
        {
            result.Keys.Add(key, value);

            return result;
        }

        /// <summary>
        /// With exception
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="result"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static IResult<TValue> WithException<TValue>(this IResult<TValue> result, Exception exception)
        {
            result.Messages.Add(exception.ToString());

            return result;
        }
    }
}