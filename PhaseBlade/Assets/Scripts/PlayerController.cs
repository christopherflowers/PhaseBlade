using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rigidBody;

    public float movementSpeed = 5.0f;

    public float horizontalInput = 0.0f;
    public float verticalInput = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    // Could move code to their own functions.
    void Update()
    {
        horizontalInput = Input.GetAxis("Controller Left Horizontal");
        if (horizontalInput < 0)
        {
            rigidBody.transform.Translate(Vector3.left * ( -1 * movementSpeed * horizontalInput) * Time.deltaTime);
            Debug.Log(movementSpeed * horizontalInput);
        } else if (horizontalInput > 0)
        {
            rigidBody.transform.Translate(Vector3.right * (movementSpeed * horizontalInput) * Time.deltaTime);
        }

        verticalInput = Input.GetAxis("Controller Left Vertical");
        if (verticalInput < 0)
        {
            rigidBody.transform.Translate(Vector3.back* (-1 * movementSpeed * verticalInput) * Time.deltaTime);
        } else if (verticalInput > 0)
        {
            rigidBody.transform.Translate(Vector3.back * (-1 * movementSpeed * verticalInput) * Time.deltaTime);
        }
    }
}
