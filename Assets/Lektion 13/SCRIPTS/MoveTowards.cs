using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    public Transform target;
    public float t;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 startPoint = transform.position;
        Vector3 targetPoint = target.position;
        transform.position = Vector3.MoveTowards(startPoint, Vector3.Lerp(startPoint, targetPoint, t), speed);
    }
}
