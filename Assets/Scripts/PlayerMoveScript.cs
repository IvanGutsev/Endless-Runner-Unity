using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;

    public float speed;
    public float maxHeight;
    public float minHeight;

    void Update()
    {
        // Make movement smoother
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        // Move up
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight) 
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
        }
        // Move down
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }
    }
}
