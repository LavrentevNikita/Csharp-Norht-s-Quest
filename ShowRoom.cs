using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowRoom : MonoBehaviour
{

    public GameObject activeRoom;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            activeRoom.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)  
    {
        if (other.CompareTag("Player"))
        {
            activeRoom.SetActive(false);
        }
    }
}
