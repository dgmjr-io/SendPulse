/*
 * ISendPulseApi.cs
 *
 *   Created: 2023-03-19-02:53:01
 *   Modified: 2023-08-23-05:38:35
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace SendPulse.Api.Abstractions;

public interface ISendPulseApi
    : IAccountApi,
        IBotsApi,
        ICampaignsApi,
        IChatsApi,
        IContactsApi,
        IFlowsApi,
        ITriggersApi,
        IVariablesApi
{ }
