using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{
    [SerializeField] private GameObject _camera;
    private Rigidbody ball;

    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (_camera.activeSelf == true)
        {
            ball.isKinematic = false;
        }
    }
}
