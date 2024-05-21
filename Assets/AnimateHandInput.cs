using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class AnimateHandInput : MonoBehaviour
{
    public InputActionProperty pinch;
    public InputActionProperty grip;
    public Animator handle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      float trig= pinch.action.ReadValue<float>();
        handle.SetFloat("Trigger", trig);

        float gr = grip.action.ReadValue<float>();
        handle.SetFloat("Grip", gr);
        
       // Debug.Log(trig);
    }
}
