using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class FlagBehaviour : MonoBehaviour
{
    public GameObject FlagPrefab;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            Instantiate(FlagPrefab, transform.position, Quaternion.identity);
        }
    }

}
