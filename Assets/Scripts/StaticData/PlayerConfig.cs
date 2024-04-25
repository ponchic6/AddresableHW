using UnityEngine;

namespace StaticData
{   
    [CreateAssetMenu(menuName = "StaticData/PlayerConfig", fileName = "PlayerConfig")]
    public class PlayerConfig : ScriptableObject
    {
        [SerializeField, Range(0f, 100f)] private float startingHP;
        [SerializeField, Range(0f, 10f)] private float startingSpeed;
        [SerializeField, Range(0f, 1f)] private float startingAttack;

        public float StartingHp => startingHP;
        public float StartingSpeed => startingSpeed;
        public float StartingAttack => startingAttack;
    }
}