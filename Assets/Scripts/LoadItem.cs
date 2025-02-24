using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadItem : MonoBehaviour
{
    public GameObject[] Pelos;


    public GameObject[] Narices;
    public GameObject[] Eyes;

    // Start is called before the first frame update
    void Start()
    {
        int ActualPelo = PlayerPrefs.GetInt("SelectedPelos");
        GameObject Pelo = Pelos[ActualPelo];
        Pelo.SetActive(true);

        int ActualNariz = PlayerPrefs.GetInt("SelectedNarices");
        GameObject Nariz = Narices[ActualNariz];
        Nariz.SetActive(true);

        int ActualEye = PlayerPrefs.GetInt("SelectedEyes");
        GameObject Eye = Eyes[ActualEye];
       Eye.SetActive(true);
        Debug0();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Debug0()
    {
        Debug.Log("Exit");

    }
}
