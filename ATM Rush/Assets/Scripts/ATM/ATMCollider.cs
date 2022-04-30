using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ATMCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CollectedMoney"))
        {
            other.gameObject.transform.DOScale(new Vector3(0.1f, 0.1f, 0.1f), 0.4f).OnComplete(() => other.gameObject.SetActive(false));
            // ekrandaki rakamı arttır
        }
    }
}
