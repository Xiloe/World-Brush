using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Paintable : MonoBehaviour
{

    public Brush[] brushes;
    public Brush selectedBrush;

    public Color32[] colors;
    public Color32 selectedColor;

    private GameObject currentObject;

    void Start()
    {
        
    }

    void Update()
    {
        if (selectedBrush != null)
        {
            if (Input.GetMouseButton(0))
            {
                var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(Ray, out hit))
                {
                    if (!isPointerOverUIObject())
                    {
                        selectedBrush.brushPrefab.gameObject.GetComponent<Renderer>().material.color = selectedBrush.brushColor;
                        var paint = Instantiate(selectedBrush.brushPrefab, hit.point, Quaternion.identity, transform.parent.parent);
                        paint.transform.localScale = Vector3.one * selectedBrush.BrushSize;
                        paint.GetComponent<Renderer>().material.color = selectedColor;
                    }
                }
            }
        }
    }

    public void onSelectBrush()
    {
        currentObject = EventSystem.current.currentSelectedGameObject;

        for (int i = 0; i < brushes.Length; i++)
        {
            if (currentObject != null)
            {
                if (i.ToString() == currentObject.transform.parent.name)
                {
                    selectedBrush = brushes[i];
                }
            }
        }
    }

    public void onSelectColor()
    {
        currentObject = EventSystem.current.currentSelectedGameObject;

        for (int i = 0; i < colors.Length; i++)
        {
            if (currentObject != null)
            {
                if (i.ToString() == currentObject.transform.parent.name)
                {
                    selectedColor = colors[i];
                }
            }
        }
    }

    // Some Indian code to prevent drawing when touching UI elements.
    private bool isPointerOverUIObject()
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }
}
