using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class BandCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("CollectedMoney"))
        {
            Debug.Log("dasda");
            other.gameObject.transform.parent = transform;
            other.gameObject.transform.DOMoveX(-3, 1);
        }
    }
}
