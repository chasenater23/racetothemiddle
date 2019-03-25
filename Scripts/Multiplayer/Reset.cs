using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour { 

 [SerializeField]Transform spawnPoint;

    void OnTriggerEnter2D(Collider2D kill)
    {
        Debug.Log("Hello World");
        {
            if (kill.gameObject.tag == "Player")
            {
                kill.transform.position = spawnPoint.transform.position;
            }
        }
    }
}   
