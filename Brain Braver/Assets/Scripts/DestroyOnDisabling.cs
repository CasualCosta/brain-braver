﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnDisabling : MonoBehaviour
{
    [SerializeField] GameObject[] targets = new GameObject[0];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        foreach (GameObject t in targets)
            Destroy(t);
    }
}
