using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    // Start is called before the first frame update
    int HP = 0;
    Collision2D col;
    void Start()
    {
        HP = 100;
        
    }

    // Update is called once per frame
    void Update()
    {
        HPcontroll(col);
        HPbar();

    }
    void HPcontroll(Collision2D col)
    {
        if(col.gameObject.tag == "Tan")
        {
            HP -= 5;
        }
    }

    void HPbar()
    {
        
    }
}
