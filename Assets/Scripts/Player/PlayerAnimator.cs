using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerAnimator : MonoBehaviour
{
    private const string IsMoving = "IsMoving";

    [SerializeField] private Joystick _joystick;

    private PlayerMovement _playerMovement;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        _animator.SetBool(IsMoving, _playerMovement.IsMoving & _joystick.IsPressed);
    }
}
