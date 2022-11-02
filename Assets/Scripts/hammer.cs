using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommandPattern;

public class hammer : MonoBehaviour
{
    public GameObject manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        //this will remove the last barrel thrown by Donkey Kong from the scene
        manager.GetComponent<DKBarrelThrow>().invoker.Undo();
    }
}
