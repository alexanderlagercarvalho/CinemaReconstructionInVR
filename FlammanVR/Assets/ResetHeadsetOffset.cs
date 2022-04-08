using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ResetHeadsetOffset : MonoBehaviour
{
    public CapsuleCollider collider;
    public void resetOffset()
    {
        InputTracking.Recenter();
    }
}
