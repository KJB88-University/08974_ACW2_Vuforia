using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionGlow : MonoBehaviour
{
    [SerializeField]
    Material highlightedMat;

    [SerializeField]
    Material originalMat;

    bool highlighted = false;

    public void Highlighted()
    {
        GetComponent<Renderer>().material = highlightedMat;
    }

    public void RemoveHighlight()
    {
        GetComponent<Renderer>().material = originalMat;
    }
}
