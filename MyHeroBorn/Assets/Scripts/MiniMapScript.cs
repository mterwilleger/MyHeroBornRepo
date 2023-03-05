using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapScript : MonoBehaviour
{

    public Transform target;
    void LateUpdate()
    {
        target = GameObject.Find("Player").transform;
        Vector3 newPosition = target.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;

        transform.rotation = Quaternion.Euler(90f, target.eulerAngles.y, 0f);
    }
}
