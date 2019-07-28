using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    // Camera mainCamera;
    Transform transform;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        // mainCamera = this.GetComponent<Camera>();
        transform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(player);

        // If down dpad is pushed switch to first person camera.
        // I could lerp but I feel like that would feel slow and weird.
        // I could just change cameras and switch over to a "First Person Camera"
        // and then switch back to the "Third Person Camera"

        
    }
}
