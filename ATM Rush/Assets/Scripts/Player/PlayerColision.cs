using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Money"))
        {
            other.GetComponent<BoxCollider>().isTrigger = false;
            other.GetComponent<Rigidbody>().isKinematic = true;
            other.tag = "Untagged";
            other.gameObject.AddComponent<PlayerColision>();
         
            StackMoney.Instance.Stack(other.gameObject, StackMoney.Instance.Moneys.Count - 1);
        }
    }
}
