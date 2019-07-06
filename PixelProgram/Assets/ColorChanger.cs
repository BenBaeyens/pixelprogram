﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    [SerializeField] Material defaultMat;
    [SerializeField] public Material effectedMat;
    [SerializeField] SelectorController selectorController;

    #region Methods

    private void Update() {
        if(Input.GetKey(KeyCode.Space)){
            selectorController.floorObject.GetComponent<Renderer>().material = effectedMat; 
        }   
    }

    #endregion
}
