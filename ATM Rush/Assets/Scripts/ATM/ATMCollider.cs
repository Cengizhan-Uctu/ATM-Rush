using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class ATMCollider : MonoBehaviour
{
    [SerializeField] Text AtmText;
 
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CollectedMoney"))
        {
            int childCount;
            childCount = other.gameObject.GetComponent<MoneyTransformation>().MoneyChildCount;
            if (childCount == 0)
            {
                UIProgres.totalMoney += 50;
                AtmText.text = UIProgres.totalMoney.ToString();
            }
            if (childCount == 1)
            {
                UIProgres.totalMoney += 100;
                AtmText.text = UIProgres.totalMoney.ToString();
            }
            if (childCount == 2)
            {
                UIProgres.totalMoney += 200;
                AtmText.text = UIProgres.totalMoney.ToString();
            }
            StackMoney.Instance.RemoveList(other.gameObject);
           
        }
    }
}
