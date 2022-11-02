using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace CommandPattern
{
    public class DKBarrelCommand : ICommand {
        public GameObject newBarrel;

        public DKBarrelCommand(GameObject nb)
        {
            newBarrel = nb;
        }
        public void Execute()
        {
            newBarrel.GetComponent<BarrelMove>().isActive = true;
            newBarrel.GetComponent<Rigidbody>().transform.position = new Vector3(-3, 6, (float)1.2);
        }

        public void ExecuteUndo()
        {
            newBarrel.GetComponent<BarrelMove>().isActive = false;
            newBarrel.GetComponent<Rigidbody>().transform.position = new Vector3(-100, -100, -100);
        }
    }
}
