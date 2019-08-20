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
            colorUndo.AddColor(0);
        }   

        if(Input.GetKeyDown(KeyCode.U)){
            if(pixelHistory.Count >= 1){
                if(pixelHistory[pixelHistory.Count -1].name == "Bucket Fill"){
                    for (int i = 1; i < pixelHistory.Count; i++)
                    {   
                        if(pixelHistory[i].name == "Bucket Fill"){
                            Debug.Log(i);
                            pixelHistory.RemoveRange(pixelHistory.Count - i - 1, pixelHistory.Count);
                        }
                        pixelHistory[i].GetComponent<ColorUndo>().UndoColor();
                        
                    }

                }else{
                pixelHistory[pixelHistory.Count - 1].GetComponent<ColorUndo>().UndoColor();
                pixelHistory.RemoveAt(pixelHistory.Count - 1);
                }
            }
        }
    }

    #endregion
}
