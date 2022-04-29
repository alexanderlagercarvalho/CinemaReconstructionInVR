using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using Photon.Pun;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;

public class NetworkPlayer : MonoBehaviour
{
    public Transform head;
    public Transform leftHand;
    public Transform rightHand;
    private PhotonView photonView;

    private Transform headRig;
    private Transform leftHandRig;
    private Transform rightHandRig;



    // Start is called before the first frame update
    void Start()
    {
       
        photonView = GetComponent<PhotonView>();
        XROrigin rig = FindObjectOfType<XROrigin>();
        headRig = rig.transform.Find("Camera Offset/Main Camera");
        leftHandRig = rig.transform.Find("Camera Offset/LeftHand Controller");
        rightHandRig = rig.transform.Find("Camera Offset/RightHandController");
        foreach(var item in GetComponentsInChildren<Renderer>())
        {
            item.enabled = false;
        }
        Debug.Log("Everything in order");
    }

    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine)
        {
            
            MapPosition(head, headRig);
            MapPosition(head, leftHandRig);
            MapPosition(head, rightHandRig);


        }


    }
    void MapPosition(Transform target, Transform rigTransform)
    {
       
        target.position = rigTransform.position;
        target.rotation = rigTransform.rotation;
    }
}
