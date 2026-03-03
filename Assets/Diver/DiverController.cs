using UnityEngine;
using UnityEngine.InputSystem;

public class DiverController : MonoBehaviour
{
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // New Input System syntax
        if (Keyboard.current.cKey.wasPressedThisFrame)
        {
            animator.SetTrigger("startClimb");
        }
    }
}
