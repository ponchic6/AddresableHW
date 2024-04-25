using System.Threading.Tasks;
using StaticData;

namespace Services
{
    public interface IAssetProvider
    {
        public PlayerConfig PlayerConfig { get; }
        public InAppPackageConfig InAppPackageViewConfig { get; }
        public Task LoadConfigsAssync();
    }
}