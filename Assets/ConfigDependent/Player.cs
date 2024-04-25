using Services;
using UnityEngine;
using Zenject;

namespace ConfigDependent
{
    public class Player : MonoBehaviour
    {
        private float _startingHp;
        private float _startingSpeed;
        private float _startingAttack;
    
        private IAssetProvider _assetProvider;

        [Inject]
        public void Constructor(IAssetProvider assetProvider)
        {
            _assetProvider = assetProvider;
            FillStartParameters();
        }

        private void Update()
        {
            transform.position += transform.forward * _startingSpeed * Time.deltaTime;
        }

        private void FillStartParameters()
        {
            _startingHp = _assetProvider.PlayerConfig.StartingHp;
            _startingSpeed = _assetProvider.PlayerConfig.StartingSpeed;
            _startingAttack = _assetProvider.PlayerConfig.StartingAttack;
        }
    }
}