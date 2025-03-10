using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    [SerializeField] private Rigidbody gate;
    [SerializeField] private float force;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            gate.AddForce(Vector3.back * force, ForceMode.Impulse);
        }
    }
}
