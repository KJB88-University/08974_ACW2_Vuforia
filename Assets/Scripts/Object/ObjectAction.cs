using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAction : MonoBehaviour
{
    // Target object
    [SerializeField]
    GameObject objectToMoveTo;

    // Offset of object from destination object
    [SerializeField]
    float yOffset;

    Vector3 defaultPosition;
    Quaternion defaultRotation;

    // Local Components
    Animator animator;
    AudioSource audioSource;

    // Animation to play
    [SerializeField]
    string AnimationToPlay;

	// Use this for initialization
	void Start ()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();

        defaultPosition = transform.position;
        defaultRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    /// <summary>
    /// When gazed at
    /// </summary>
    void OnGazeEnter()
    {
        GetComponent<SelectionGlow>().Highlighted();
        UIManager.Instance.ToggleNameTag(GetComponent<TeaObjectAttributes>().GetName());
    }

    /// <summary>
    /// When no longer gazed at
    /// </summary>
    void OnGazeExit()
    {
        GetComponent<SelectionGlow>().RemoveHighlight();
        UIManager.Instance.ToggleNameTag("");
    }

    /// <summary>
    /// Perform actions related to tap gesture
    /// </summary>
    public void GestureAction()
    {
        transform.position = new Vector3(objectToMoveTo.transform.position.x, yOffset, objectToMoveTo.transform.position.z);
        PlayAnimation();
        PlaySound();
    }

    public void ResetAction()
    {
        transform.position = defaultPosition;
        transform.rotation = defaultRotation;
    }

    // Play the animation specified by AnimationToPlay
    void PlayAnimation()
    {
        animator.Play(AnimationToPlay);
    }

    // Play the sound associated with this object
    void PlaySound()
    {
        audioSource.Play();
    }
}
