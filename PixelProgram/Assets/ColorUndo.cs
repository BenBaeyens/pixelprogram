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
        materialHistory.Add(gameObject.GetComponent<Renderer>().material);
        if(materialHistory[materialHistory.Count -1] == materialHistory[materialHistory.Count -2])
            materialHistory.RemoveAt(materialHistory.Count -1);
    }

    public void UndoColor(){
        materialHistory.RemoveAt(materialHistory.Count - 1);
        gameObject.GetComponent<Renderer>().material = materialHistory[materialHistory.Count - 1];
    }
    #endregion
}
