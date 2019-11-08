using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplotionDestroy : MonoBehaviour
{
    GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = transform.GetChild(0).gameObject;
        ParticleSystem particalSystem =obj.GetComponent<ParticleSystem>();
        Destroy(gameObject,particalSystem.main.duration);
    }

  }
