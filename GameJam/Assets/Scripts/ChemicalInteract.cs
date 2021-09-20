using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChemicalInteract : MonoBehaviour
{

    public UnityEvent Key1; 
    public UnityEvent Key2;
    public UnityEvent Key3;
    public UnityEvent Key4;
    public UnityEvent Key5;
    public UnityEvent Key6;

    [SerializeField] private UnityEvent hii;

    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Key1.Invoke();
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            Key2.Invoke();
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            Key3.Invoke();
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            Key4.Invoke();
        } 
        if (Input.GetKey(KeyCode.Alpha5))
        {
            Key5.Invoke();
        } 
        if (Input.GetKey(KeyCode.Alpha6))
        {
            Key6.Invoke();
        }
    }
}
