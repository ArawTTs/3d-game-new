using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class Itemcollect : MonoBehaviour
{
    pickup spider;
    public UnityEvent Event;


    private void Start()
    {
        Event.AddListener(GameObject.FindGameObjectWithTag("scorecounter").GetComponent<pickup>().score);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObject);
            Event.Invoke();
            
        }
    }
}
