using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Knight : MonoBehaviour
{
    SpriteRenderer sr;
    Animator animator;
    public float speed = 2;
    public bool canRun = true;
    public AudioSource audioSource;
    public AudioClip clip;
    public CinemachineImpulseSource impulseSource;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }


    void Update()
    {

        float direction = Input.GetAxisRaw("Horizontal");
        float direction2 = Input.GetAxisRaw("Vertical");
        float directionCheck = direction;

        directionCheck += direction + direction2;
        Debug.Log(direction2);

        sr.flipX = (direction < 0);
        animator.SetFloat("movement", Mathf.Abs(directionCheck));
        animator.SetFloat("movement2", Mathf.Abs(direction2));



        if (canRun == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                animator.SetTrigger("Attack");
                canRun = false;
            }

            transform.position += transform.right * direction * speed * Time.deltaTime;
            transform.position += transform.up * direction2 * speed * Time.deltaTime;
        }
    }

    public void AttackHasFinished()
    {
        Debug.Log("The Attack Animation Has Finished!");
        canRun = true;
    }

    public void FootHasHitGround()
    {
        if (audioSource.isPlaying == false)
        {
            audioSource.PlayOneShot(clip);
        }
        impulseSource.GenerateImpulse();
    }
}
