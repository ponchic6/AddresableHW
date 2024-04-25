using UnityEngine;
using UnityEngine.AddressableAssets;

namespace StaticData
{
    [CreateAssetMenu(menuName = "StaticData/UIStaticData", fileName = "UIStaticData")]
    public class UIStaticData : ScriptableObject
    {
        [SerializeField] private AssetReference canvas;
        [SerializeField] private AssetReference shop;

        public AssetReference Canvas => canvas;
        public AssetReference Shop => shop;
    }
}
