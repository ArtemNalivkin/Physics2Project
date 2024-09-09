using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceSpringBeh : MonoBehaviour
{
    [SerializeField] private Vector3 startPosition;
    [SerializeField] private float force = 5.0f;
    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (startPosition.z <= transform.position.z)
        {
            _rb.velocity = Vector3.zero;
            _rb.AddForce(Vector3.back * force, ForceMode.Impulse);
        }
    }
}
