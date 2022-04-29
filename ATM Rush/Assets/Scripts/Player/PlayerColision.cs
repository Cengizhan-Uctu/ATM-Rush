using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColision : MonoBehaviour
{
    // bagzi carpısmaları layer kullanarak engelledim. bak Edit>Prajeck Settings> Phsiscs
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Money"))
        {
            other.GetComponent<BoxCollider>().isTrigger = false;
            other.GetComponent<Rigidbody>().isKinematic = true;
            other.tag = "CollectedMoney";
            other.gameObject.AddComponent<PlayerColision>();
            StackMoney.Instance.Stack(other.gameObject, StackMoney.Instance.Moneys.Count - 1);
        }
   
    }
   
}
