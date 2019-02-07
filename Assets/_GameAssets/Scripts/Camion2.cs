using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camion2 : Camion {
    public Transform startPoint;
    public Transform endPoint;
    public float speed;
    float porcentaje = 0.0f;

	void Start () {
        transform.position = startPoint.position;
	}
	
	void Update () {
        porcentaje = porcentaje + Time.deltaTime*speed;
        transform.position = Vector3.Lerp(startPoint.position, endPoint.position, porcentaje);
        transform.rotation = Quaternion.Lerp(startPoint.rotation, endPoint.rotation, porcentaje);
        if (porcentaje >= 1)
        {
            porcentaje = 0;
        }
	}
}
