using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragdrop : MonoBehaviour
{
    private bool isDragging = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Startdrag()
    {
        isDragging = true;
    }

    public void Enddrag()
    {
        isDragging = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            transform.position = new Vector2 (Input.mousePosition.x,Input.mousePosition.y);
        }
    }
}
