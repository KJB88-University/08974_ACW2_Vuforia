using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dunkable : MonoBehaviour
{
    [SerializeField]
    GameObject objectToDunkInto;

    [SerializeField]
    float yOffset;

    Animator animator;
    AudioSource audioSource;
	// Use this for initialization
	void Start ()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void GestureAction()
    {
        transform.position = new Vector3(objectToDunkInto.transform.position.x, yOffset, objectToDunkInto.transform.position.z);
    }

    void PlayAnimation()
    {
        animator.Play("Dunk");
    }

    void PlaySound()
    {
        audioSource.Play();
    }
}
