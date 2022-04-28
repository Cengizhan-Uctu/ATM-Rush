using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class StackMoney : MonoBehaviour
{
    public List<GameObject> Moneys = new List<GameObject>();
    #region 
    public static StackMoney Instance;
    private void Awake()
    {
        if (Instance==null)
        {
            Instance = this;
        }
    }
    #endregion
    private void Start()
    {
        Moneys.Add(gameObject);
    }
    public void Stack(GameObject money, int index)
    {
        money.transform.SetParent(transform);
        Vector3 newPos = Moneys[index].transform.localPosition;
        newPos.z += 1;
        newPos.x= 0;
        Moneys.Add(money);
        money.transform.localPosition = newPos;
        StartCoroutine(MoneyScale());
    }
    IEnumerator MoneyScale()
    {
        for (int i = Moneys.Count - 1; i > 0; i--)
        {
            Vector3 Scale = new Vector3(1, 1, 1);
            Scale *= 1.4f;
            Moneys[i].transform.DOScale(Scale, 0.1f).OnComplete(() => Moneys[i].transform.DOScale(new Vector3(1, 1, 1), 0.1f));
            yield return new WaitForSeconds(0.1f);
        }
    }
    public void MoveMoney()
    {
        for (int i = 1; i < Moneys.Count; i++)
        {
            Vector3 pos = Moneys[i].transform.localPosition;
            pos.x = Moneys[i - 1].transform.localPosition.x;
            Moneys[i].transform.DOLocalMove(pos, 0.2f);
        }
    }

    public void MoveDefauld()
    {
        for (int i = 1; i < Moneys.Count; i++)
        {
            Vector3 Pos = Moneys[i].transform.localPosition;
            Pos.x = Moneys[0].transform.localPosition.x;
            Moneys[i].transform.DOLocalMove(Pos, 0.5f);
        }
    }
}
