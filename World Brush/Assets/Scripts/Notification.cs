using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notification : MonoBehaviour
{

    public GameObject notificationObject;
    public GameObject notificationText;

    public void setText(string text)
    {
        notificationText.GetComponent<Text>().text = text;
    }

    public void show()
    {
        notificationObject.transform.gameObject.SetActive(true);
    }

    public void hide()
    {
        notificationObject.transform.gameObject.SetActive(false);
    }
}
