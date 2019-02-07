using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camion1 : Camion {
    public Transform origin;
    public float speed;

    private void Awake()
    {
        transform.position = origin.position;
    }
    void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        transform.position = origin.position;
    }
}
