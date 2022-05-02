using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMovie : MonoBehaviour
{
    public GameObject cinemaScreen;
    // Start is called before the first frame update
    void Start()
    {
        cinemaScreen = GameObject.Find("NewCinemaScreen");
    }

    public void PlayMovie()
    {
        cinemaScreen.GetComponent<WorldSpaceVideo>().StartMovie();
        cinemaScreen.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
        cinemaScreen.GetComponent<Renderer>().material.SetColor("White", Color.white);
    }

}
