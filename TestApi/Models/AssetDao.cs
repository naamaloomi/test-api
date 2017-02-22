using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Models
{
    public class AssetDao : IAssetDao
    {
        private Dictionary<string, Asset> database;

        public Asset getAsset(string serialNumber)
        {
            Asset asset = null;
            database.TryGetValue(serialNumber, out asset);
            return asset;
        }

        public IEnumerable<string> getAll()
        {
            return database.Keys;
        }

        public void setAsset(string serialNumber, Asset asset)
        {
            database[serialNumber] = asset;
        }
    }
}
