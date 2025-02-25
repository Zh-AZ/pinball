using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    [SerializeField] private Rigidbody[] bricks;
    private float seconds;


    // Start is called before the first frame update
    void Start()
    {
        bricks = GetComponentsInChildren<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;    
        
        if (seconds > 30)
        {
            for (int i = 0; i < bricks.Length; i++)
            {
                bricks[i].useGravity = true;
            }
        }
    }
}
