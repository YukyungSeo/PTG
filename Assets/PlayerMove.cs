using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float jump = 15f;
    public float jump2 = 20f;

    int jumpCount = 0;

    public void Jump_Btn()
    {
        if (!DataManager.Instance.PlayerDie) { 
            if (jumpCount == 0)
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump, 0);
                jumpCount += 1;
            }
            else if (jumpCount == 1)
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(3, jump2, 0);
                jumpCount += 1;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.CompareTo("floor") == 0)
        {
            jumpCount = 0;
        }
        if (collision.gameObject.tag.CompareTo("obs") == 0)
        {
            DataManager.Instance.star -= 1;
        }
        if (collision.gameObject.tag.CompareTo("d_rope") == 0)
        {
            DataManager.Instance.PlayTimeCurrent -= 2f;
        }

    }
}
