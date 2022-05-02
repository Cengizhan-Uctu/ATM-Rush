using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIProgres : SingeltonGeneric<UIProgres>
{
    [SerializeField] Image hend;
    [SerializeField] Image hendArow;
    [SerializeField] GameObject topThePlay;
    [SerializeField] GameObject moneyParent;
    [SerializeField] GameObject gameEndPanel;
    [SerializeField] GameObject startPanel;
    [SerializeField] Text totoalMoneyText;
    [SerializeField] Image[] moneys;
    [SerializeField] RectTransform[] moneysTransform;
    public static int totalMoney;
    #region singelton
    private void Awake()
    {
        MakeSingelton(this);
    }
    #endregion
    void Start()
    {
        StartPanel();
    }

    void StartPanel()
    {
        AnimationManger.Instance.IdleAnimation();
        hend.rectTransform.DOAnchorPosX(300, 1).SetLoops(-1, LoopType.Yoyo);
        PlayerMoveForward.Instance.speed = 0;
        PlayerMove.Instance.Speed = 0;
        SetActiveStartPanel(true);
    }
    public void StartBtn()
    {
        hend.gameObject.SetActive(false);
        hendArow.gameObject.SetActive(false);
        topThePlay.SetActive(false);
        AnimationManger.Instance.RunAnimation();
        PlayerMoveForward.Instance.speed = 10;
        PlayerMove.Instance.Speed = 2;
    }

    public void NoThanksBtn()
    {
       
        moneyParent.SetActive(true);
        for (int i = 0; i < moneys.Length; i++)
        {
            moneys[i].rectTransform.DOAnchorPos(moneysTransform[i].position, 0.3f)
                .OnComplete(() => StartCoroutine(MoneyMoveIcone()));
        }
    }
    public void SetActiveStartPanel(bool TureOrFalse) { startPanel.SetActive(TureOrFalse); }
    public void SetActiveGameEndPanel(bool TureOrFalse) { gameEndPanel.SetActive( TureOrFalse); totoalMoneyText.text = totalMoney.ToString(); }
    IEnumerator MoneyMoveIcone()
    {
        yield return new WaitForSeconds(1);
        for (int i = 0; i < moneys.Length; i++)
        {
            moneys[i].rectTransform.DOAnchorPos(new Vector3(500, 1500, 0), 1f);// next lwl
        }

    }
}
