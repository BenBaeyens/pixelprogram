using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorUndo : MonoBehaviour
{

    public List<Material> materialHistory;

    #region Methods

    void Start()
    {
        materialHistory = new List<Material>();
    }

    public void AddColor(){
        int counter;
        Debug.Log(materialHistory.Count);
        materialHistory.Insert(0, gameObject.GetComponent<Renderer>().material);
        Debug.Log(materialHistory.Count);
        counter = materialHistory.Count;
        if(counter >= 2){
            Debug.Log("yeet");
            // if(materialHistory[0] == materialHistory[1]){
            //     Debug.Log("yeet2");
            //     materialHistory.RemoveAt(0);}
            }
    }

    public void UndoColor(){
        materialHistory.RemoveAt(materialHistory.Count - 1);
        gameObject.GetComponent<Renderer>().material = materialHistory[materialHistory.Count - 1];
    }
    #endregion
}
