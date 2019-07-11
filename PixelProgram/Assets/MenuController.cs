using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{

    [SerializeField] GameObject menu;
    bool isMenuOpen = false;
    CanvasGenerator canvasGenerator;
    #region Methods

    void Start()
    {
        canvasGenerator = GameObject.Find("Startup").GetComponent<CanvasGenerator>();
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape) && !canvasGenerator.isCanvasOpen){
            if(isMenuOpen)
            {
                MenuClose();
            }
            
            else if (!isMenuOpen)
            {
                MenuOpen();
            }
        }
    }

    public void MenuClose()
    {
        isMenuOpen = false;
        menu.gameObject.SetActive(false);
    }

    public void MenuOpen()
    {
        isMenuOpen = true;
        menu.gameObject.SetActive(true);
    }

    #endregion
}
