using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField, Range(0f, 100f)] private float startingHP;
    [SerializeField, Range(0f, 10f)] private float startingSpeed;
    [SerializeField, Range(0f, 1f)] private float startingAttack;

    private void Update()
    {
        transform.position += transform.forward * startingSpeed * Time.deltaTime;
    }
}
