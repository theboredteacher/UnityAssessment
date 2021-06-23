using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{

	public CharacterController controller;

	public float speed = 12f;

	public float gravity = - 9.9f;

	public float customGravity = 100f;

	public float jumpHeight = 30f;

	Vector3 velocity;

    // Update is called once per frame
    void Update()
    {

    	float x = Input.GetAxis("Horizontal");
    	float z = Input.GetAxis("Vertical");

    	Vector3 move = transform.right *  x + transform.forward *z;

    	controller.Move(move * speed * Time.deltaTime);
        
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKeyDown ("space")){
         velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
     	} 
    }

 
}
