using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class pickup : MonoBehaviour
{
    public TextMeshProUGUI point;
    
    
    int Pickup;

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
    }
}
