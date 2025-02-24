using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangePelo : MonoBehaviour
{
    public GameObject[] Pelos;
 int ActualPelo = 0;

   // [SerializeField] private PlayerDroyzData data;

    public void Awake()
    {
        ActualPelo = 0;
    }
    // Start is called before the first frame update
    void Start()
    {

      ActualPelo = PlayerPrefs.GetInt("SelectedPelos");
      Pelos[ActualPelo].SetActive(true);
    

    }

    public void SelectObject(int selectedIndex)
    {
        // Disable the previous selected object, if any.
      //  ActualPelo = PlayerPrefs.GetInt("SelectedPelos");
        if (ActualPelo >= 0)
            Pelos[ActualPelo].SetActive(false);
     //   data._pelo = Pelos[ActualPelo];


        // Update our selected index and activate the corresponding object.
        ActualPelo = selectedIndex;
        Pelos[selectedIndex].SetActive(true);
        PlayerPrefs.SetInt("SelectedPelos", ActualPelo);
    }





    public void EquipPelo()
    {
        PlayerPrefs.SetInt("SelectedPelos", ActualPelo);
    }

    //public void MenuChico()
    //{
    //    SceneManager.LoadScene("MenuChico", LoadSceneMode.Single);
    //}


    // Update is called once per frame
    //public void NextPelo()
    //{
    //    Pelos[ActualPelo].SetActive(false);
    //    ActualPelo = (ActualPelo + 1) % Pelos.Length;
    //    Pelos[ActualPelo].SetActive(true);
    //}

    //public void PreviousPelo()
    //{
    //    Pelos[ActualPelo].SetActive(false);
    //    ActualPelo--;
    //    if ( ActualPelo < 0)
    //    {
    //        ActualPelo += Pelos.Length;
    //    }

    //    Pelos[ActualPelo].SetActive(true);
    //}

}
