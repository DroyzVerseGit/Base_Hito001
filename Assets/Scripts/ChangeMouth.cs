using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMouth : MonoBehaviour
{
    public GameObject[] Mouthes;
    int ActualMouth = 0;

    public void Awake()
    {
        ActualMouth = 0;
    }
    public void Start()
    {
        ActualMouth = PlayerPrefs.GetInt("SelectedMouthes");
        Mouthes[ActualMouth].SetActive(true);
    }

    public void SelectObject(int selectedIndex)
    {
        // Disable the previous selected object, if any.
        //  ActualPelo = PlayerPrefs.GetInt("SelectedPelos");
        if (ActualMouth >= 0)
            Mouthes[ActualMouth].SetActive(false);


        // Update our selected index and activate the corresponding object.
        ActualMouth = selectedIndex;
        Mouthes[selectedIndex].SetActive(true);
    }



    public void EquipNariz()
    {
        PlayerPrefs.SetInt("SelectedMouthes", ActualMouth);
    }

    public void MenuChico()
    {
        SceneManager.LoadScene("MenuChico", LoadSceneMode.Single);
    }
}
