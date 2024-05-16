using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class convo : MonoBehaviour
{
    public GameObject text;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            text.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            text.SetActive(false);
        }
    }
}

