using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody Jumpman;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 2f * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
        {
            Jumpman.transform.position = new Vector3(Jumpman.transform.position.x - speed, Jumpman.position.y, Jumpman.position.z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Jumpman.transform.position = new Vector3(Jumpman.transform.position.x + speed, Jumpman.position.y, Jumpman.position.z);
        }

        if (!Jumpman.useGravity)
        {
            if (Input.GetKey(KeyCode.W))
            {
                Jumpman.transform.position = new Vector3(Jumpman.transform.position.x, Jumpman.position.y + (speed * 5), Jumpman.position.z);
            }
            if (Input.GetKey(KeyCode.S))
            {
                Jumpman.transform.position = new Vector3(Jumpman.transform.position.x, Jumpman.position.y - (speed * 5), Jumpman.position.z);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jumpman.AddForce(new Vector3(0, 200, 0));
            }
        }
       
    }
}
