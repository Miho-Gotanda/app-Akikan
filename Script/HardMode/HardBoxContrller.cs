using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardBoxContrller : MonoBehaviour
{
    private bool position=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x >= 7.09f)
            position = true;
        if (this.transform.position.x <= -7.8f)
            position = false;
        if (position==false)
            this.transform.position = new Vector3(this.transform.position.x + 0.05f, this.transform.position.y, 0f);
        else if (position==true)
            this.transform.position = new Vector3(this.transform.position.x - 0.05f, this.transform.position.y, 0f);
    }
}
