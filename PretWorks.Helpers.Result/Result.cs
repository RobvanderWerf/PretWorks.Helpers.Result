using System;
using System.Collections.Generic;
using PretWorks.Helpers.Result.Interfaces;
using PretWorks.Helpers.Result.Models;

namespace PretWorks.Helpers.Result
{
    public static class Result
    {
        /// <summary>
        /// Create success result
        /// </summary>
        /// <returns></returns>
        public static IResult Success()
        {
            return new SuccessResultModel();
        }

        /// <summary>
        /// Create success result
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static IResult<TValue> Success<TValue>()
        {
            return new SuccessResultModel<TValue>();
        }

        /// <summary>
        /// Create success result with value
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IResult<TValue> Success<TValue>(TValue value)
        {
            return new SuccessResultModel<TValue>
            {
                Value = value
            };
        }

        /// <summary>
        /// Create success result with value
        /// </summary>
        /// <returns></returns>
        public static IResult Failed()
        {
            return new FailedResultModel();
        }

        /// <summary>
        /// Create success result with value
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static IResult<TValue> Failed<TValue>()
        {
            return new FailedResultModel<TValue>();
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
        /// <param name="result"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static IResult WithMessage(this IResult result, string message)
        {
            result.Messages.Add(message);

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
        /// <param name="result"></param>
        /// <param name="messages"></param>
        /// <returns></returns>
        public static IResult WithMessages(this IResult result, List<string> messages)
        {
            result.Messages.AddRange(messages);

            return result;
        }

        /// <summary>
        /// Add multiple message to result
        /// </summary>
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
        /// <param name="result"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IResult WithKey(this IResult result, string key, string value)
        {
            result.Keys.Add(key, value);

            return result;
        }

        /// <summary>
        /// Add key / value to result
        /// </summary>
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
        /// <param name="result"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static IResult WithException(this IResult result, Exception exception)
        {
            result.Exception = exception;
            result.Messages.Add(exception.ToString());

            return result;
        }

        /// <summary>
        /// With exception
        /// </summary>
        /// <param name="result"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static IResult<TValue> WithException<TValue>(this IResult<TValue> result, Exception exception)
        {
            result.Exception = exception;
            result.Messages.Add(exception.ToString());

            return result;
        }
    }
}