using Factories;
using Services;
using StaticData;
using UnityEngine;
using Zenject;

public class MainInstaller : MonoInstaller
{
    [SerializeField] private UIStaticData _uiStaticData;
    
    public override void InstallBindings()
    {
        RegisterAssetProvider();
        RegisterStaticData();
        RegisterUIFactory();
        RegisterPlayerFactory();
    }

    private void RegisterAssetProvider()
    {
        IAssetProvider assetProvider = Container.Instantiate<AssetProvider>();
        Container.Bind<IAssetProvider>().FromInstance(assetProvider).AsSingle();
    }

    private void RegisterPlayerFactory()
    {
        IPlayerFactory playerFactory = Container.Instantiate<PlayerFactory>();
        Container.Bind<IPlayerFactory>().FromInstance(playerFactory).AsSingle();
    }

    private void RegisterStaticData()
    {
        Container.Bind<UIStaticData>().FromInstance(_uiStaticData).AsSingle();
    }

    private void RegisterUIFactory()
    {
        IUIFactory uiFactory = Container.Instantiate<UIFactory>();
        Container.Bind<IUIFactory>().FromInstance(uiFactory).AsSingle();
    }
}