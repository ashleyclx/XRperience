using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ToggleFire : MonoBehaviour

{
    [SerializeField]
    GameObject InactiveFire;
    [SerializeField]
    GameObject ActiveFire;

    public int numHits = 0;

    void OnParticleCollision(GameObject other)
    {
        numHits++;
        Debug.Log("COLLISION");
        if (numHits > 10)
        {
            InactiveFire.SetActive(true);
            ActiveFire.SetActive(false);
        }
    }
        /*private void OnTriggerEnter(Collider other)
        {
            Console.WriteLine("TRIGGER");
            if (other.tag == "Water")
            {
                Console.WriteLine("WATER TRIGGER");
                InactiveFire.SetActive(true);
                this.gameObject.SetActive(false);
            }

        }

        private void OnCollisionEnter(Collision collision)
        {

            Console.WriteLine("WATER COLLISION");
            InactiveFire.SetActive(true);
            this.gameObject.SetActive(false);

        }*/
}
