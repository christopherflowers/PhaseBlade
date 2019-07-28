using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody rigidBody;

    public GameObject blockingIndicator;

    public float movementSpeed = 5.0f;
    public float jumpHeight = 175.0f;
    public float rotationSensitivity = 4.0f;

    float horizontalInput = 0.0f;
    float verticalInput = 0.0f;

    float horizontalRotationInput = 0.0f;
    float verticalRotationInput = 0.0f;

    bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    // Could move code to their own functions.
    void Update()
    {
        // JUMP
        // TODO : check to see if player is in contact with ground, if so then the player can jump, if not then they cannot jump.
        if (Input.GetButtonDown("A"))
        {
            // Have the player jump.
            Debug.Log("A button is being held down.");
            rigidBody.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        }

        // BLOCK
        if (Input.GetAxis("LT") > 0)
        {
            Debug.Log(Input.GetAxis("LT"));
            blockingIndicator.active = true;
        } else
        {
            blockingIndicator.active = false;
        }

        // MOVEMENT
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

        Debug.Log(rotationSensitivity);
        Debug.Log(horizontalRotationInput);

        // ROTATION INPUT
        // TODO : take into account that some people like to invert their look rotation.
        horizontalRotationInput = Input.GetAxis("Controller Right Horizontal");
        if (horizontalRotationInput > 0) {
            // rigidBody.transform.rotation = ();
            Debug.Log(horizontalRotationInput * rotationSensitivity);
            rigidBody.transform.Rotate(Vector3.up, (rotationSensitivity * horizontalRotationInput));
        } else if (horizontalRotationInput < 0)
        {
            Debug.Log(horizontalRotationInput * rotationSensitivity);
            rigidBody.transform.Rotate(Vector3.up, (rotationSensitivity * horizontalRotationInput));
        }

        /**
        verticalRotationInput = Input.GetAxis("Controller Right Vertical");
        if (verticalRotationInput > 0)
        {
            rigidBody.transform.Rotate(Vector3.up * (rotationSensitivity * verticalRotationInput), UnityEngine.Space.Self);
        } else if (verticalRotationInput < 0)
        {
            rigidBody.transform.Rotate(Vector3.up * (rotationSensitivity * verticalRotationInput), UnityEngine.Space.Self);
        }
        **/

    }
}
