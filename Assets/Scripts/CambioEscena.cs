using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public Transform puntoInicial;
    public GameObject personaje;
    // Start is called before the first frame update
    void Start()
    {
        personaje = GameObject.FindGameObjectWithTag("Boy");
        puntoInicial = GameObject.FindGameObjectWithTag("PuntoInicial").transform;
        MoverAPuntoInicial();
    }

    // Update is called once per frame
    void Update()
    {
       // ProbarCambioEscena();
    }

    public void MoverAPuntoInicial()
    {
        personaje.transform.position = puntoInicial.position;
    }

    public void ProbarCambioEscena()
    {
        //if (Input.GetMouseButtonDown(1))
        //{
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                SceneManager.LoadScene(3);
            }
            else
            {
                SceneManager.LoadScene(2);
            }
        //}
    }
}
