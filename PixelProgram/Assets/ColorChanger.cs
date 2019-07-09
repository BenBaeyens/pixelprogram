using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    [SerializeField] Material defaultMat;
    [SerializeField] public Material effectedMat;
    [SerializeField] SelectorController selectorController;
    ColorUndo colorUndo;

    public List<GameObject> pixelHistory;

    #region Methods


    private void Start() {
        pixelHistory = new List<GameObject>();
    }
    private void Update() {
        if(Input.GetKey(KeyCode.Space)){
            selectorController.floorObject.GetComponent<Renderer>().material = effectedMat; 
            colorUndo = selectorController.floorObject.GetComponent<ColorUndo>();
            colorUndo.AddColor();
        }   

        if(Input.GetKeyDown(KeyCode.U)){
            if(pixelHistory.Count >= 2){
                pixelHistory[pixelHistory.Count - 1].GetComponent<ColorUndo>().UndoColor();
                pixelHistory.RemoveAt(pixelHistory.Count - 1);
            }
        }
    }

    #endregion
}
