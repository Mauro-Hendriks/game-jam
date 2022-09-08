using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed = 10;
    private Rigidbody2D player;
    void Awake()
    {
        player = GetComponent<Rigidbody2D>();

    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-movementSpeed, 0) * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 0);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(movementSpeed, 0) * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, -180, 0);

        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, movementSpeed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -movementSpeed) * Time.deltaTime;
        }

    }
    void Update()
    {
        Movement();
    }
}
