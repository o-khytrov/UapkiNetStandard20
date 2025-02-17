﻿using System;
using UapkiNet.Models.Requests.RequestParameters;

namespace UapkiNet.Models.Requests
{
    internal class AddCrlRequest: BaseRequest<AddCrlParameters>
    {
        private const string MethodName = "ADD_CRL";
        public AddCrlRequest(byte[] crlBytes, bool permanent) : base(MethodName)
        {
            Parameters = new AddCrlParameters()
            {
                BytesBase64 = Convert.ToBase64String(crlBytes),
                Permanent = permanent
            };
        }
    }
}
