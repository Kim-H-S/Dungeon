using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class InventorySlot : MonoBehaviour
{
    public GameObject txtEquip;

    bool isEquip = false;

    

    public void OnButtonClick()
    {

        ToggleEquip();



    }

    private void Popup()
    {
        var seq = DOTween.Sequence();

        seq.Append(transform.DOScale(0.95f, 0.1f));
        seq.Append(transform.DOScale(1.05f, 0.1f));
        seq.Append(transform.DOScale(1.00f, 0.1f));

        seq.Play().OnComplete(() =>
        {
            UIManager.instance.popupWindow.Show();
        });
    }

    private void ToggleEquip()
    {
        isEquip = !isEquip;

        txtEquip.SetActive(isEquip);
    }
}
