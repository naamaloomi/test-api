using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Models
{
    public class AssetDao
    {
        private Dictionary<string, Asset> database;

        public Nullable<Asset> getAsset(string serialNumber)
        {
            Asset asset = null;
            database.TryGetValue(serialNumber, out asset);
            return asset;
        }
    }
}
