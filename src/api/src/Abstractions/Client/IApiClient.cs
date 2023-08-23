/*
 * IApiClient.cs
 *
 *   Created: 2023-03-19-02:53:01
 *   Modified: 2023-08-23-05:39:53
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

#pragma warning disable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RestSharp;
using SendPulse.Api.Abstractions;

namespace SendPulse.Api.Client.Abstractions;

public interface IApiClient
{
    ITokenClient TokenClient { get; set; }
    IReadOnlyConfiguration Configuration { get; set; }
    RestClient RestClient { get; set; }

    object CallApi(
        string path,
        Method method,
        List<KeyValuePair<string, string>> queryParams,
        object postBody,
        StringDictionary headerParams,
        StringDictionary formParams,
        Dictionary<string, FileParameter> fileParams,
        StringDictionary pathParams,
        string contentType,
        bool callTokenClient = true
    );
    Task<object> CallApiAsync(
        string path,
        Method method,
        List<KeyValuePair<string, string>> queryParams,
        object postBody,
        StringDictionary headerParams,
        StringDictionary formParams,
        Dictionary<string, FileParameter> fileParams,
        StringDictionary pathParams,
        string contentType,
        bool callTokenClient = true
    );
    object Deserialize(RestResponse response, Type type);
    string EscapeString(string str);
    bool IsJsonMime(string mime);
    FileParameter ParameterToFile(string name, Stream stream);
    FileParameter ParameterToFile(string name, byte[] stream);
    IEnumerable<KeyValuePair<string, string>> ParameterToKeyValuePairs(
        string collectionFormat,
        string name,
        object value
    );
    string ParameterToString(object obj);
    string SelectHeaderAccept(string[] accepts);
    string SelectHeaderContentType(string[] contentTypes);
    string Serialize(object obj);
}
