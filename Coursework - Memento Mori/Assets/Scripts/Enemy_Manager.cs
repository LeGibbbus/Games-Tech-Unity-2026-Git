using UnityEngine;

public class Enemy_Manager : MonoBehaviour

{

    [SerializeField] float moveSpeed = 0.1f;
    Rigidbody2D enemyBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
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
