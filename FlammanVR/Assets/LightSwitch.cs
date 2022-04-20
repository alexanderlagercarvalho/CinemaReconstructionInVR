using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class LightSwitch : MonoBehaviour
{
    public float litSides;
    public float unlitSides;
    public float litRoof;
    public float unlitRoof;
    public Light[] roofLights;
    public Light[] sideLights;


    public void LightsOff()
    {
        foreach (Light light in roofLights)
        {
            light.intensity = unlitSides;
        }
        foreach (Light light in sideLights)
        {
            light.intensity = unlitSides;
        }

    }
    public void LightsOn()
    {
        foreach (Light light in roofLights)
        {
            light.intensity = litSides;
        }
        foreach (Light light in sideLights)
        {
            light.intensity = litSides;
        }
    }
}
