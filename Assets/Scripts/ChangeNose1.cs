using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeNose1 : MonoBehaviour
{
    public GameObject[] Narices;
    int ActualNariz = 0;



    public void Awake()
    {
        ActualNariz = 0;
    }
    public void Start()
    {
     ActualNariz = PlayerPrefs.GetInt("SelectedNarices");
        Narices[ActualNariz].SetActive(true);
    }

    public void SelectObject(int selectedIndex)
    {

        if (ActualNariz >= 0)
           Narices[ActualNariz].SetActive(false);


        ActualNariz = selectedIndex;
       Narices[selectedIndex].SetActive(true);
        PlayerPrefs.SetInt("SelectedNarices", ActualNariz);


    }



    public void EquipNariz()
    {
        PlayerPrefs.SetInt("SelectedNarices", ActualNariz);
    }

    //public void MenuChico()
    //{
    //    SceneManager.LoadScene("MenuChico", LoadSceneMode.Single);
    //}
}
