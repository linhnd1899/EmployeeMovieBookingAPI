using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace EmployeeMovieBooking.Database.Shared
{
    [ExcludeFromCodeCoverage]
    public class PagedResult<T>
    {
        public const int UpperPageSize = 100;
        public const int DefaultPageSize = 10;
        public const int DefaultPageIndex = 0;

        [JsonConstructor]
        private PagedResult(List<T> items, int pageIndex, int pageSize, int totalCount)
        {
            Items = items;
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalCount = totalCount;
        }

        public List<T> Items { get; }

        public int PageIndex { get; }

        public int PageSize { get; }

        public int TotalCount { get; }

        public bool HasNextPage => (PageIndex + 1) * PageSize < TotalCount;

        public bool HasPreviousPage => PageIndex > DefaultPageIndex;

        public static async Task<PagedResult<T>> CreateAsync(IQueryable<T> query, int pageIndex, int pageSize)
        {
            pageIndex = pageIndex < 0 ? DefaultPageIndex : pageIndex;
            pageSize = pageSize <= 0
                ? DefaultPageSize
                : pageSize > UpperPageSize
                    ? UpperPageSize : pageSize;

            int totalCount = await query.CountAsync();

            int skip = (pageIndex - 1) * pageSize;

            List<T>? items = await query.Skip(skip).Take(pageSize).ToListAsync();

            return new(items, pageIndex, pageSize, totalCount);
        }

        public static PagedResult<T> Create(List<T> items, int pageIndex, int pageSize, int totalCount)
            => new(items, pageIndex, pageSize, totalCount);
    }
}
