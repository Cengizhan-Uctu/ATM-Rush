using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class FinishATM : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.DOScale(new Vector3(0.1f, 0.1f, 0.1f), 0.4f).OnComplete(() => other.gameObject.SetActive(false));
    }
}
