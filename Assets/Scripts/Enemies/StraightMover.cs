using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightMover : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    void Update()
    {
        transform.position += Vector3.up * (speed * Time.deltaTime);
    }
}
