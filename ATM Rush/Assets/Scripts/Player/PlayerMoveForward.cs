using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class PlayerMoveForward : SingeltonGeneric<PlayerMoveForward>
{
    [SerializeField] float speed;
    #region singelton
    private void Awake()
    {
        MakeSingelton(this);
    }
    #endregion

    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
    }
    public void CollisionObstacle()
    {
        transform.DOMoveZ(transform.position.z - 15, 0.7f);
    }
}
