using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    void Start()
    {
       List<GameObject> oyunObyektleri = GameObject.FindGameObjectsWithTag("Collectable").ToList();
        foreach (var obyekt in oyunObyektleri)
            obyekt.gameObject.tag = "Collected";
    }
    void Update()
    {
        
    }
    
}
