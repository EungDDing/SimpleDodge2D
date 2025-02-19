using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUFO : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private Vector3 moveDir;
    private bool isMove;

    private void Awake()
    {
        isMove = true;
        moveDir = Vector3.zero;
        moveSpeed = 4.0f;
    }
    private void Update()
    {
        if (isMove)
        {
            moveDir.x = Input.GetAxisRaw("Horizontal");
            moveDir.y = Input.GetAxisRaw("Vertical");
            moveDir.z = 0;

            transform.position += moveDir * (moveSpeed * Time.deltaTime);
        }
    }
    public void StopMove()
    {
        isMove = false;
    }
}
