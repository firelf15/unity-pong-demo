using UnityEngine;
using UnityEngine.InputSystem;

public class RaquetaDeJugador : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody2D rb;
    private InputSystem_Actions inputActions;
    private float moveInput;

    void Awake()
    {
        inputActions = new InputSystem_Actions();
    }

    void OnEnable()
    {
        inputActions.Player.Move.Enable();
        inputActions.Player.Move.performed += OnMove;
        inputActions.Player.Move.canceled += OnMove;
    }

    void OnDisable()
    {
        inputActions.Player.Move.performed -= OnMove;
        inputActions.Player.Move.canceled -= OnMove;
        inputActions.Player.Move.Disable();
    }

    void Start() => rb = GetComponent<Rigidbody2D>();

    void OnMove(InputAction.CallbackContext ctx)
    {
        // Move is a Vector2 — we only care about Y for the paddle
        moveInput = ctx.ReadValue<Vector2>().y;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(0, moveInput * speed);
    }
}