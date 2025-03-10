using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    [SerializeField] private Rigidbody spring;
    [SerializeField] private float force;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball")
        {
            spring.AddForce(Vector3.right * force, ForceMode.Impulse);
        }
    }
}
