using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject Character;
    
    Vector3 distance;
    private void Start()
    {
        distance = transform.position - Character.transform.position;

    }
    private void LateUpdate()
    {
        transform.position = Character.transform.position + distance;
    }
   

}
