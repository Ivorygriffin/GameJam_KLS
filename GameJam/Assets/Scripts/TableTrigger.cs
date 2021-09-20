using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TableTrigger : MonoBehaviour
{
    public UnityEvent onTrigger;
    public GameObject TableZone;
    private void OnTriggerEnter(Collider other)
    {
        if(gameObject.tag == "Player")
        {
            onTrigger.Invoke();
        }
    }

}
