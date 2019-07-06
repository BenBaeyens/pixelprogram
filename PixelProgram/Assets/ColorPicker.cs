using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{

    ColorChanger colorChanger;

    Material[] colors;

    #region Methods

    void Start()
    {
        colorChanger = GameObject.Find("Selector").GetComponent<ColorChanger>();
    }

    public void PickColor(string color){
        switch(color){
            case "White":
                colorChanger.effectedMat = colors[0];
                break;
            case "Grey":
                colorChanger.effectedMat = colors[1];
                break;
            case "Black":
                colorChanger.effectedMat = colors[2];
                break;
            default:
                Debug.LogError("Error: Incorrect color argument");
                break;

        }

    }

    #endregion
}
