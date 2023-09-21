using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnStatus : MonoBehaviour
{
    
    void Start()
    {
        
    }

    public void OnClick()
    {
        UIManager.instance.statusCanvas.SetActive(true);

        UIManager.instance.btnStatus.SetActive(false);
        UIManager.instance.btnInventory.SetActive(false);

        UIManager.instance.btnBack.SetActive(true);
    }
}
