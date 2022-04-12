using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FlipSeat : MonoBehaviour
{
    public GameObject seat;
    public MeshCollider seatMeshChecker;
    private bool seatFolded;
    private Vector3 startRotation = new Vector3(80, 0, 0);
    private Vector3 stopRotation = new Vector3(-80, 0, 0);
    private Vector3 up = new Vector3(-0.092022419f,1.67871296f+0.5f,-0.806179047f+1.3f);
    private Vector3 down = new Vector3(-0.092022419f,2.9000001f,-0.0700000003f);
    private Vector3 foldedSeatOffset;

    public void Start()
    {
        seatFolded = true;
        seat.GetComponent<TeleportationAnchor>().enabled = false;
        seatMeshChecker.enabled = false;
        foldedSeatOffset = (up - down) / 5;
    }


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
        transform.position = transform.position + foldedSeatOffset;
        seat.GetComponent<TeleportationAnchor>().enabled = true;
        seatMeshChecker.enabled = true;
    }

    private void foldSeat()
    {
        seat.GetComponent<Transform>().Rotate(startRotation);
        transform.position = transform.position - foldedSeatOffset;
        seat.GetComponent<TeleportationAnchor>().enabled = false;
        seatMeshChecker.enabled = false;
    }
}
