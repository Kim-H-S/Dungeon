using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnInventory : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClick()
    {
        UIManager.instance.inventoryCanvas.SetActive(true);

        UIManager.instance.btnStatus.SetActive(false);
        UIManager.instance.btnInventory.SetActive(false);

        UIManager.instance.btnBack.SetActive(true);
    }
}
