using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum OBJECTTYPE
{
    DRAGGABLE,
    SELECTABLE,
    QR_LINKED,
    STATIC
}
public class TeaObjectAttributes : MonoBehaviour
{
    // Name to be displayed
    public string Name;

    // How does this object interact with the world?
    public OBJECTTYPE objectType;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
