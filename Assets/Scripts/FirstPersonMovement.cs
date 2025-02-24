using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FirstPersonMovement : MonoBehaviour
{
//[SerializeField] GameObject botones;

    public CharacterController controller;
    public float speed = 10f;
    public float gravity = -9.8f;
    public Transform groundCheck;
    public float sphereRadius;


    public LayerMask groundLayer;


    private Vector3 direction;
    [SerializeField] bool canMove;



    public Animator anim;
    public Transform model;



    private void Start()
    {
        canMove = true;
//botones = GameObject.FindGameObjectWithTag("Botones");

    }




    void Update()
    {
        if (canMove)
        {
            float xInput = Input.GetAxis("Horizontal");
            float zInput = Input.GetAxis("Vertical");

            Vector3 move = new Vector3(-xInput, 0f, zInput);
            controller.Move(move * speed * Time.deltaTime);

            direction.z = zInput * speed;
            direction.x = -xInput * speed;

            direction.y += gravity * Time.deltaTime;

            bool isGrounded = Physics.CheckSphere(groundCheck.position, sphereRadius, groundLayer);
           // anim.SetBool("isGrounded", true);

            if (zInput != 0)
            {
              //  playerShoot.ChangeIfCanShoot(false);
                anim.SetFloat("speed", Mathf.Abs(zInput));
                Quaternion newRotation = Quaternion.LookRotation(new Vector3(0, 0, zInput));
                model.rotation = newRotation;
  // botones.SetActive(false);

            }


            //else
            //{
            //    botones.SetActive(true);
            //}

            if (-xInput != 0)
            {
               // playerShoot.ChangeIfCanShoot(false);
                anim.SetFloat("speed", Mathf.Abs(-xInput));
                Quaternion newRotation = Quaternion.LookRotation(new Vector3(-xInput, 0, 0));
                model.rotation = newRotation;
    // botones.SetActive(false);


            }



            //else
            //{
            //    playerShoot.ChangeIfCanShoot(true);
            //}

        }

        controller.Move(direction * Time.deltaTime);

    }
}