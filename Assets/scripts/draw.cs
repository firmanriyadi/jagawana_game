using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draw : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject Area;

    public void onclick()
    {
        for (int i = 0; i<10 ; i++)
        {
            GameObject card = Instantiate (Card1 , new Vector2 (0,0), Quaternion.identity);
            card.transform.SetParent(Area.transform,false);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
