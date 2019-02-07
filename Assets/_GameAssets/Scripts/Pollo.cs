using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pollo : MonoBehaviour {
    public float fuerza;
    public Transform checkPointPos;
    public float radio;
    Rigidbody rb;
    Vector3 saltito;

    private bool EstaEnElSuelo()
    {
        bool enSuelo = false;
        Collider[] colliders = Physics.OverlapSphere(checkPointPos.position, radio);
        //Recorremos el array de colliders buscando algo etiquetado como "Floor"
        for(int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject.CompareTag("Floor"))
            {
                //Uno de los colliders está etiquetado como "Floor"
                enSuelo = true;
                break;//Dejamos de recorrer el array
            }
        }
        return enSuelo;
    }

    void Start () {
        rb = GetComponent<Rigidbody>();
        saltito = new Vector3(0, 2f, 1f);
    }
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && EstaEnElSuelo())
        {
            rb.AddRelativeForce(saltito * fuerza);
        }
    }

    
}
