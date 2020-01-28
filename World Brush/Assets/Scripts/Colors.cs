using UnityEngine;
using UnityEngine.UI;

public class Colors : MonoBehaviour
{
    
    public GameObject previewObject;
    public Paintable paintableObject;

    void Update()
    {
        previewObject.GetComponent<Image>().color = paintableObject.selectedColor;
    }
}
