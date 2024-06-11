using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FireTutorialSceneToggle : MonoBehaviour
{
    public void LoadFire() {
        SceneManager.LoadScene("FireTutorial");
    }
}