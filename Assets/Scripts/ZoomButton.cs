using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomButton : MonoBehaviour
{

    [SerializeField] GameObject vrCam01;
    [SerializeField] GameObject vrCam02;
    [SerializeField] GameObject vrCam03;
    [SerializeField] GameObject vrCam04;

    public void CamaraNext01(/*InputAction.CallbackContext callbackContext*/)
    {
        vrCam01.SetActive(true);

        vrCam02.SetActive(false);

        vrCam03.SetActive(false);

        vrCam04.SetActive(false);
    }

    public void CamaraNext02()
    {
        vrCam01.SetActive(false);

        vrCam02.SetActive(true);

        vrCam03.SetActive(false);

        vrCam04.SetActive(false);

    }

    public void CamaraNext03()
    {
        vrCam01.SetActive(false);

        vrCam02.SetActive(false);

        vrCam03.SetActive(true);

        vrCam04.SetActive(false);

    }

    public void CamaraNext04()
    {
        vrCam01.SetActive(false);

        vrCam02.SetActive(false);

        vrCam03.SetActive(false);

        vrCam04.SetActive(true);

    }
}
