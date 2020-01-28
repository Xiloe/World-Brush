using UnityEngine;

[CreateAssetMenu(fileName = "Brush", menuName = "ScriptableObjects/Brush", order = 1)]
public class Brush : ScriptableObject
{
    public string brushName;

    public GameObject brushPrefab;

    public float BrushSize = 0.1f;

    public Color32 brushColor;
}
