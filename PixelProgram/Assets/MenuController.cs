using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{

    [SerializeField] GameObject menu;
    public bool isMenuOpen = false;
    #region Methods

    void Start()
    {
        
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)){
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
