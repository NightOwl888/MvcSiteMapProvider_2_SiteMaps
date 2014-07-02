using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcSiteMapProvider.Caching;

namespace MvcSiteMapProvider_2_SiteMaps
{
    public class CustomSiteMapCacheKeyToBuilderSetMapper
        : ISiteMapCacheKeyToBuilderSetMapper
    {
        public virtual string GetBuilderSetName(string cacheKey)
        {
            switch (cacheKey)
            {
                case "sitemap://www.somewhere.com/":
                    return "somewhereSet";
                case "sitemap://www.nowhere.com/":
                    return "nowhereSet";
                default:
                    return "somewhereSet";
            }
        }
    }
}