using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEditor.XR.Interaction.Toolkit;
using UnityEngine;

public class RemoveSeatMesh : MonoBehaviour
{
    public MeshCollider chairSeat;
    public GameObject chair;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        CapsuleCollider collider = (CapsuleCollider) other;
        chairSeat.enabled = false;
        collider.GetComponent<Transform>().position += new Vector3(0, 0, 0.1f);
        collider.GetComponent<Transform>().localRotation = new Quaternion(0, 0, 0, 1);
        //collider.center = new Vector3(0, collider.center.y, 0);
        
        
    }
    private void OnTriggerExit(Collider other)
    {
        chairSeat.enabled = true;
    }
}
