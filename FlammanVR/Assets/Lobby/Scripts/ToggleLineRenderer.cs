using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ToggleLineRenderer : MonoBehaviour
{

    public GameObject controller;
    public InputActionReference reference;
    public GameObject reticle;
    public Material TPEnabled;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float triggerValue = reference.action.ReadValue<float>();
        if (triggerValue < 0.5)
        {
            reticle.GetComponent<MeshRenderer>().material = TPEnabled;
            controller.GetComponent<XRInteractorLineVisual>().enabled = false;
            controller.GetComponent<XRRayInteractor>().enabled = false;
            reticle.SetActive(false);
            return;
        }
        controller.GetComponent<XRRayInteractor>().enabled = true;
        controller.GetComponent<XRInteractorLineVisual>().enabled = true;
        reticle.SetActive(true);   

    }

}

