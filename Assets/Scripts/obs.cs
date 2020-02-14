using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obs : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Player") == 0)
        {
            gameObject.SetActive(false);
            DataManager.Instance.star -= 1;
        }


    }
}
