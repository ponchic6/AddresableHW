using System.Threading.Tasks;
using Factories;
using Services;
using UnityEngine;
using Zenject;

namespace Infrastructure
{
    public class AppStartUp : MonoBehaviour
    {
        private IUIFactory _uiFactory;
        private IPlayerFactory _playerFactory;
        private IAssetProvider _assetProvider;

        [Inject]
        public void Constructor(IUIFactory uiFactory, IPlayerFactory playerFactory, IAssetProvider assetProvider)
        {
            _assetProvider = assetProvider;
            _playerFactory = playerFactory;
            _uiFactory = uiFactory;
        }
        
        private async void Start()
        {
            await _assetProvider.LoadConfigsAssync();
            _uiFactory.CreateShop();
            _playerFactory.CreatePlayer();
        }
    }
}