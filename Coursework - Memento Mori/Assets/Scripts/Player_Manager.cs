using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Player_Manager : MonoBehaviour
{
    [SerializeField] float verticalMoveSpeed = 0f;
    [SerializeField] float horizontalMoveSpeed = 0f;
    DefaultInputActions playerInputs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerInputs.Player.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.
    }


}
