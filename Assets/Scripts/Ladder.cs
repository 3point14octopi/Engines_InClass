using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        other.attachedRigidbody.useGravity = false;
        if (other.GetComponent<BarrelMove>())
        {
            other.GetComponent<BarrelMove>().isMovingRight = !other.GetComponent<BarrelMove>().isMovingRight;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.attachedRigidbody.useGravity = true;
    }
}
