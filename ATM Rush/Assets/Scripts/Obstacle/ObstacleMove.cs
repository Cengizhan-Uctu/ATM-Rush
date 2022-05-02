using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ObstacleMove : MonoBehaviour
{
    [SerializeField] ObstacleScriptableobject ObstacleValues;
    bool YoyoMove = false;
    bool YoyoRotate = false;
    float speed;
    float xAxisiValue;
    bool xAxsis;
    private void Start()
    {
        YoyoMove = ObstacleValues.YoyoMove;
        YoyoRotate = ObstacleValues.YoyoRotate;
        speed = ObstacleValues.speed;
        xAxsis = ObstacleValues.xAxsis;
        if (xAxsis)
        {
            xAxisiValue = 1;
        }
        else
        {
            xAxisiValue = -1;
        }

        if (YoyoMove)
        {
            float xPosBegan = transform.position.x * xAxisiValue;
            transform.DOLocalMoveX(xPosBegan, speed).SetLoops(-1, LoopType.Yoyo);
        }
        if (YoyoRotate)
        {
            transform.DORotate(new Vector3(0, 0, 80)* xAxisiValue, 1f, RotateMode.Fast).SetLoops(-1, LoopType.Yoyo);
        }

    }
}
