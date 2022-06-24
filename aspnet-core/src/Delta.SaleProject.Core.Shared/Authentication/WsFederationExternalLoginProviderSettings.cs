﻿using System;
using Abp.Extensions;

namespace Delta.SaleProject.Authentication
{
    public class WsFederationExternalLoginProviderSettings
    {
        public string ClientId { get; set; }
        
        public string Tenant { get; set; }
        
        public string MetaDataAddress { get; set; }
        
        public string Wtrealm { get; set; }
        
        public string Authority { get; set; }

        public bool IsValid()
        {
            return !ClientId.IsNullOrEmpty();
        }
    }
}