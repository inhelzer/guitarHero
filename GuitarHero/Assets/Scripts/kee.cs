using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class kee : MonoBehaviour, Controls.IGameControlsActions
{
    Controls controls;

    [SerializeField] bool is1;
    [SerializeField] bool is2;
    [SerializeField] bool is3;
    [SerializeField] bool is4;

    bool isActive = false;

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

    public void On_1(InputAction.CallbackContext context)
    {
        if((context.performed) && (isActive) && (is1))
        {
            Destroy(gameObject);
        }
    }

    public void On_2(InputAction.CallbackContext context)
    {
        if ((context.performed) && (isActive) && (is2))
        {
            Destroy(gameObject);
        }
    }

    public void On_3(InputAction.CallbackContext context)
    {
        if ((context.performed) && (isActive) && (is3))
        {
            Destroy(gameObject);
        }
    }

    public void On_4(InputAction.CallbackContext context)
    {
        if ((context.performed) && (isActive) && (is4))
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "KillZone")
        {
            isActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "KillZone")
        {
            isActive = false;
        }
    }

    public void OnEnter(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    private void OnDestroy()
    {
        controls.GameControls.Disable();
    }


}