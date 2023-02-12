using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizePickupBehavior : MonoBehaviour
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
            collision.gameObject.transform.localScale += new Vector3(0.75f, 0.75f, 0.75f);
        }
    }
}
