using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ResetHeadsetOffset : MonoBehaviour
{
    public void resetOffset()
    {
        InputTracking.Recenter();
    }

}
