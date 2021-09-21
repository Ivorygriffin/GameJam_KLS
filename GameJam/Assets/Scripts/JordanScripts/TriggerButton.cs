using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerButton : MonoBehaviour
{
    [Header("Events")]
    [SerializeField] private UnityEvent TriggerEnter, TriggerExit, ButtonEvent;

    [Header("Options")]
    [SerializeField] private bool usesKeyPress;
    [SerializeField] private string keyName;

    [SerializeField] private bool isInTrigger;


    private void Update()
    {
        if (Input.GetButtonDown(keyName) && isInTrigger == true)
        {
            ButtonEvent.Invoke();
            print("DONEIAOFBSV");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (usesKeyPress)
        {
            if(other.tag == "Player")
            {
                isInTrigger = true;
                TriggerEnter.Invoke();
            }
        }

        else
        {
            if (other.tag == "Player")
            {
                TriggerEnter.Invoke();
            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            TriggerExit.Invoke();
            isInTrigger = false;
        }
    }
}
