using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    [SerializeField] Material defaultMat;
    [SerializeField] Material effectedMat;
    [SerializeField] SelectorController selectorController;

    #region Methods

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space)){
            selectorController.floorObject.GetComponent<Renderer>().material = effectedMat; 
        }   
    }

    #endregion
}
