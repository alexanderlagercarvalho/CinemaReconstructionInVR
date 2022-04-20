using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    int sceneIndex;

    private void Start()
    {
        
        //SceneManager.LoadSceneAsync(1);
    }

    private void Update()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // Start is called before the first frame update

    
    public void TPActivate()
    {
        if (sceneIndex == 0)
            SceneManager.LoadScene(1);
        else
            SceneManager.LoadScene(0);
    }
}
