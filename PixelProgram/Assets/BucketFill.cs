using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketFill : MonoBehaviour
{

    public List<GameObject> pixels;
    [SerializeField] ColorChanger colorChanger;
    [SerializeField] GameObject pixelParent;


    #region Methods

    public void PixelArray()
    {
        pixels = new List<GameObject>();
        foreach (Transform child in pixelParent.transform)
        {
            pixels.Add(child.gameObject);
        }
    }

    public void FillBucket(){
        for (int i = 0; i < pixels.Count; i++)
        {
            pixels[i].GetComponent<Renderer>().material = colorChanger.effectedMat;
            pixels[i].GetComponent<ColorUndo>().AddColor();
        }
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.B))
            FillBucket();
    }
    

    #endregion
}
