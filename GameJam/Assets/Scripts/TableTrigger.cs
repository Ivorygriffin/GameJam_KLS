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
        if(other.tag == "Player")
        {
            onTrigger.Invoke();
            Debug.Log("triggerrrr");
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            onExit.Invoke();
        }
    }
}
