using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorUndo : MonoBehaviour
{

    public List<Material> materialHistory;
    ColorChanger colorChanger;
    BucketFill bucketFill;

    #region Methods

    void Start()
    {           
        bucketFill = GameObject.Find("Bucket Fill").GetComponent<BucketFill>();
        colorChanger = GameObject.Find("Selector").GetComponent<ColorChanger>();
        materialHistory = new List<Material>();
        materialHistory.Add(GetComponent<Renderer>().material);
    }


    public void AddColor(int mode){ // 0 for default, 1 for bucket fill
        Debug.Log(materialHistory.Count);
        materialHistory.Insert(0, gameObject.GetComponent<Renderer>().material);
        Debug.Log(materialHistory.Count);
        if(materialHistory.Count >= 2){
            if(materialHistory[0].name == materialHistory[1].name){
                materialHistory.RemoveAt(0);
            }
            else{
               
                colorChanger.pixelHistory.Add(gameObject);

                if(mode == 1){
                    bucketFill.affectedByBucket.Add(gameObject);
                }
            }
        }
    
    }

    public void UndoColor(){
        materialHistory.RemoveAt(0);
        gameObject.GetComponent<Renderer>().material = materialHistory[0];
    }
    #endregion
}
