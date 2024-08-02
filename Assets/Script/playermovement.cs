using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playermovement : MonoBehaviour
{


    [SerializeField]
    public float speed = 5f;

    [SerializeField]
    private float jumpHeight;

    [SerializeField]
    public float gr = -9.81f;

    private Transform cameraMain;

    private CharacterController karakter;
    

    public Vector3 velocity;
    public bool groundPlayer;
    public bool isMoving;
    public bool isJump;
    public bool isGrounded;

    
    public FixedJoystick joystik;
    public Player playerInput;

    private void Awake()
    {
        playerInput = new Player();      
        karakter = GetComponent<CharacterController>();
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }

    

    // Update is called once per frame
    private void Start()
    {
        cameraMain = Camera.main.transform;
      

    }

    void Update()
    {
        groundPlayer = karakter.isGrounded;
        if (groundPlayer && velocity.y < 0)
        {
            velocity.y = 0f;
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        //Joystick implementation
        float x = joystik.Horizontal;
        float z = joystik.Vertical;

        //Player movement
        Vector3 move = (cameraMain.right * x + cameraMain.forward * z);
        move.y = 0f;
        karakter.Move(move * speed * Time.deltaTime);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }


        //Player jump
        if (playerInput.PlayerMain.Jump.triggered && groundPlayer) 
        {
            velocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gr);
            isJump = true;
           
        }
        else
        {
            isJump = false;
        }


        //Player Gravity
        velocity.y += gr * Time.deltaTime;
        karakter.Move(velocity * Time.deltaTime);

       



    }
    


}
