using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class ReticleCollider : MonoBehaviour
{
    private GameObject reticle;
    public Material TPEnabled;
    public Material TPDisabled;
    private GameObject controller;
    private ActionBasedController right;



    // Start is called before the first frame update
    void Start()
    {
        reticle = GameObject.Find("Reticle");
        controller = GameObject.Find("RightHandController");
        right = controller.GetComponent<ActionBasedController>();
    }

    
    private void OnTriggerEnter(Collider other)
    {
        reticle = GameObject.Find("Reticle");
        if (reticle != null)
            reticle.GetComponent<MeshRenderer>().material = TPDisabled;
        right.enableInputActions = false;


    }
    private void OnTriggerExit(Collider other)
    {
        reticle = GameObject.Find("Reticle");
        if (reticle != null)
            reticle.GetComponent<MeshRenderer>().material = TPEnabled;
        right.enableInputActions = true;

    }
}