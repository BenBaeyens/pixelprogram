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

    void Update(){
        if(Input.GetKeyDown(KeyCode.U)){
            AddColor();
        }
    }

    public void AddColor(){
        Debug.Log(materialHistory.Count);
        materialHistory.Insert(0, gameObject.GetComponent<Renderer>().material);
        Debug.Log(materialHistory.Count);
        if(materialHistory.Count >= 2){
            if(materialHistory[0].name == materialHistory[1].name){
                materialHistory.RemoveAt(0);}
            }
    }

    public void UndoColor(){
        materialHistory.RemoveAt(materialHistory.Count - 1);
        gameObject.GetComponent<Renderer>().material = materialHistory[materialHistory.Count - 1];
    }
    #endregion
}
