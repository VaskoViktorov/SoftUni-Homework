﻿namespace WebServer.Server.HTTP
{
    using System.Collections.Generic;
    using Common;
    using Enums;
    using Contracts;
    using System;
    using System.Linq;
    using System.Net;
    using Exceptions;

    public class HttpRequest : IHttpRequest
    {
        public HttpRequest(string requestText)
        {
            CoreValidator.ThrowIfNullOrEmpty(requestText,nameof(requestText));

            this.FormData = new Dictionary<string, string>();
            this.QueryParameters = new Dictionary<string, string>();
            this.UrlParameters = new Dictionary<string, string>();
            this.Headers = new HttpHeaderCollection();

            this.ParceRequest(requestText);
        }

        public IDictionary<string, string> FormData { get; private set; }

        public HttpHeaderCollection Headers { get; private set; }

        public string Path { get; private set; }

        public IDictionary<string, string> QueryParameters { get; private set; }

        public HttpRequestMethod Method { get; private set; }

        public string Url { get; private set; }

        public IDictionary<string, string> UrlParameters { get; private set; }

        public void AddUrlParameter(string key, string value)
        {
            CoreValidator.ThrowIfNullOrEmpty(key, nameof(key));
            CoreValidator.ThrowIfNullOrEmpty(value, nameof(value));

            this.UrlParameters[key] = value;
        }

        private void ParceRequest(string requestText)
        {
            var requestLines = requestText.Split(Environment.NewLine);

            if (!requestLines.Any())
            {
                BadRequestException.ThrowFromInvalidRequest();
            }
            var requestLine = requestLines.First().Split(
                new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        
            if (requestLine.Length != 3 || requestLine[2].ToLower() != "http/1.1")
            {
                BadRequestException.ThrowFromInvalidRequest();
            }

            this.Method = this.ParseMethod(requestLine.First());
            this.Url = requestLine[1];
            this.Path = this.ParsePath(this.Url);
            this.ParseHeaders(requestLines);
            this.ParseParameters();
            this.ParseFormData(requestLines.Last());
        }

        private HttpRequestMethod ParseMethod(string method)
        {

            HttpRequestMethod parsedMethod;
            if (!Enum.TryParse<HttpRequestMethod>(method, true, out parsedMethod))
            {
                BadRequestException.ThrowFromInvalidRequest();
            }

            return parsedMethod;
        }

        private string ParsePath(string url)
        => url.Split(new[] {'?', '#'}, StringSplitOptions.RemoveEmptyEntries)[0];

        private void ParseHeaders(string[] requestLines)
        {
            var emptyLineAfterHeaderIndex = Array.IndexOf(requestLines, string.Empty);

            for (int i = 1; i < emptyLineAfterHeaderIndex; i++)
            {
                var currentLine = requestLines[i];
                var headerParts = currentLine.Split(new[] {": "}, StringSplitOptions.RemoveEmptyEntries);

                if (headerParts.Length != 2)
                {
                    BadRequestException.ThrowFromInvalidRequest();
                }

                var headerKey = headerParts[0];
                var headerValue = headerParts[1].Trim();
                var header = new HttpHeader(headerKey, headerValue);

                this.Headers.Add(header);
            }

            if (!this.Headers.ContainsKey("Host"))
            {
                BadRequestException.ThrowFromInvalidRequest();
            }
        }

        private void ParseParameters()
        {
            if (!this.Url.Contains('?'))
            {
                return;
            }
            var query = this.Url
                .Split(new[] { '?' }, StringSplitOptions.RemoveEmptyEntries).Last();

            this.ParseQuery(query, this.UrlParameters);
        }

        private void ParseFormData(string formDataLine)
        {
            if (this.Method == HttpRequestMethod.Get)
            {
                return;               
            }

           this.ParseQuery(formDataLine, this.QueryParameters);
        }

        private void ParseQuery(string query, IDictionary<string,string> dict)
        {          

            if (!query.Contains('='))
            {
                return;
            }

            var queryPairs = query.Split(new[] { '&' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var queryPair in queryPairs)
            {
                var queryKvp = queryPair.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                if (queryKvp.Length != 2)
                {
                    return;
                }

                var queryKey = WebUtility.UrlDecode(queryKvp[0]);
                var queryValue = WebUtility.UrlDecode(queryKvp[1]);

                dict.Add(queryKey, queryValue);
                this.FormData.Add(queryKey,queryValue);
            }
        }
    }
}
