﻿using System;
using WebServer.Server.Common;

namespace WebServer.Server.HTTP
{
    using System.Collections.Generic;
    using Contracts;

    public class HttpHeaderCollection : IHttpHeaderCollection
    {
        private readonly Dictionary<string, HttpHeader> headers;

        public HttpHeaderCollection()
        {
            this.headers = new Dictionary<string, HttpHeader>();
        }

        public void Add(HttpHeader header)
        {
            CoreValidator.ThrowIfNull(header, nameof(header));           
            this.headers[header.Key] = header;
        }

        public bool ContainsKey(string key)
        {
            CoreValidator.ThrowIfNull(key, nameof(key));

            return this.headers.ContainsKey(key);
        }

        public HttpHeader GetHeader(string key)
        {
            CoreValidator.ThrowIfNull(key, nameof(key));

            if (!this.headers.ContainsKey(key))
            {
                throw new InvalidOperationException($"The given key {key} is not present in the headers collection.");
            }
            return this.headers[key];
        }

        public override string ToString() => string.Join(Environment.NewLine, this.headers.Values);
    }
}
