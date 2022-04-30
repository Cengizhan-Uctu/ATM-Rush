using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyTransformation : MonoBehaviour
{
    public int MoneyChildCount;
   
    private void Start()
    {
        MoneyChildCount = 0;
        if (MoneyChildCount == 0)
        {
            transform.GetChild(MoneyChildCount).gameObject.SetActive(true);
        }
    }
    
    public void TransformationMoney()
    {

        MoneyChildCount++;
      
        if (MoneyChildCount == 0)
        {
            transform.GetChild(MoneyChildCount).gameObject.SetActive(true);
        }
        else if (MoneyChildCount == 1)
        {
            transform.GetChild(MoneyChildCount).gameObject.SetActive(true);
            transform.GetChild(MoneyChildCount - 1).gameObject.SetActive(false);
        }
        else if (MoneyChildCount == 2)
        {
            MoneyChildCount = 2;
            transform.GetChild(MoneyChildCount).gameObject.SetActive(true);
            transform.GetChild(MoneyChildCount - 1).gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gate"))
        {
           TransformationMoney();
        }
    }
}
