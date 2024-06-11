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
        Debug.Log($"Number of collision events: {numCollisionEvents}");

        if (numCollisionEvents > 0)
        {
            Debug.Log($"Collision detected with {other.name}");
            InactiveFire.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGER");
        if (other.tag == "Water")
        {
            Debug.Log("WATER TRIGGER");
            InactiveFire.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("WATER COLLISION");
        InactiveFire.SetActive(false);
        this.gameObject.SetActive(false);
    }
}