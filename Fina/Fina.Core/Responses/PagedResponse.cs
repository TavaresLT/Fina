﻿using Fina.Core.Models;
using System.Text.Json.Serialization;

namespace Fina.Core.Responses
{
    public abstract class PagedResponse<TData> : Response<TData>
    {
        [JsonConstructor]
        protected PagedResponse(
            TData? data,
            int totalCount,
            int currentPage,
            int pageSize = Configuration.DefaultPageSize)
            : base(data)
        {
            Data = data;
            TotalCount = totalCount; 
            CurrentPage = currentPage;
            PageSize = pageSize;
        }

        public PagedResponse(
            TData? data,
            int code = Configuration.DefaultStatusCode,
            string? message = null)
            : base(data, code, message)
        {
        }

        public int CurrentPage { get; set; } = Configuration.DefaultPageNumber;
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);

        public int PageSize { get; set; } = Configuration.DefaultPageSize;
        public int TotalCount { get; set; }
    }
}
