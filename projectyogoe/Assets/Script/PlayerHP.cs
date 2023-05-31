using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    // Start is called before the first frame update
    public int HP = 100;
    public Collision2D col;

    void Start()
    {
        HP = 100;

    }

    void Update()
    {
        HPbar();
        


    }

   

    void FixedUpdate()
    {
        HPcontroll();
    }

    void HPcontroll()
    {
        if (col != null && col.gameObject.tag.Equals("Tan"))
        {
            Debug.Log("충돌처리");
            HP--;
        }
    }

   

    void HPbar()
    {
        
    }
}
