using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Player_Manager : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 50f;
    DefaultInputActions playerInputs;
    InputAction moveAction;

    Rigidbody2D body;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerInputs = new DefaultInputActions();
        playerInputs.Player.Enable();
        moveAction = playerInputs.Player.Move;
        body = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame

    //private void OnEnable()
    //{
       // playerInputs.Player.Enable();
    //}

    //private void OnDisable()
    //{
        //playerInputs.Player.Disable();
    //}
    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector2 moveDirection = moveAction.ReadValue<Vector2>();
        body.MovePosition(body.position + moveDirection * MoveSpeed);
    }


}
