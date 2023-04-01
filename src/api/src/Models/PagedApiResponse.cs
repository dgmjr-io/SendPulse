using System;
using System.Text;

namespace SendPulse.Api.Models;

public class PagedApiResponse<TData>
{
    public PagedApiResponse() { }

    public PagedApiResponse(
        bool? success = default,
        TData? data = default,
        PagingData? pagingData = default,
        Links? links = default,
        PagingData meta = default
    )
    {
        Success = success ?? true;
        Data = data;
        PagingData = pagingData ?? meta ?? new PagingData { PageSize = 1, TotalRecords = 1 };
        Links = links ?? new Links { Next = null };
    }

    [JProp("success")]
    public bool Success { get; set; }

    [JProp("data")]
    public TData Data { get; set; }

    [JProp("meta")]
    public PagingData? PagingData { get; set; }

    public Links? Links { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>string presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InlineResponse2008 {\n");
        sb.Append("  Success: ").Append(Success).Append("\n");
        sb.Append("  Data: ").Append(Data).Append("\n");
        sb.Append("  PagingData: ").Append(PagingData).Append("\n");
        sb.Append("  Links: ").Append(Links).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}

public class PagingData
{
    [JProp("total")]
    public int TotalRecords { get; set; }

    [JProp("limit")]
    public int PageSize { get; set; }

    public override string ToString() => $"Total records: {TotalRecords}; page size: {PageSize}";
}

public class Links
{
    public Uri? Next { get; set; }

    public override string ToString() => $"Next: {Next}";
}
