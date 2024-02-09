using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class recorder : MonoBehaviour, Controls.IGameControlsActions
{
    Controls controls;
    string a;
    string b;
    string c;
    string d;

    public void OnEnter(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("one:" + a);
            Debug.Log("two:" + b);
            Debug.Log("three:" + c);
            Debug.Log("four:" + d);

        }
    }

    public void On_1(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            a = a + $"{System.Math.Round(Time.timeSinceLevelLoad, 2)},";
        }
    }

    public void On_2(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            b = b + $"{System.Math.Round(Time.timeSinceLevelLoad, 2)},";
        }
    }

    public void On_3(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            c = c + $"{System.Math.Round(Time.timeSinceLevelLoad, 2)},";
        }
    }

    public void On_4(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            d = d + $"{System.Math.Round(Time.timeSinceLevelLoad, 2)},";
        }
    }

    private void Awake()
    {
        controls = new Controls();
        controls.GameControls.SetCallbacks(this);

    }

    // Start is called before the first frame update
    void Start()
    {
        controls.GameControls.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        controls.GameControls.Disable();
    }

    public void On_5(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }
}
