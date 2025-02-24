using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class set_color : MonoBehaviour
{
    public Material mat_cushion;

    private Slider color_picker;
    public float hue = 0;


    void Start()
    {


        color_picker = this.gameObject.GetComponent<Slider>();
    }

    public void GetColor()
    {
   
        hue = color_picker.value;
      mat_cushion.SetFloat("_hue", hue);

    }

    public void GetColorNoses()
    {
        hue = color_picker.value;
        mat_cushion.SetFloat("_hue", hue);
    }
}
