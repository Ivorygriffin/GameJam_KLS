using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TableTrigger : MonoBehaviour
{
    public UnityEvent onTrigger;
    public UnityEvent onExit;
    
    private void OnTriggerEnter(Collider other)
    {
        if(gameObject.tag == "Player")
        {
            onTrigger.Invoke();
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if(gameObject.tag == "Player")
        {
            onExit.Invoke();
        }
    }
}
