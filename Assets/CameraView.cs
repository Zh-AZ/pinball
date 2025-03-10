using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour
{
    [SerializeField] private Camera camera_1;
    [SerializeField] private Camera camera_2;
    private float seconds;

    // Start is called before the first frame update
    void Start()
    {
        camera_1.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;

        if (seconds > 40 && seconds < 70)
        {
            camera_1.gameObject.SetActive(false);
            camera_2.gameObject.SetActive(true);
        }
    }
}
