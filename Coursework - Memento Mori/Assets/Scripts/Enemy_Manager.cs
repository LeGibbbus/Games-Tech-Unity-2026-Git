using UnityEngine;

public class Enemy_Manager : MonoBehaviour

{

    [SerializeField] float moveSpeed = 0.1f;
    Rigidbody2D enemyBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject player = GameObject.Find("Player");
        enemyBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 3);
    }
}
