using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeEye1 : MonoBehaviour
{
    public GameObject[] Eyes;
    int ActualEye = 0;

  //  [SerializeField] private PlayerDroyzData data;

    public void Awake()
    {
        ActualEye = 0;
    }
    public void Start()
    {
        ActualEye = PlayerPrefs.GetInt("SelectedEyes");
        Eyes[ActualEye].SetActive(true);
    }

    public void SelectObject(int selectedIndex)
    {

        if (ActualEye >= 0)
            Eyes[ActualEye].SetActive(false);

        ActualEye = selectedIndex;
        Eyes[selectedIndex].SetActive(true);
        PlayerPrefs.SetInt("SelectedEyes", ActualEye);
    }



    //public void EquipEye()
    //{
    //    PlayerPrefs.SetInt("SelectedEyes", ActualEye);
    //}

    //public void MenuChico()
    //{
    //    SceneManager.LoadScene("MenuChico", LoadSceneMode.Single);
    //}
}
