using System;
using System.Collections.ObjectModel;
using RestSharp;

namespace SendPulse.Api.Client
{
    public partial class ApiClient
    {
        partial void InterceptResponse(RestRequest request, RestResponse response)
        {
            response.Headers = new ReadOnlyCollection<HeaderParameter>(
                response.Headers.Aggregate<HeaderParameter, IList<HeaderParameter>>(
                    new List<HeaderParameter>(),
                    (existing, @new) =>
                    {
                        var existingMatchingHeaderParameter = existing.FirstOrDefault(
                            ex => ex.Name.Equals(@new.Name, StringComparison.OrdinalIgnoreCase)
                        );
                        if (existingMatchingHeaderParameter != null)
                        {
                            existing.Remove(existingMatchingHeaderParameter);
                            existing.Add(
                                new HeaderParameter(
                                    existingMatchingHeaderParameter.Name,
                                    $"{existingMatchingHeaderParameter.Value};{@new.Value}"
                                )
                            );
                        }
                        else
                            existing.Add(@new);
                        return existing;
                    }
                )
            );
        }
    }
}
