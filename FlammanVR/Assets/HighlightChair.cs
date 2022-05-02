using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightChair : MonoBehaviour
{
    public Material chairMaterial;
    public Material chairHighlight;
    public GameObject backrest;
    public GameObject seat;

    public void Activate()
    {
        backrest.GetComponent<Renderer>().material = chairHighlight;
        seat.GetComponent<Renderer>().material = chairHighlight;
    }
    public void Deactivate()
    {
        backrest.GetComponent<Renderer>().material = chairMaterial;
        seat.GetComponent<Renderer>().material = chairMaterial;
    }
}