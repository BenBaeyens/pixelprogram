using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Settings : MonoBehaviour
{

    [SerializeField] TMP_InputField xCoord;
    [SerializeField] TMP_InputField yCoord;

    #region Methods

    public void ChangeDefaultSize(){
        PlayerPrefs.SetInt("DefaultSizeX", int.Parse(xCoord.text));
        PlayerPrefs.SetInt("DefaultSizeY", int.Parse(yCoord.text));
    }

    #endregion
}
