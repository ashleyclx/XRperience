using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageManager : MonoBehaviour
{
    [Header("Configuration")]
    [SerializeField]
    private GameObject hosePopup;
    [Header("Configuration")]
    [SerializeField]
    private GameObject truckPopup;
    [Header("Configuration")]
    [SerializeField]
    private GameObject extinguisherPopup;

    // Start is called before the first frame update
    public void hideAllImages() {         
        hosePopup.SetActive(false);
        truckPopup.SetActive(false);
        extinguisherPopup.SetActive(false);
    }
}
