using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camion : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Pollo")
        {
            Camera.main.transform.SetParent(null);
            Destroy(collision.gameObject);
        }
    }
}
