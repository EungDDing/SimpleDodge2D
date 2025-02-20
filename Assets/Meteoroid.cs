using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteoroid : MonoBehaviour
{
    private Vector3 moveDir;
    private Vector3 randomPos;
    [SerializeField] private float moveSpeed;

    public delegate void OnDie();
    public static event OnDie GameOver;

    private void Awake()
    {
        moveSpeed = 5.0f;
        randomPos.x = Random.Range(-5.0f, 5.0f);
        randomPos.y = Random.Range(-2.0f, 2.0f);
        randomPos.z = 0;

        moveDir = randomPos - transform.position;
        moveDir.Normalize();

        //float angle = Mathf.Atan2(moveDir.y, moveDir.x) * Mathf.Rad2Deg - 90f;
        //transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));

        transform.up = moveDir;
    }

    private void Update()
    {
        transform.position += moveDir * (moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (GameOver != null)
            {
                GameOver.Invoke();
            }
            Debug.Log("Ãæµ¹");
        }
    }
}
