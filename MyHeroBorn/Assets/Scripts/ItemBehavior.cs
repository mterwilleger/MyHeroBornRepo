using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    public GameBehavior gameManager;

    public AudioSource source;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameBehavior>();
    }
     void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            source.Play();
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.name == "Player")
        {
            source.Stop();
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Destroy(this.transform.parent.gameObject);
            Debug.Log("Item collected!");
            gameManager.Items += 1;
            //Make Bigger
            
            
        }
    }
}
