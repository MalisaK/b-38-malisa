using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : Enemy
{
    [SerializeField] private Vector2 velosity;
    [SerializeField] private Transform[] movePoints;

    private void Start()
    {
        Init(10);
        Debug.Log("Ant health" + Health);

        Behaviour();
    }

    private void FixedUpdate()
    {
        Behaviour();
    }

    public override void Behaviour()
    {
        rb.MovePosition(rb.position + velosity * Time.fixedDeltaTime);


        if (rb.position.x <= movePoints[0].position.x && velosity.x < 0)
        {
            FlipCharacter();
        }

        else if (rb.position.x >= movePoints[1].position.x && velosity.x > 0)
        {
            Flip();
        }
    }

    private void Flip()
    {
        velosity *= -1;

        Vector2 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

    private void FlipCharacter()
    {
        velosity *= -1;

        Vector2 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}