using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    Vector2 moveInput;

    public GameObject bullet;
    [SerializeField] Transform spawnBullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(bullet, spawnBullet.position, transform.rotation);
        }
    }
    void Movement()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");

        transform.Translate(moveInput * Time.deltaTime * moveSpeed);
    }
}
