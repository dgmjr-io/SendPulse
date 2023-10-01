/*
 * SendPulseApiHealthCheck.cs
 *
 *   Created: 2023-01-03-06:58:58
 *   Modified: 2023-01-03-06:58:59
 *
 *   Author:  <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 , All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace SendPulse.Api.HealthCheck;

using Microsoft.Extensions.Diagnostics.HealthChecks;
using SendPulse.Api.Abstractions;

public class SendPulseApiHealthCheck : IHealthCheck
{
    private readonly ISendPulseApi _sendPulseApi;

    public SendPulseApiHealthCheck(ISendPulseApi sendPulseApi)
    {
        _sendPulseApi = sendPulseApi;
    }

    public async Task<HealthCheckResult> CheckHealthAsync(
        HealthCheckContext context,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            var result = await _sendPulseApi.AccountGetAsync();
            return (result.Success ?? false)
                ? HealthCheckResult.Healthy()
                : HealthCheckResult.Unhealthy();
        }
        catch (Exception ex)
        {
            return HealthCheckResult.Unhealthy(ex.Message);
        }
    }
}
