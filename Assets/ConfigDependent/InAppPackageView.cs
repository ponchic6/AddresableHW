using TMPro;
using UnityEngine;

public class InAppPackageView : MonoBehaviour
{
    [SerializeField] private float price;

    [SerializeField] private TextMeshProUGUI textMesh;

    private void Start()
    {
        textMesh.text = string.Format(textMesh.text, price.ToString());
    }
}
