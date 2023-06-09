/*
 * ITokenClient.cs
 *
 *   Created: 2022-12-08-04:13:54
 *   Modified: 2022-12-08-04:13:54
 *
 *   This code allows access to the SendPulse Telegram chatbot API
 *
 *   Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 *   Author:  <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 , All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using SendPulse.Api.Client.Abstractions;

namespace SendPulse.Api.Abstractions;

public interface ITokenClient : IApiAccessor
{
    Task<string> GetApiTokenAsync();
}
