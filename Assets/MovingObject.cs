using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    [SerializeField] private Transform point1, point2;
    [SerializeField] private float speed = 1.0f;

    void Update()
    {
        transform.position = Vector3.Lerp(point1.position,
                                          point2.position,
                                          Mathf.Sin(Time.time*speed)/2.0f + 0.5f);
    }
}
