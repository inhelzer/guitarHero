using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class balls : MonoBehaviour, Controls.IGameControlsActions
{
    Controls controls;
    [SerializeField] bool isone;
    [SerializeField] bool istwo;

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
   


    public void OnEnter(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void On_1(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            Destroy(gameObject);
        }
    }

    public void On_2(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void On_3(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void On_4(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void On_5(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    private void OnDestroy()
    {
        controls.GameControls.Disable();
    }



}
