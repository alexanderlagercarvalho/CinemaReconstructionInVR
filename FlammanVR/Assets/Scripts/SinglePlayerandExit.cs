using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SinglePlayerandExit : MonoBehaviour
{

    public void SinglePLayerScene()
    {
        Debug.Log("SinglePlayerLoad");
        SceneManager.LoadScene("SinglePlayerScene");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
