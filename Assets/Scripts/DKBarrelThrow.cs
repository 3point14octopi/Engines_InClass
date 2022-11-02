using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommandPattern;

public class DKBarrelThrow : MonoBehaviour
{
    public GameObject barrelPrefab;
    public Invoker invoker;
    public float timer = 14;
    void Start()
    {
        invoker = new Invoker();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 15)
        {
            SpawnBarrel();
            timer = 0;
        }
    }

    public void SpawnBarrel()
    {
        GameObject b = Instantiate(barrelPrefab, new Vector3(-100, -100, -100), Quaternion.identity);
        ICommand comm = new DKBarrelCommand(b);
        invoker.Execute(comm);
    }
}
