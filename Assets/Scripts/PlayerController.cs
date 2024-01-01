using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    Vector2 moveInput;

    public float walkSpeed = 5f;

    private bool _isMoving = false;

    private bool _isRunning = false;

    public bool IsMoving { get
        {
            return _isMoving
        } private set {
            _isMoving = value;
            animator.SetBool("isMoving", value);
        }
    }

    public bool IsRunning { 
        get
            {
                return _isRunning
            }
        private set
        {
            _isRunning = value;
            animator.SetBool("isRunning", value);
        }
    }

    Rigidbody2D rb;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveInput.x * walkSpeed * Time.fixedDeltaTime, rb.velocity.y);
    }

    private void Awake()
    {   
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnAttack()
    {

    }

    public void OnMove(InputAction.CallbackContext context)
    {
       moveInput = context.ReadValue<Vector2>();

       IsMoving = moveInput != Vector2.zero;

        
    }
}
