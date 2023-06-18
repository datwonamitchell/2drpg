using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// https://www.youtube.com/watch?v=DBGvx-cCUMw&list=PLy1Xj-4F5G_cytIH8by-bZ9TVj5qKMlZn&index=2
/// </summary>

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    private bool isMoving;

    private Vector2 input;

    private void Update()
    {
        if (!isMoving)
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");
        }
    }
}
