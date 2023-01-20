using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fis : MonoBehaviour
{
    private void Start()
    { GetComponent<Rigidbody>().AddForce(-transform.up * 20f, ForceMode.Impulse); }
}
