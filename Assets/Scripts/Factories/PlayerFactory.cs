using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using Zenject;

namespace Factories
{
    public class PlayerFactory : IPlayerFactory
    {
        private readonly DiContainer _diContainer;

        public PlayerFactory(DiContainer diContainer)
        {
            _diContainer = diContainer;
        }
        
        public async void CreatePlayer()
        {
            AsyncOperationHandle<GameObject> playerHandle = Addressables.LoadAssetAsync<GameObject>("Player");
            
            await playerHandle.Task;

            if (playerHandle.Status == AsyncOperationStatus.Succeeded)
            {
                GameObject playerPrefab = playerHandle.Result;
                _diContainer.InstantiatePrefab(playerPrefab);
                Addressables.Release(playerHandle);
            }
        }
    }
}