using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    [Header("Player input stats")]
    public float moveSpeed = 5f;

    [SerializeField] private Vector2 moveInput;
    public Vector2 MoveInput => moveInput;

    [Header("Components")]
    private Rigidbody2D rb;
    public Rigidbody2D Rb => rb;

    [SerializeField] private Animator animator;
    private HealthSystem healthSystem;

    public StateMachine stateMachine;

    [Header("Events")]
    [SerializeField] private UnityEvent healthChecker;

    private void Awake()
    {
        stateMachine = new StateMachine(this);
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
        healthSystem = GetComponent<HealthSystem>();
    }

    private void Start()
    {
        animator.SetBool("Walking", false);
        stateMachine.Initialize(stateMachine.idleState);
    }

    private void Update()
    {
       
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");


        if(stateMachine.CurrentState == stateMachine.walkingState)
        {
            animator.SetBool("Walking", true);
        }
        else
        {
            animator.SetBool("Walking", false);
        }

        stateMachine.Udpate();


        if(healthSystem.CurrentHealth <= 0)
        {
            healthChecker?.Invoke();
        }
    }

    void FixedUpdate()
    {
        
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
    }


}
