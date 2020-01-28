using System.Collections;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject colorsTab;
    public GameObject brushTab;
    public GameObject miscTab;

    public Notification notificationCenter;

    private GameObject current = null;

    public void colorSelection()
    {
        if (current == null)
        {
            current = colorsTab;
            colorsTab.transform.gameObject.SetActive(true);
        }else if (current == brushTab)
        {
            current = colorsTab;
            brushTab.transform.gameObject.SetActive(false);
            colorsTab.transform.gameObject.SetActive(true);
        }else if (current == colorsTab)
        {
            if (colorsTab.transform.gameObject.activeSelf == true)
            {
                current = null;
                colorsTab.transform.gameObject.SetActive(false);
            } else
            {
                colorsTab.transform.gameObject.SetActive(true);
            }
        }
    }

    public void brushSelection()
    {
        if (current == null)
        {
            current = brushTab;
            brushTab.transform.gameObject.SetActive(true);
        }else if (current == colorsTab)
        {
            current = brushTab;
            colorsTab.transform.gameObject.SetActive(false);
            brushTab.transform.gameObject.SetActive(true);
        }else if (current == brushTab)
        {
            if (brushTab.transform.gameObject.activeSelf == true)
            {
                current = null;
                brushTab.transform.gameObject.SetActive(false);
            }
            else
            {
                brushTab.transform.gameObject.SetActive(true);
            }
        }
    }

    public void takeSnap()
    {
        // TODO: Do it u fag.
        StartCoroutine(NotAvailableYet("This feature isn't available for now, stay tuned!"));
    }

    public void misc()
    {
        // TODO: Do it u fag.
        StartCoroutine(NotAvailableYet("This feature isn't available for now, stay tuned!"));
    }

    private IEnumerator NotAvailableYet(string text)
    {
        Handheld.Vibrate();
        notificationCenter.setText(text);
        notificationCenter.show();
        yield return new WaitForSeconds(2.0f);
        notificationCenter.hide();
    }
}
