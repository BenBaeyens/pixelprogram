using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    [SerializeField] GameObject tempGameObject;
    [SerializeField] GameObject selectorObject;
    [SerializeField] GameObject shopObject;
    bool shopObjectActive = false;

    #region Methods

    void Start()
    {

    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.S)){
            if(shopObjectActive)
            {
                DisableShop();
            }
            else if (!shopObjectActive)
            {
                EnableShop();
            }
        }
    }

    private void EnableShop()
    {
        shopObject.SetActive(true);
        shopObjectActive = true;
    }

    private void DisableShop()
    {
        shopObject.SetActive(false);
        shopObjectActive = false;
    }

    public void PurchaseSpitter(){
        Instantiate(tempGameObject, selectorObject.transform.position + Vector3.up * 2f, selectorObject.transform.rotation);
        
    }

    #endregion
}
