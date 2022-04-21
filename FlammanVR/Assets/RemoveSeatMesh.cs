using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
//using UnityEditor.XR.Interaction.Toolkit;
using UnityEngine;

public class RemoveSeatMesh : MonoBehaviour
{
    public MeshCollider chairSeat;
    public GameObject chair;
   
    private void OnTriggerEnter(Collider other)
    {
        CapsuleCollider collider = (CapsuleCollider) other;
        chairSeat.enabled = false;
        Vector3 rotAmount = chair.GetComponent<Transform>().eulerAngles;
        rotAmount.y += 180;
        collider.GetComponent<Transform>().rotation = Quaternion.Euler(rotAmount); //new Quaternion(0, 0, 0, 1);
        collider.GetComponent<Transform>().position += new Vector3(0, -0.5f, -0.1f);

    }
    private void OnTriggerExit(Collider other)
    {
        chairSeat.enabled = true;
        chairSeat.GetComponent<FlipSeat>().changeMass();
    }
}
