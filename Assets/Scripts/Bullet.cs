using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 10f;
    public Vector3 mousePos;
    public Vector3 playerPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move() 
    {
        
        // Get mouse position in world space
        mousePos = Input.mousePosition;
        playerPos = transform.position;
        //  // Setze die Z-Komponente auf den Abstand zur Kamera, um die Position im Weltkoordinatensystem zu erhalten
        // mousePos.z = Camera.main.nearClipPlane;

        // // Mausposition im Weltkoordinatensystem
        // Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector3 direction = (mousePos - playerPos).normalized;
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}
