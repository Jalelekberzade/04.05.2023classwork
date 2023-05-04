using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void OnTriggerEnter (Collider collision)
    {
        Debug.Log("TriggerEnter");
    }
    void OnTriggerStay(Collider collision)
    {
        Debug.Log("TriggerStay");
    }
    void OnTriggerExit (Collider collision)
    {
        Debug.Log("TriggerExit");
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("CollisionEnter");
    }
    void OnCollisionStay(Collision other)
    {
        Debug.Log("CollisionStay");
    }
    void OnCollisionExit(Collision other)
    {
        Debug.Log("CollisionExit");
    }
}
