using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    int sceneIndex;

    private void Update()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "XR Origin")
        {
            if (sceneIndex == 0) 
                SceneManager.LoadScene(1);
            else
                SceneManager.LoadScene(0);
        }

    }
}
