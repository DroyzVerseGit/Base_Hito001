using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour
{
//  [SerializeField] GameObject botones;

    [SerializeField] GameObject  nose;
    [SerializeField] GameObject  pelo;
    [SerializeField] GameObject eye;
    [SerializeField] GameObject mouth;

    [SerializeField] GameObject botonPelo;
    [SerializeField] GameObject botonNose;
    [SerializeField] GameObject botonEye;
    [SerializeField] GameObject botonMouth;


    // Start is called before the first frame update
    void Start()
    {
        //botones = GameObject.FindGameObjectWithTag("Botones");
       // nose = GameObject.FindGameObjectWithTag("Noses");
       //pelo = GameObject.FindGameObjectWithTag("Pelos");
    }

    //// Update is called once per frame
    //void Update()
    //{
    //    float xInput = Input.GetAxis("Horizontal");
    //    float zInput = Input.GetAxis("Vertical");
    //    if (zInput != 0)
    //    {

    //         botones.SetActive(false);

    //    }
    //    else
    //    {
    //        botones.SetActive(true);
    //    }


    //    if (-xInput != 0)
    //    {

    //   botones.SetActive(false);


    //    }


    //}

    public void Pelo()
    {
        botonPelo.SetActive(true);
        pelo.SetActive(true);

        botonNose.SetActive(false);
        nose.SetActive(false);

        botonEye.SetActive(false);
        eye.SetActive(false);


        botonMouth.SetActive(false);
        mouth.SetActive(false);
    }


    public void Noses()
    {
        botonNose.SetActive(true);
        nose.SetActive(true);

        botonPelo.SetActive(false);
        pelo.SetActive(false);

        botonEye.SetActive(false);
        eye.SetActive(false);


        botonMouth.SetActive(false);
        mouth.SetActive(false);


    }

    public void Eye()
    {
        botonEye.SetActive(true);
        eye.SetActive(true);

        botonNose.SetActive(false);
        nose.SetActive(false);


        botonPelo.SetActive(false);
        pelo.SetActive(false);


        botonMouth.SetActive(false);
        mouth.SetActive(false);
    }


    public void Mouth()
    {
        botonPelo.SetActive(false);
        pelo.SetActive(false);

        botonNose.SetActive(false);
        nose.SetActive(false);

        botonEye.SetActive(false);
        eye.SetActive(false);


        botonMouth.SetActive(true);
        mouth.SetActive(true);
    }


}
