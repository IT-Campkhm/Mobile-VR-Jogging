using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChecInputDelta : MonoBehaviour
{
    public Vector3 deltaRot;
    public TextMeshPro debug_text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deltaRot = deltaRot - transform.eulerAngles;
        debug_text.text = deltaRot.ToString();

    }
}
