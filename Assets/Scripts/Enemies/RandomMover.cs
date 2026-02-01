using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMover : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float interval = 2f;

    private Vector3 targetDirection = Vector2.zero;
    private float nextTime = 0;

    void Update()
    {
        if (nextTime <= 0)
        {
            targetDirection = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f).normalized;
            nextTime = interval;
        }
        
        nextTime -= Time.deltaTime;
        transform.position += targetDirection * (speed * Time.deltaTime);
    }
}
