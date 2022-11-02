using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelMove : MonoBehaviour
{
    public Rigidbody barrel;
    public bool isMovingRight;
    float speed;
    bool prev;
    public bool isActive= false;
    // Start is called before the first frame update
    void Start()
    {
        isMovingRight = true;
        prev = true;
    }

    // Update is called once per frame
    void Update()
    {
        speed = (float)3 * Time.deltaTime;
        if (isActive)
        {
            if (isMovingRight)
            {
                MoveRight(speed);
            }
            else
            {
                MoveLeft(speed);
            }

            //if (!barrel.useGravity)
            //{
            //    MoveDown(speed);
            //}
        }
        
    }

    void MoveLeft(float speed)
    {
        barrel.transform.position = new Vector3(barrel.transform.position.x - speed, barrel.transform.position.y, barrel.transform.position.z);
    }

    void MoveRight(float speed)
    {
        barrel.transform.position = new Vector3(barrel.transform.position.x + speed, barrel.transform.position.y, barrel.transform.position.z);
    }

    void MoveDown(float speed)
    {
        barrel.transform.position = new Vector3(barrel.transform.position.x, barrel.transform.position.y - speed, barrel.transform.position.z);
    }

}
