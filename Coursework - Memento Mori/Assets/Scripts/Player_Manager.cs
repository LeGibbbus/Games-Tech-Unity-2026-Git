using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Player_Manager : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 5f;
    DefaultInputActions player_Inputs;
    InputAction moveAction;

    Rigidbody2D body;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        player_Inputs = new DefaultInputActions();
        moveAction = player_Inputs.Player.Move;
        Vector2 movementDirection = Vector2.zero;

    }

    // Update is called once per frame

    private void OnEnable()
    {
        player_Inputs.Player.Enable();
    }

    private void OnDisable()
    {
        player_Inputs.Player.Disable();
    }
    void Update()
    {
        MovePlayer();
        Vector2 movement = Vector2.zero;
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movement += Vector2.down;
        }
        Vector2 velocity = movement.normalized * MoveSpeed;
        body.linearVelocity = velocity;
    }

    void MovePlayer()
    {
        
        Vector2 moveDirection = moveAction.ReadValue<Vector2>();
        body.MovePosition(body.position + moveDirection * MoveSpeed *  Time.deltaTime);
    }


}
