using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
        shoot();
    }

    void movePlayer() {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementVector = new Vector3(horizontalInput, verticalInput, 0f) * Time.deltaTime;
        transform.Translate(movementVector * speed, Space.World);
    }

    void shoot() {
        if(Input.GetMouseButtonDown(0)) {
            GameObject bullet = Instantiate(Bullet, transform.position, transform.rotation);
        }
    }
}
