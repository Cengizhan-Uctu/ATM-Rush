using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class StackMoney : MonoBehaviour
{
    public List<GameObject> Moneys = new List<GameObject>();
    #region 
    public static StackMoney Instance;
    [SerializeField] GameObject pickup;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    #endregion
    private void Start()
    {
        Moneys.Add(gameObject.transform.GetChild(0).gameObject);
    }
    public void Stack(GameObject money, int index)
    {
        money.transform.SetParent(transform);
        Vector3 newPos = Moneys[index].transform.localPosition;
        newPos.z += 1;
        Moneys.Add(money);
        money.transform.localPosition = newPos;
        StartCoroutine(MoneyScale());
    }
    IEnumerator MoneyScale()
    {
        for (int i = Moneys.Count - 1; i > 0; i--)
        {
            if (Moneys[i] != null)
            {
                Vector3 Scale = new Vector3(1, 1, 1);
                Scale *= 1.4f;
                Moneys[i].transform.DOScale(Scale, 0.1f).OnComplete(() => Moneys[i].transform.DOScale(new Vector3(1, 1, 1), 0.1f));
                yield return new WaitForSeconds(0.1f);
            }

        }
    }
    public void MoveMoney()
    {
        for (int i = 1; i < Moneys.Count; i++)
        {
            if (Moneys[i] != null)
            {
                Vector3 pos = Moneys[i].transform.localPosition;
                pos.x = Moneys[i - 1].transform.localPosition.x;
                Moneys[i].transform.DOLocalMove(pos, 0.2f);
            }
        }
    }

    public void MoveDefauld()
    {
        for (int i = 1; i < Moneys.Count; i++)
        {
            if (Moneys[i] != null)
            {
                Vector3 Pos = Moneys[i].transform.localPosition;
                Pos.x = Moneys[0].transform.localPosition.x;
                Moneys[i].transform.DOLocalMove(Pos, 0.5f);
            }
              
        }
    }
    public void RemoveList(GameObject indexObj)
    {
        int index = Mathf.Abs(Moneys.IndexOf(indexObj));
        Destroy(indexObj);
        Debug.Log(index+"index");
        List<GameObject>Unlist= Moneys.GetRange(Mathf.Abs(index), Mathf.Abs(Moneys.Count - index));
        Moneys.RemoveRange(index, Mathf.Abs(Moneys.Count - index));
        foreach (var item in Unlist)
        {
            Vector3 newvec= transform.TransformPoint(item.transform.position)/2;
            item.GetComponent<MoneySpread>().Spell(newvec, pickup);
           
        }
    } 
}
