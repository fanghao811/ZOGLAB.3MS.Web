using System.Collections.Generic;
using System.Web.Optimization;

namespace ZOGLAB.S_3MS.Web.Bundling
{
    public class AsIsBundleOrderer : IBundleOrderer
    {
        public IEnumerable<BundleFile> OrderFiles(BundleContext context, IEnumerable<BundleFile> files)
        {
            return files;
        }
    }
}