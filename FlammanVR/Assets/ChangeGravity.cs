using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChangeGravity : MonoBehaviour
{
    public GameObject seat;
    public MeshCollider seatMeshChecker;
    private bool gravityActive = false;
    private Vector3 startRotation = new Vector3(80, 0, 0);
    private Vector3 stopRotation = new Vector3(-80, 0, 0);
    private Vector3 up = new Vector3(-0.092022419f,1.67871296f+0.5f,-0.806179047f+1.3f);
    private Vector3 down = new Vector3(-0.092022419f,2.9000001f,-0.0700000003f);
    // Start is called before the first frame update

    public void Start()
    {
        seat.GetComponent<TeleportationAnchor>().enabled = false;
        seatMeshChecker.enabled = false;
    }


    public void changeMass()
    {
        Vector3 testVector = (up - down)/5;
        gravityActive = !gravityActive;
        Transform transform = seat.GetComponent<Transform>();
        if (!gravityActive)
        {
            seat.GetComponent<Transform>().Rotate(startRotation);
            transform.position = transform.position - testVector;
            seat.GetComponent<TeleportationAnchor>().enabled = false;
            seatMeshChecker.enabled = false;
        }
        else
        {
            seat.GetComponent<Transform>().Rotate(stopRotation);
            transform.position = transform.position + testVector;
            seat.GetComponent<TeleportationAnchor>().enabled = true;
            seatMeshChecker.enabled = true;
        }
    }
}
