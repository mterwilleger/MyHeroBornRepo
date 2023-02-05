using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            Debug.Log("Patron Detected - Initiate Conversation!");
        }
    }


    void OnTriggerExit(Collider other)
    {
        if(other.name == "Player")
        {
            Debug.Log("Patron is out of range, resume Duties");
        }
    }
}
