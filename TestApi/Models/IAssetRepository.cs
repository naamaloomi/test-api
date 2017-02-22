using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Models
{
    public interface IAssetRepository
    {
        void Add(string serialNumber, Asset asset);
        IEnumerable<string> GetAll();
        Asset Find(string serialNumber);
        void Remove(string serialNumber);
        void Update(string serialNumber);
    }
}
