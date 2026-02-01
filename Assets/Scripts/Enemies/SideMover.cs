using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SideMover : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float flipTime = 2f;

    private float nextTime = 0;
    private int direction = 1;

    void Update()
    {
        if (nextTime <= 0)
        {
            direction *= -1;
            nextTime = flipTime;
        }
        
        nextTime -= Time.deltaTime;
        transform.position += Vector3.right * (direction * speed * Time.deltaTime);
    }
}
