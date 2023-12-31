using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CancelButtomHandler : MonoBehaviour
{
    public void OnButtonClick()
    {
        Popup();
    }

    private void Popup()
    {
        var seq = DOTween.Sequence();

        seq.Append(transform.DOScale(0.95f, 0.1f));
        seq.Append(transform.DOScale(1.05f, 0.1f));
        seq.Append(transform.DOScale(1.00f, 0.1f));

        seq.Play().OnComplete(() =>
        {
            UIManager.instance.popupWindow.Hide();
        });
    }
}
