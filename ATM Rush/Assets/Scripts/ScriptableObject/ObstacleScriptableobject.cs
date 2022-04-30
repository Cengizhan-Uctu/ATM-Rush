using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Obstacle",menuName =" New Obstacle Type")]
public class ObstacleScriptableobject : ScriptableObject
{
    public bool YoyoMove = false;
    public bool YoyoRotate = false;
    public bool Rotate = false;
    public float speed = 2;
    public bool xAxsis;
}
