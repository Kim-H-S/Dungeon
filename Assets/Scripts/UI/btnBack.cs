using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnBack : MonoBehaviour
{

    void Start()
    {
        
    }

    public void OnClick()
    {
        UIManager.instance.btnStatus.SetActive(true);
        UIManager.instance.btnInventory.SetActive(true);

        UIManager.instance.statusCanvas.SetActive(false);
        UIManager.instance.inventoryCanvas.SetActive(false);

        UIManager.instance.btnBack.SetActive(false);
    }
}
