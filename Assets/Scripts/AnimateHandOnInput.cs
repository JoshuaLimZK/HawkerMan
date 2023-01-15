using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimation;
    public InputActionProperty gripAnimation;
    public Animator handAnimator;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        float triggerVal = pinchAnimation.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerVal);

        float gripVal = gripAnimation.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripVal);
    }
}