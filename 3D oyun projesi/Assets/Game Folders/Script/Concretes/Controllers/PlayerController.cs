using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project3D.controllers
{

    public class PlayerController : MonoBehaviour 
    {
        private Rigidbody rigidbody; 
        private void Awake()
        {
            rigidbody GetComponent<Rigidbody>();
        }

        private void Update()
        {

        }

        private void FixedUpdate()
        {
            throw new NotImplementedException();
        }
    }
}


