using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CanvasGenerator : MonoBehaviour
{

    [SerializeField] GameObject pixel;
    [SerializeField] GameObject selector;
    [SerializeField] GameObject pixelParent;


    [SerializeField] TMP_InputField xSizeIF;
    [SerializeField] TMP_InputField ySizeIF;

    public bool isCanvasOpen = true;

    int xSize;
    int ySize;



    #region Methods

    private void Start() {
        if(PlayerPrefs.GetInt("DefaultSizeX") != 0 && PlayerPrefs.GetInt("DefaultSizeY") != 0){
        xSizeIF.text = PlayerPrefs.GetInt("DefaultSizeX").ToString();
        ySizeIF.text = PlayerPrefs.GetInt("DefaultSizeY").ToString();
        }else{
            xSizeIF.text = "10";
            ySizeIF.text = "10";
            }
    }
    public void GenerateCanvas(){
        Debug.Log(xSizeIF.text + " x " + ySizeIF.text);
        if(xSizeIF.text != "0")
            xSize = int.Parse(xSizeIF.text);
        else
            xSize = 1;
        if(ySizeIF.text != "0")
            ySize = int.Parse(ySizeIF.text);
        else 
            ySize = 1;
        float xPos = 0;
        float yPos = 0;

        for (int i = 0; i < xSize; i++)
        {
            yPos = 0;
            for (int b = 0; b < ySize; b++)
            {
                Instantiate(pixel, new Vector3(xPos, 0, yPos), Quaternion.identity, pixelParent.transform);
                yPos += 6;
            }
            xPos += 6;
        }   
        isCanvasOpen = false;
        gameObject.SetActive(false);

    }

    #endregion
}
