using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class CenterCamera : MonoBehaviour
{
    public CapsuleCollider character;
    public XROrigin rig;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CapsuleFollowHead();
    }
    private void CapsuleFollowHead()
    {
        character.height = rig.CameraInOriginSpaceHeight + 0.02f;
        Vector3 capsuleCenter = transform.InverseTransformPoint(rig.Camera.transform.position);
        character.center = new Vector3(capsuleCenter.x, character.height / 2, capsuleCenter.z);
    }
}
