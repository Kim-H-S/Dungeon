using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [Header("Canvas")]
    public GameObject statusCanvas;
    public GameObject inventoryCanvas;

    [Header("Popup")]
    public PanelHandler popupWindow;

    [Header("Button")]
    public GameObject btnStatus;
    public GameObject btnInventory;
    public GameObject btnBack;
    
    [Header("Text")]
    public TMP_Text txtName; 
    public TMP_Text txtLevel;
    public TMP_Text txtGold; 

    //[Header("InventorySlot")]
    //public InventorySlot[] Slot;
    //public GameObject[] equip;

    //public Slider Exp;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        
    }
}
