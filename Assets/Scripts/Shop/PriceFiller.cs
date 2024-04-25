using System.Collections.Generic;
using ConfigDependent;
using Services;
using UnityEngine;
using Zenject;

namespace Shop
{
    public class PriceFiller : MonoBehaviour
    {
        [SerializeField] private List<InAppPackageView> priceViewList;

        private IAssetProvider _assetProvider;
        
        [Inject]
        public void Constructor(IAssetProvider assetProvider)
        {
            _assetProvider = assetProvider;
        }
        
        private void Awake()
        {
            for (int i = 0; i < priceViewList.Count; i++)
            {
                priceViewList[i].Price = _assetProvider.InAppPackageViewConfig.ShopPrices[i];
            }
        }
    }
}
