using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    private Animator animator;
    private SpriteRenderer sprite;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }
    void Update()
    {
        animator.SetInteger("State", 0);
        if (Input.GetButton("Horizontal"))
        {
            Run();
        }
    }

    private void Run()
    {
        var input = Input.GetAxis("Horizontal");
        //without changing on zero
        if (input > 0)
        {
            sprite.flipX = false;
        }
        else if (input < 0)
        {
            sprite.flipX = true;
        }
        animator.SetInteger("State", 1);
        var targetPosition = transform.position + transform.right * input;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
}
