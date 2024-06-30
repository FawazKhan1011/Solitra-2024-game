using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public float moveSpeed = 2f; // Speed at which the platform moves
    public LayerMask layerMask;

    private Vector3 startPos;
    private Vector3 endPos;
    private bool movingToEnd = true;

    void Start()
    {
        startPos = startPoint.position;
        endPos = endPoint.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(layerMask == (layerMask | (1<<collision.gameObject.layer)))
        {
            collision.transform.SetParent(transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (layerMask == (layerMask | (1 << collision.gameObject.layer)))
        {
            collision.transform.SetParent(null);
        }
    }


    void Update()
    {
        // Move the platform
        if (movingToEnd)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPos, moveSpeed * Time.deltaTime);

            // Check if the platform reached the end position
            if (Vector3.Distance(transform.position, endPos) < 0.1f)
            {
                movingToEnd = false; // Change direction
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPos, moveSpeed * Time.deltaTime);

            // Check if the platform reached the start position
            if (Vector3.Distance(transform.position, startPos) < 0.1f)
            {
                movingToEnd = true; // Change direction
            }
        }
    }
}
