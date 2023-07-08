using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    // Start is called before the first frame update
    public int HP = 100;
   

    void Start()
    {
        HP = 100;

    }

    void Update()
    {
        HPbar();


        
    }

    



    void HPcontroll()
    {
        Debug.Log("충돌처리");
        HP--;
        Debug.Log(HP);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.gameObject.tag);
        if (col.gameObject.CompareTag("Tan"))
        {
            HPcontroll();
        }
    }


    void HPbar()
    {
        
    }
}
