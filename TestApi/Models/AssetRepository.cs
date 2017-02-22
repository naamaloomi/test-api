using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Models
{
    public class AssetRepository : IAssetRepository
    {
        private readonly IAssetDao _assetDao;

        public AssetRepository(IAssetDao assetDao)
        {
            _assetDao = assetDao;
        }
        public void Add(string serialNumber, Asset asset)
        {
            _assetDao.setAsset(serialNumber, asset);
        }

        public Asset Find(string serialNumber)
        {
            return _assetDao.getAsset(serialNumber);
        }

        public IEnumerable<string> GetAll()
        {
            return _assetDao.getAll();
        }

        public void Remove(string serialNumber)
        {
            throw new NotImplementedException();
        }

        public void Update(string serialNumber)
        {
            throw new NotImplementedException();
        }
    }
}
