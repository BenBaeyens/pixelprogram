using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketFill : MonoBehaviour
{

    public List<GameObject> pixels;
    public List<GameObject> affectedByBucket;
    [SerializeField] ColorChanger colorChanger;
    [SerializeField] GameObject pixelParent;


    #region Methods

    public void PixelArray()
    {
        affectedByBucket = new List<GameObject>();
        pixels = new List<GameObject>();
        foreach (Transform child in pixelParent.transform)
        {
            pixels.Add(child.gameObject);
        }
    }

    public void FillBucket(){
        colorChanger.pixelHistory.Add(gameObject);
        for (int i = 0; i < pixels.Count; i++)
        {
            pixels[i].GetComponent<Renderer>().material = colorChanger.effectedMat;
            pixels[i].GetComponent<ColorUndo>().AddColor(1);
        }
        colorChanger.pixelHistory.Add(gameObject);
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.B))
            FillBucket();
    }
    

    #endregion
}
