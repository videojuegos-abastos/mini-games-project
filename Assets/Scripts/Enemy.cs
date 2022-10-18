using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Range(0, .5f)]
    [SerializeField]
    float velocity;

    Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = Vector3.zero - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * Time.deltaTime;
    }
}
