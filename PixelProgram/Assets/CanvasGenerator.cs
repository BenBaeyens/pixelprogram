using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CanvasGenerator : MonoBehaviour
{

    [SerializeField] GameObject platform;
    [SerializeField] GameObject selector;


    [SerializeField] TMP_InputField xSizeIF;
    [SerializeField] TMP_InputField ySizeIF;



    #region Methods

    public void GenerateCanvas(){
        int xSize = int.Parse(xSizeIF.text);
        int ySize = int.Parse(ySizeIF.text);

        float xPos = 0;
        float yPos = 0;

        for (int i = 0; i < xSize; i++)
        {
            Instantiate(platform, new Vector3(xPos, 0, yPos), Quaternion.identity);
            xPos += 6;
        }   

        for (int i = 0; i < ySize; i++)
        {
            Instantiate(platform, new Vector3(xPos, 0, yPos), Quaternion.identity);
            yPos += 6;
        }

        gameObject.SetActive(false);

    }

    #endregion
}
