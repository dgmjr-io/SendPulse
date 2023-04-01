/*
 * DI.cs
 *
 *   Created: 2022-12-05-10:27:04
 *   Modified: 2022-12-05-10:27:05
 *
 *   Author:  <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 , All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Microsoft.Extensions.DependencyInjection;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SendPulse.Api;
using SendPulse.Api.Abstractions;
using SendPulse.Api.Client;

public static class DI
{
    public static WebApplicationBuilder AddSendPulseApi(this WebApplicationBuilder builder)
    {
        var config = new Configuration { BasePath = Configuration.Default.BasePath };
        builder.Configuration.GetSection("SendPulse").Bind(config);
        return builder.AddSendPulseApi(config);
    }

    public static WebApplicationBuilder AddSendPulseApi(
        this WebApplicationBuilder builder,
        string accessToken
    )
    {
        builder.AddSendPulseApi(new Configuration { AccessToken = accessToken });
        return builder;
    }

    public static WebApplicationBuilder AddSendPulseApi(
        this WebApplicationBuilder builder,
        string clientId,
        string clientSecret
    )
    {
        builder.AddSendPulseApi(
            new Configuration { ClientId = clientId, ClientSecret = clientSecret }
        );
        return builder;
    }

    public static WebApplicationBuilder AddSendPulseApi(
        this WebApplicationBuilder builder,
        Configuration config
    )
    {
        builder.Services.AddSingleton(config);
        builder.Services.AddTransient<SendPulse.Api.Client.Abstractions.IApiClient>(
            y => y.GetService<Configuration>().CreateApiClient()
        );
        builder.Services.AddTransient<SendPulse.Api.Abstractions.IAccountApi>(
            y => new AccountApi(y.GetService<Configuration>())
        );
        builder.Services.AddTransient<SendPulse.Api.Abstractions.IBotsApi>(
            y => new BotsApi(y.GetService<Configuration>())
        );
        builder.Services.AddTransient<SendPulse.Api.Abstractions.IChatsApi>(
            y => new ChatsApi(y.GetService<Configuration>())
        );
        builder.Services.AddTransient<SendPulse.Api.Abstractions.IFlowsApi>(
            y => new FlowsApi(y.GetService<Configuration>())
        );
        builder.Services.AddTransient<SendPulse.Api.Abstractions.IContactsApi>(
            y => new ContactsApi(y.GetService<Configuration>())
        );
        builder.Services.AddTransient<SendPulse.Api.Abstractions.ITriggersApi>(
            y => new TriggersApi(y.GetService<Configuration>())
        );
        builder.Services.AddTransient<SendPulse.Api.Abstractions.ICampaignsApi>(
            y => new CampaignsApi(y.GetService<Configuration>())
        );
        builder.Services.AddTransient<SendPulse.Api.Abstractions.IVariablesApi>(
            y => new VariablesApi(y.GetService<Configuration>())
        );
        builder.Services.AddTransient<SendPulse.Api.Abstractions.ISendPulseApi, SendPulseApi>();
        return builder;
    }
}
