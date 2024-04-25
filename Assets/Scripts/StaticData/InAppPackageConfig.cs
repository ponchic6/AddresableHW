using System.Collections.Generic;
using UnityEngine;

namespace StaticData
{       
    [CreateAssetMenu(menuName = "StaticData/InAppPackageConfig", fileName = "InAppPackageConfig")]
    public class InAppPackageConfig : ScriptableObject
    {
        [SerializeField] private List<int> shopPrices;

        public List<int> ShopPrices => shopPrices;
    }
}