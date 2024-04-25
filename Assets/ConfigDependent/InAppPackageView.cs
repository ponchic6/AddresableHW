using TMPro;
using UnityEngine;

namespace ConfigDependent
{
    public class InAppPackageView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI textMesh;
    
        public int Price { get; set; }

        private void Start()
        {
            textMesh.text = string.Format(textMesh.text, Price.ToString());
        }
    }
}
