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
        if(PlayerPrefs.GetInt("DefaultSizeX") != 0 )
            xCoord.text = PlayerPrefs.GetInt("DefaultSizeX").ToString();
            
        if(PlayerPrefs.GetInt("DefaultSizeY") != 0 )
            yCoord.text = PlayerPrefs.GetInt("DefaultSizeY").ToString();
    }

    public void ChangeDefaultSize(){
        if(xCoord.text != null && xCoord.text != ""){
            if(int.Parse(xCoord.text) <= 0)
                xCoord.text = "1";
            PlayerPrefs.SetInt("DefaultSizeX", int.Parse(xCoord.text));
        }
        if(yCoord.text != null && yCoord.text != ""){
            if(int.Parse(yCoord.text) <= 0)
                yCoord.text = "1";
            
            PlayerPrefs.SetInt("DefaultSizeY", int.Parse(yCoord.text));
        }
    }

    #endregion
}
