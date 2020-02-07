using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerPlatformerMovemen : MonoBehaviour
{

    public float movementSpeed = 5.0f;
    public float jumpSpeed = 500.0f;
    private Rigidbody2D rigidbody;
    private bool isGrounded = true;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movementX = Input.GetAxis("Horizontal") * movementSpeed *Time.deltaTime;
        if (Input.GetButtonDown("Jump") && isGrounded) {
            Debug.Log("Jump");
            rigidbody.AddForce(new Vector3(0.0f, jumpSpeed, 0.0f));
        }
        transform.Translate(new Vector3(movementX, 0.0f, 0.0f));
    }
}
