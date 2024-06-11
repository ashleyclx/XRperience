using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterParticleCollision : MonoBehaviour
{
    [SerializeField]
    GameObject InactiveFire;
    [SerializeField]
    GameObject ActiveFire;

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("Water Collided with Campfire!");
        InactiveFire.SetActive(true);
        ActiveFire.SetActive(false);
    }
}
