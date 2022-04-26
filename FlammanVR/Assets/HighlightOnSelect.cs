using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightOnSelect : MonoBehaviour
{
    //public GameObject gameObject;
    public Material material;
    private Color startcolor = new Color(0.5283019f, 0.3475811f, 0.236739f, 1);

    // Start is called before the first frame update
  
    public void Activate()
    {
        material.SetColor("_Color", new Color(1f, 0.7058823f, 0.5254902f, 1f));
    }
    public void Deactivate()
    {
        material.SetColor("_Color",startcolor);
    }
}
