using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Player_Manager : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 0f;
    DefaultInputActions player_Inputs;
    InputAction moveAction;

    Rigidbody2D body;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        player_Inputs = new DefaultInputActions();
        moveAction = player_Inputs.Player.Move;

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

        if (interactAction.triggered) ;
    }

    void MovePlayer()
    {
        Vector2 PlayerPosition = transform.position; //sets Vector 2 current position to that of the player object
    }


}
