using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbitar : MonoBehaviour
{
    public float rotationSpeed = 20f;
    public Transform pivote;

    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(pivote.transform.position, Vector3.up, rotationSpeed*Time.deltaTime);
    }
}
