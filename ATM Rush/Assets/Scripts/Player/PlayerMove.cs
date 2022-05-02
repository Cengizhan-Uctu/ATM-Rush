using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : SingeltonGeneric<PlayerMove>
{
    private float lastPosX;
    private float currentPosX;
    public float Speed;

    #region singelton
    private void Awake()
    {
        MakeSingelton(this);
    }
    #endregion
    void Update()
    {

        inputMove();
        Motor();

    }
    void Motor()
    {

        currentPosX = currentPosX * Time.deltaTime * Speed * -1;
        transform.position += new Vector3(currentPosX, 0, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -4.2f, 4.2f), transform.position.y, transform.position.z);
    }
    void inputMove()
    {

        if (Input.GetMouseButtonDown(0))
        {
            lastPosX = Input.mousePosition.x;
            StackMoney.Instance.MoveMoney();
        }
        else if (Input.GetMouseButton(0))
        {
            currentPosX = lastPosX - Input.mousePosition.x;
            lastPosX = Input.mousePosition.x;
            StackMoney.Instance.MoveMoney();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            StackMoney.Instance.MoveDefauld();
            currentPosX = 0;
        }
    }



}
