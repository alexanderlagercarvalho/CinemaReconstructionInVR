using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ToggleLineRenderer : MonoBehaviour
{

    private GameObject controller;
    public InputActionReference reference;
    public GameObject reticle;
    public Material TPEnabled;
    private bool justPressedFlag;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("RightHandController");
        
    }

    // Update is called once per frame
    void Update()
    {
        float grabValue = reference.action.ReadValue<float>();
        if (grabValue < 0.5)
        {
            justPressedFlag = false;
            reticle.GetComponent<MeshRenderer>().material = TPEnabled;
            controller.GetComponent<XRInteractorLineVisual>().enabled = false;
            controller.GetComponent<ActionBasedController>().enableInputActions = false;
            reticle.SetActive(false);
            return;
        }
        if (!justPressedFlag)
        {
            controller.GetComponent<ActionBasedController>().enableInputActions = true;
            justPressedFlag = true;
        }
        controller.GetComponent<XRInteractorLineVisual>().enabled = true;
        reticle.SetActive(true);

    }

}

