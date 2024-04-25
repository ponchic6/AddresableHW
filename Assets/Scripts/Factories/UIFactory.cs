using System.Threading.Tasks;
using StaticData;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using Zenject;

namespace Factories
{
    public class UIFactory : IUIFactory
    {
        private readonly DiContainer _diContainer;
        private readonly UIStaticData _uiStaticData;

        private GameObject _canvas;
        private GameObject _shop;

        public UIFactory(DiContainer diContainer, UIStaticData uiStaticData)
        {
            _diContainer = diContainer;
            _uiStaticData = uiStaticData;
        }
        
        public async void CreateShop()
        {
            if (_canvas == null)
                await CreateCanvas();
            
            AsyncOperationHandle<GameObject> shopHandle = _uiStaticData.Shop.LoadAssetAsync<GameObject>();
            
            await shopHandle.Task;

            if (shopHandle.Status == AsyncOperationStatus.Succeeded)
            {
                GameObject shopPrefab = shopHandle.Result;
                _shop = _diContainer.InstantiatePrefab(shopPrefab, _canvas.transform);
                _canvas.GetComponent<ShopOpener>().Shop = _shop;
                Addressables.Release(shopHandle);
            }
        }

        private async Task CreateCanvas()
        {
            AsyncOperationHandle<GameObject> canvasHandle = _uiStaticData.Canvas.LoadAssetAsync<GameObject>();
            
            await canvasHandle.Task;

            if (canvasHandle.Status == AsyncOperationStatus.Succeeded)
            {
                GameObject canvasPrefab = canvasHandle.Result;
                _canvas = _diContainer.InstantiatePrefab(canvasPrefab);
                Addressables.Release(canvasHandle);
            }
        }
    }
}