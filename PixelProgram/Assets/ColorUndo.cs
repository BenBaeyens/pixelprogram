using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorUndo : MonoBehaviour
{

    public List<Material> materialHistory;
    ColorChanger colorChanger;

    #region Methods

    void Start()
    {   
        colorChanger = GameObject.Find("Selector").GetComponent<ColorChanger>();
        materialHistory = new List<Material>();
        materialHistory.Add(GetComponent<Renderer>().material);
    }


    public void AddColor(){
        Debug.Log(materialHistory.Count);
        materialHistory.Insert(0, gameObject.GetComponent<Renderer>().material);
        Debug.Log(materialHistory.Count);
        if(materialHistory.Count >= 2){
            if(materialHistory[0].name == materialHistory[1].name){
                materialHistory.RemoveAt(0);
            }
            else{
               
                colorChanger.pixelHistory.Add(gameObject);
            }
        }
    
    }

    public void UndoColor(){
        materialHistory.RemoveAt(0);
        gameObject.GetComponent<Renderer>().material = materialHistory[0];
    }
    #endregion
}
