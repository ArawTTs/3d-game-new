using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class pickup : MonoBehaviour
{
    public TextMeshProUGUI point;
    public GameObject scene;
    
    int Pickup;

    private void Start()
    {
        Pickup = PlayerPrefs.GetInt("pick");
        Debug.Log("Pickup: "+ PlayerPrefs.GetInt("pick"));
    }
    void Update()
    {
        Scorepoint();
        
    }

    private void Scorepoint()
    {
        point.text = Pickup.ToString();

    }

    public void score()
    {
        Pickup++;

        if (Pickup == 5)
            scene.SetActive(true);
    }

    private void OnDisable()
    {
        SaveItems();
    }

    private void OnApplicationQuit()
    {

        PlayerPrefs.SetInt("pick", 0);
        Pickup = PlayerPrefs.GetInt("pick");
    }

    public void SaveItems()
    {
        PlayerPrefs.SetInt("pick",Pickup);
        Debug.Log("Pickup: " + Pickup);
    }
}
