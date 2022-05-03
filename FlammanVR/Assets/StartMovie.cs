using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class StartMovie : MonoBehaviour
{
    private PhotonView photonView;
    public GameObject cinemaScreen;
    // Start is called before the first frame update
    void Start()
    {
        cinemaScreen = GameObject.Find("NewCinemaScreen");
    }

    [PunRPC]
    public void PlayMovie()
    {
        cinemaScreen.GetComponent<WorldSpaceVideo>().StartMovie();
        cinemaScreen.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
        cinemaScreen.GetComponent<Renderer>().material.SetColor("White", Color.white);
    }
   public void PlayMovieRPC()
    {
        photonView.RPC("PlayMovie", RpcTarget.All);
    }

}
