using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    [SerializeField] private Rigidbody spring;
    [SerializeField] private float force;

    // Start is called before the first frame update
    void Start()
    {
        //spring.AddForce(Vector3.right * force, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        //spring.AddForce(Vector3.right * force, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball")
        {
            spring.AddForce(Vector3.right * force, ForceMode.Impulse);
        }
    }
}
