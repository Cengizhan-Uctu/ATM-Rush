using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("CollectedMoney"))
        {
            StackMoney.Instance.RemoveList(other.gameObject);
        }
    }

}
