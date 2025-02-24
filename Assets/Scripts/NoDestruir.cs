using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDestruir : MonoBehaviour
{
    public static NoDestruir _instance;

    #region Change Hair1

    public GameObject[] pelos;

    #endregion

    //public void Awake()
    //{
    //    var noDestruirEntreEscena = FindObjectsOfType<NoDestruir>();

    //    if (noDestruirEntreEscena.Length >2)
    //    {
    //       gameObject.SetActive(false);
    //       // Destroy(gameObject);
    //        return;
    //    }
    //    DontDestroyOnLoad(gameObject);
    //}
    // Start is called before the first frame update


    private void Awake()
    {

        if (_instance != null && _instance != this)
        {
            _instance = this;




       
        }
        DontDestroyOnLoad(gameObject);
        //else
        //{

        //    if (_instance != this)
        //    {
        //        Destroy(gameObject);

        //    }

        //}
    }

}


