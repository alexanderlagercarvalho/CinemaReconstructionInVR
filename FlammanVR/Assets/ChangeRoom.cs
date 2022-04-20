using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class ChangeRoom : MonoBehaviour
{
    public XROrigin player;

    public void moveToCinema()
    {
        player.transform.position = new Vector3(-36.6185913f, 1.90999472f, -200.345245f);
        player.transform.rotation = new Quaternion(1.20899557e-09f, -0.319977164f, -6.94129199e-10f, -0.947425246f);
    }

    public void moveToLobby()
    {
        player.transform.position = new Vector3(-4.16571188f, 2.26986337f, -6.44280958f);
        player.transform.rotation = new Quaternion(0, -0.660504699f, 1.39698386e-09f, 0.750821948f);
    }
}
