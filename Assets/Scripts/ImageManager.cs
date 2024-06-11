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
    private GameObject axePopup;
    [Header("Configuration")]
    [SerializeField]
    private GameObject hooliganPopup;

    // Start is called before the first frame update
    public void hideAllImages() {         
        hosePopup.SetActive(false);
        axePopup.SetActive(false);
        hooliganPopup.SetActive(false);
    }
}
