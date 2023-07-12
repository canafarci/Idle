using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;
    private Vector2 _moveInput;
    [Inject] private readonly CharacterController _controller;

    public void OnMove(InputAction.CallbackContext context)
    {
        _moveInput = context.ReadValue<Vector2>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (_moveInput == Vector2.zero) return; //return if there is no input

        //convert to a vector3
        Vector3 moveDir = new Vector3(_moveInput.x, 0f, _moveInput.y);
        //calcutate move distance
        float moveDistance = _moveSpeed * Time.deltaTime;
        //rotate
        transform.forward = Vector3.Slerp(transform.forward, moveDir, Time.deltaTime * _rotateSpeed);
        //move
        _controller.Move(moveDir * moveDistance);
    }
}
