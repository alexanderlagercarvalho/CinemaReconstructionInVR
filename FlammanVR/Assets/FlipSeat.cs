using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using Photon.Pun;

public class FlipSeat : MonoBehaviour
{
    PhotonView photonView;
    public GameObject seat;
    public MeshCollider seatMeshChecker;
    private bool seatFolded;
    private Vector3 startRotation = new Vector3(80, 0, 0);
    private Vector3 stopRotation = new Vector3(-80, 0, 0);
    private Vector3 up = new Vector3(-0.092022419f,1.67871296f,-0.806179047f);
    private Vector3 down = new Vector3(-0.092022419f,2.9000001f+3f,-0.0700000003f+2f);
    private Vector3 foldedSeatOffset;
    //private Vector3 up = new Vector3(-0.092022419f, 2.51206064f, -0.00858958811f);
    //private Vector3 down = new Vector3(-0.092022419f, 1.67999995f, -0.467000008f);

    public void Start()
    {
        photonView = GetComponent<PhotonView>();
        seatFolded = true;
        seat.GetComponent<TeleportationAnchor>().enabled = false;
        seatMeshChecker.enabled = false;
        foldedSeatOffset = (up - down) / 5;
    }


    [PunRPC]
    public void changeMass()
    {
        seatFolded = !seatFolded;
        Transform transform = seat.GetComponent<Transform>();
        if (seatFolded)
        {
            foldSeat();
        }
        else
        {
            unfoldSeat();
        }
    }

    private void unfoldSeat()
    {
        seat.GetComponent<Transform>().Rotate(stopRotation);
        transform.localPosition = transform.localPosition + foldedSeatOffset;
        seat.GetComponent<TeleportationAnchor>().enabled = true;
        seatMeshChecker.enabled = true;
    }

    private void foldSeat()
    {
        seat.GetComponent<Transform>().Rotate(startRotation);
        transform.localPosition = transform.localPosition - foldedSeatOffset;
        seat.GetComponent<TeleportationAnchor>().enabled = false;
        seatMeshChecker.enabled = false;
    }
    public void changeMassRPC()
    {
        photonView.RPC("changeMass", RpcTarget.All);
    }
}
