﻿using System.Text.Json.Serialization;

namespace Fina.Core.Responses
{
    public class Response<TData>
    {
        private int _code = Configuration.DefaultStatusCode;

        [JsonConstructor]
        public Response()
            => _code = Configuration.DefaultStatusCode;

        public Response(
            TData? data,
            int code = Configuration.DefaultStatusCode,
            string? message = null)
        {
            Data = data;
            _code = code;
            Message = message;
        }

        [JsonIgnore]
        public bool IsSuccess => _code is >= 200 || _code is <= 299;

        public string? Message { get; set; }
        public TData? Data { get; set; }
    }
}
