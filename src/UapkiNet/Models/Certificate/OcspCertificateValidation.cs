﻿using System;
using Newtonsoft.Json;
using UapkiNet.Enums;
using UapkiNet.Interfaces;

namespace UapkiNet.Models.Certificate
{
    public class OcspCertificateValidation : ICertificateValidation
    {
        [JsonProperty("status")]
        public CertificateStatus Status { get; set; }

        [JsonProperty("revocationReason")]
        public RevocationReason? RevocationReason { get; set; }

        [JsonProperty("revocationTime")]
        public DateTime? RevocationTime { get; set; }

        [JsonProperty("responseStatus")]
        public OcspResponse ResponseStatus { get; set; }

        [JsonProperty("responderId")]
        public string ResponderId { get; set; }

        [JsonProperty("producedAt")]
        public DateTime ProducedAt { get; set; }

        [JsonProperty("thisUpdate")]
        public DateTime ThisUpdate { get; set; }

        [JsonProperty("nextUpdate")]
        public DateTime NextUpdate { get; set; }
    }
}
