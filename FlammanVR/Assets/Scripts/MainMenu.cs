using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
   


    // Start is called before the first frame update
    public void StartMultiplayer()
    {
        SceneManager.LoadScene("LoadingMultiplayerScene");
    }
  public void StartSinglePlayer()
    {
        SceneManager.LoadScene("Lobbyscene");
    }
  public void ExitGame()
    {
        Application.Quit();
    }
  

}
