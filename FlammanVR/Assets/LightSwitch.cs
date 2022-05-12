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
    private Light screenLight;
    private Material lampMaterial;
    private Light projectorLamp;

    private void Start()
    {
        for (int i = 1; i <11; i++)
        {
            roofLights.Add(GameObject.Find("Roof" + i).GetComponent<Light>());
            sideLights.Add(GameObject.Find("Side" + i).GetComponent<Light>());
        }
        screenLight = GameObject.Find("ScreenLight").GetComponent<Light>();
        lampMaterial = GameObject.Find("Lamp").GetComponent<Renderer>().material;
        projectorLamp = GameObject.Find("ProjectorLamp").GetComponent<Light>();
        screenLight.enabled = false;
        projectorLamp.enabled = true;
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
        screenLight.enabled = true;
        lampMaterial.DisableKeyword("_EMISSION");
        projectorLamp.enabled = false;

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
        screenLight.enabled = false;
        lampMaterial.EnableKeyword("_EMISSION");
        projectorLamp.enabled = true;
    }
}
