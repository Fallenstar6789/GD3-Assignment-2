using UnityEngine;
using System.Collections;
using System.Collections.Concurrent;
using UnityEngine.Tilemaps;
using Unity.Burst.CompilerServices;

public class Movement : MonoBehaviour
{

    public float speed = 10f;
    private Rigidbody2D m_RB;
    private Vector2 moveAmount;
    private const string horizontal = "Horizontal";
    private const string vertical = "Vertical";
    void Start()
    {
        m_RB = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        moveAmount = moveInput.normalized * speed;



    }

    private void FixedUpdate()
    {
        m_RB.MovePosition(m_RB.position + moveAmount * Time.fixedDeltaTime);
    }







}
