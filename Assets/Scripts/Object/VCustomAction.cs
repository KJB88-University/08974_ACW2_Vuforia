using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VCustomAction : MonoBehaviour
{
    // Target object
    [SerializeField]
    protected GameObject objectToMoveTo;

    // Offset of object from destination object
    [SerializeField]
    protected float yOffset;

    Vector3 defaultPosition;
    Quaternion defaultRotation;

    // Local Components
    Animator animator;
    AudioSource audioSource;

    // Animation to play
    [SerializeField]
    string AnimationToPlay;

    public virtual void CustomAction()
    {
        if (StepManager.Instance.CheckStep(this.gameObject, objectToMoveTo))
        {
            transform.parent.position = new Vector3(objectToMoveTo.transform.position.x, yOffset, objectToMoveTo.transform.position.z);
            PlayAnimation();
            PlaySound();

            StepManager.Instance.NextStep();
        }
    }

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();

        defaultPosition = transform.parent.position;
        defaultRotation = transform.rotation;
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

    protected void ResetAction()
    {
        //transform.parent.position = defaultPosition;
        //transform.rotation = defaultRotation;
        gameObject.SetActive(false);
    }

    // Play the animation specified by AnimationToPlay
    protected void PlayAnimation()
    {
        animator.Play(AnimationToPlay);
    }

    // Play the sound associated with this object
    protected void PlaySound()
    {
        audioSource.Play();
    }
}

