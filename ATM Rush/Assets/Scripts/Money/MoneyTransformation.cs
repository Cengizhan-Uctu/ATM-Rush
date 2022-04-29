using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyTransformation : MonoBehaviour
{
    int childCount;
    private void Start()
    {
        childCount = 0;
        if (childCount == 0)
        {
            transform.GetChild(childCount).gameObject.SetActive(true);
        }
    }
    public void TransformationMoney()
    {

        childCount++;
      
        if (childCount == 0)
        {
            transform.GetChild(childCount).gameObject.SetActive(true);
        }
        else if (childCount == 1)
        {
            transform.GetChild(childCount).gameObject.SetActive(true);
            transform.GetChild(childCount - 1).gameObject.SetActive(false);
        }
        else if (childCount == 2)
        {
            childCount = 2;
            transform.GetChild(childCount).gameObject.SetActive(true);
            transform.GetChild(childCount - 1).gameObject.SetActive(false);
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
