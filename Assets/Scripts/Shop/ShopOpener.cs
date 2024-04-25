using UnityEngine;

public class ShopOpener : MonoBehaviour
{
    public GameObject Shop { get; set; }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Shop.SetActive(!Shop.activeSelf);
        }
    }
}

