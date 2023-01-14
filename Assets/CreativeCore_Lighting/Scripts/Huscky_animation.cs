using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huscky_animation : MonoBehaviour
{

    [SerializeField] private Animator animator;

    private float time;

    
    void Update()
    {
        time += Time.deltaTime;
        if (time > 3)
        {
            animator.SetInteger("indexAnim", Random.Range(0, 3));
            time = 0;
        }           
    }
}
