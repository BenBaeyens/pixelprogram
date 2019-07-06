using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    [SerializeField] Material defaultMat;
    [SerializeField] public Material effectedMat;
    [SerializeField] SelectorController selectorController;

    [SerializeField] ColorUndo colorUndo;

    #region Methods

    private void Update() {
        if(Input.GetKey(KeyCode.Space)){
            selectorController.floorObject.GetComponent<Renderer>().material = effectedMat; 
            colorUndo = selectorController.floorObject.GetComponent<ColorUndo>();
            colorUndo.AddColor();
        }   
    }

    #endregion
}
