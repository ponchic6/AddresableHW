using System.Threading.Tasks;
using StaticData;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Services
{
    public class AssetProvider : IAssetProvider
    {
        private InAppPackageConfig _inAppPackageView;
        private PlayerConfig _playerConfig;
        
        public InAppPackageConfig InAppPackageViewConfig => _inAppPackageView;
        public PlayerConfig PlayerConfig => _playerConfig;
        
        public async Task LoadConfigsAssync()
        {
            AsyncOperationHandle<PlayerConfig> playerConfigHandle = Addressables.LoadAssetAsync<PlayerConfig>("PlayerConfig");
            AsyncOperationHandle<InAppPackageConfig> AppPacageViewHandle = Addressables.LoadAssetAsync<InAppPackageConfig>("InAppPackageView");
            
            await playerConfigHandle.Task;
            await AppPacageViewHandle.Task;

            if (playerConfigHandle.Status == AsyncOperationStatus.Succeeded)
            {
                _playerConfig = playerConfigHandle.Result;
                Addressables.Release(playerConfigHandle);
            }
            
            if (AppPacageViewHandle.Status == AsyncOperationStatus.Succeeded)
            {
                _inAppPackageView = AppPacageViewHandle.Result;
                Addressables.Release(AppPacageViewHandle);
            }
        }
    }
}