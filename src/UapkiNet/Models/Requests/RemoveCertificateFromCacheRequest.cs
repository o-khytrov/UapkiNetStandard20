﻿using UapkiNet.Models.Requests.RequestParameters;

namespace UapkiNet.Models.Requests
{
    internal class RemoveCertificateFromCacheRequest: BaseRequest<CertificateIdParameters>
    {
        private const string MethodName = "REMOVE_CERT";
        public RemoveCertificateFromCacheRequest(string certificateId) : base(MethodName)
        {
            Parameters = new CertificateIdParameters()
            {
                CertificateIdBase64 = certificateId
            };
        }
    }
}
