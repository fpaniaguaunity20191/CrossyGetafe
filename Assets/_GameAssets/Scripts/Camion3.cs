using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camion3 : Camion {
    public float speed;
    public Transform origin;
    public int deltaDistancia;

    private void Start()
    {
        this.transform.position = origin.position;
        StartCoroutine(Mover(deltaDistancia));
    }

    IEnumerator Mover(int deltaDistancia)
    {
        for (int i = 0; i < deltaDistancia; i++)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            yield return null;//Aquí para
        }
    }
}
