using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoneySpread : MonoBehaviour
{
   
    public void Spell(Vector3 pos, GameObject pickup)
    {
        int posX = Random.Range(-3, 5);
        int posZ = Random.Range(7,13);
        transform.parent = pickup.transform;
        pickup.transform.position = pos;
        transform.DOLocalMove(new Vector3(posX, transform.localPosition.y+1, posZ), 0.3f).OnComplete(()=>transform.DOLocalMoveY(0,0.2f)).SetEase(Ease.InBounce);
        transform.DOPunchScale( new Vector3(.3f,.3f,.3f), 0.3f);
        gameObject.tag = "Money";
    }
    public void BandMove(GameObject band)
    {
        transform.parent = band.transform;
        transform.DOLocalMove(new Vector3(transform.localPosition.x, 0.6f, 0),.1f).OnComplete(() => transform.DOLocalMoveX(-3,0.5f));
        if (transform.localPosition.z > 0)
        {
            transform.parent = band.transform;
            transform.DOLocalMove(new Vector3(transform.localPosition.x, 0.6f, 0), .1f).OnComplete(() => transform.DOLocalMoveX(-3, 0.5f));
        }
    }
      
}
