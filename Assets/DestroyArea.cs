using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyArea : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("�浹 Ż��");
        if (collision.CompareTag("Meteoroid")) 
        {
            GameObject.Destroy(collision.gameObject);
        }
    }
}
