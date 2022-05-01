using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class BandCollider : MonoBehaviour
{
    int totalMoney;
    [SerializeField] GameObject gameoverTower;
    [SerializeField] GameObject player;
    [SerializeField] GameObject Maincamera;
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("CollectedMoney"))
        {
            totalMoney++;
            if (totalMoney == 1)
            {
                Instantiate(other.gameObject, new Vector3(other.transform.position.x, .6f, 0), Quaternion.identity);
                Destroy(other.gameObject);
            }
            StackMoney.Instance.Moneys.Clear();
            other.gameObject.transform.parent = transform;
            other.GetComponent<MoneySpread>().BandMove(gameObject);
        }
        if (other.CompareTag("Character"))
        {
            PlayerMoveForward.Instance.speed = 0;
            other.gameObject.transform.GetChild(0).GetComponent<Animator>().SetBool("IdleAnimation",true);
            StartCoroutine(GameEndProgres());

        }
    }
    IEnumerator GameEndProgres()
    {
        yield return new WaitForSeconds(0.5f);
        gameoverTower.SetActive(true);
        player.SetActive(false);
        Maincamera.SetActive(false);
    }
}
