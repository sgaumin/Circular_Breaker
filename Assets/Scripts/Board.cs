using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] private Transform centerPoint;
    [SerializeField] private Transform ball;

    void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");
        transform.RotateAround(centerPoint.position, transform.forward, input * 200 * Time.deltaTime);
    }
}
