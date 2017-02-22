using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Models
{
    public interface IAssetDao
    {
        Asset getAsset(string serialNumber);
        IEnumerable<string> getAll();
        void setAsset(string serialNumber, Asset asset);
    }
}
