using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Settings : MonoBehaviour
{

    [SerializeField] TMP_InputField xCoord;
    [SerializeField] TMP_InputField yCoord;

    #region Methods

    private void Start() {
        xCoord.text = PlayerPrefs.GetInt("DefaultSizeX").ToString();
        yCoord.text = PlayerPrefs.GetInt("DefaultSizeY").ToString();
    }

    public void ChangeDefaultSize(){
        if(int.Parse(xCoord.text) <= 0)
            xCoord.text = "1";
        if(int.Parse(yCoord.text) <= 0)
            yCoord.text = "1";
        PlayerPrefs.SetInt("DefaultSizeX", int.Parse(xCoord.text));
        PlayerPrefs.SetInt("DefaultSizeY", int.Parse(yCoord.text));
    }

    #endregion
}
