using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATMBandOfset : MonoBehaviour
{
    Material mat;
    void Start()
    {
         mat = gameObject.GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        mat.mainTextureOffset += Vector2.down*Time.deltaTime;
    }
}
