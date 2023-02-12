using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Pickup_Behavior : MonoBehaviour
{
    public GameBehavior gameManager;
    
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameBehavior>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            gameManager.HP +=1;
        }
    }
}
