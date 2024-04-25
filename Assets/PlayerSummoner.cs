using Factories;
using UnityEngine;
using Zenject;

public class PlayerSummoner : MonoBehaviour
{
    private IPlayerFactory _playerFactory;
    
    [Inject]
    public void Constructor(IPlayerFactory playerFactory)
    {
        _playerFactory = playerFactory;
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            _playerFactory.CreatePlayer();
        }
    }
}
