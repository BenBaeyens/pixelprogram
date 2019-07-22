using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{

    [SerializeField] GameObject menu;
    [SerializeField] GameObject settings;
    bool isMenuOpen = false;
    bool isSettingsOpen = false;

    CanvasGenerator canvasGenerator;
    #region Methods

    void Start()
    {
        canvasGenerator = GameObject.Find("Startup").GetComponent<CanvasGenerator>();
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape) && !canvasGenerator.isCanvasOpen && !isSettingsOpen){
            if(isMenuOpen)
            {
                MenuClose();
            }
            
            else if (!isMenuOpen)
            {
                MenuOpen();
            }
        }

        if(Input.GetKeyDown(KeyCode.S) && !isMenuOpen && !canvasGenerator.isCanvasOpen){
            if(isSettingsOpen){
                isSettingsOpen = false;
                settings.gameObject.SetActive(false);
            }else{
                isSettingsOpen = true;
                settings.gameObject.SetActive(true);
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
