using UnityEngine;
using UnityEngine.InputSystem;

public class HelloWorld : MonoBehaviour
{
    [SerializeField] string userName = "Mark";
    [SerializeField] InputAction button1;
    int counter = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"Hello, {userName}!");
    }

    // Update is called once per frame
    void Update()
    {
        if (button1.WasPressedThisFrame())
        {
            Debug.Log($"{userName} pressed the button!");
            counter++;
            Debug.Log($"The button has been pressed {counter} times");
            Debug.Log($"Pressed at {System.DateTime.Now}");
        }
    }

    void OnEnable()
    {
        button1.Enable();
    }

    void OnDisable()
    {
        button1.Disable();
    }
}
