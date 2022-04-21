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
    public List<Light> roofLights;
    public List<Light> sideLights;

    private void Start()
    {
        for (int i = 1; i <11; i++)
        {
            roofLights.Add(GameObject.Find("Roof" + i).GetComponent<Light>());
            sideLights.Add(GameObject.Find("Side" + i).GetComponent<Light>());
        }
    }
    public void LightsOff()
    {
        foreach (Light light in roofLights)
        {
            light.enabled = false;
        }
        foreach (Light light in sideLights)
        {
            light.enabled = false;
        }

    }
    public void LightsOn()
    {
        foreach (Light light in roofLights)
        {
            light.enabled = true;
        }
        foreach (Light light in sideLights)
        {
            light.enabled = true;
        }
    }
}
