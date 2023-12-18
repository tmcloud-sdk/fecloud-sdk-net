using System;
using System.Collections.Generic;
using TmCloud.SDK.Core;

namespace TmCloud.SDK.Kms.V2
{
    public class KmsRegion
    {
        public static readonly Region MY_KUALALUMPUR_1 = new Region("my-kualalumpur-1",
            "https://kms.my-kualalumpur-1.alphaedge.tmone.com.my");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("KMS");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>()
        {
                { "my-kualalumpur-1", MY_KUALALUMPUR_1 },
        };

        public static Region ValueOf(string regionId)
        {
            if (string.IsNullOrEmpty(regionId))
            {
                throw new ArgumentNullException(regionId);
            }

            var region = Provider.GetRegion(regionId);
            if (region != null)
            {
                return region;
            }

            if (StaticFields.ContainsKey(regionId))
            {
                return StaticFields[regionId];
            }

            throw new ArgumentException("Unexpected regionId: ", regionId);
        }
    }
}