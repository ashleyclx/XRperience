using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ToggleFire : MonoBehaviour

{
    [SerializeField]
    GameObject InactiveFire;

    public ParticleSystem part;
    public List<ParticleCollisionEvent> collisionEvents;

    void Start()
    {
        part = GetComponent<ParticleSystem>();
        collisionEvents = new List<ParticleCollisionEvent>();
    }

    void OnParticleCollision(GameObject other)
    {
        int numCollisionEvents = part.GetCollisionEvents(other, collisionEvents);

        if (numCollisionEvents > 0)
        {
            InactiveFire.SetActive(true);
            this.gameObject.SetActive(false);
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
