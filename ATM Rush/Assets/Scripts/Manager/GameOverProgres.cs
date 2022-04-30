using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class GameOverProgres : MonoBehaviour
{
    [SerializeField] GameObject incresMoney;
    [SerializeField] GameObject Tower;
    void Start()
    {
        transform.DOMove(new Vector3(0, transform.position.y, Tower.transform.position.z - 4), 1).OnComplete(() => StartCoroutine(incresMoneyTower(10)));
        transform.DORotate(Vector3.zero, 1f, RotateMode.Fast);

    }


    IEnumerator incresMoneyTower(int hight)
    {
        for (int i = 0; i < hight; i++)
        {

            GameObject newMoney = Instantiate(incresMoney, transform.position, Quaternion.identity);
            newMoney.transform.DOPunchScale(new Vector3(.3f, .3f, .3f), 0.2f);
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.7f, transform.position.z);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
