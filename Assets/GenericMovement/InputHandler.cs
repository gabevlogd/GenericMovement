using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public struct InputData
{
    public float ForwardInput;
    public float UpInput;
    public float RightInput;

    public float YawInput;
    public float PitchInput;
    public float RollInput;
}

public class InputHandler : MonoBehaviour
{
    public static InputData Data;
    private MovementInput m_input;


    private void OnEnable() => EnableInput();

    private void OnDisable() => DisableInput();

    //private void Start() => CheckMouseInputRequest();

    private void EnableInput()
    {
        if (m_input == null) m_input = new MovementInput();

        if (MovementSetter.AxisX)
        {
            m_input.Translation.Right.performed += OnPerformRight;
            m_input.Translation.Right.canceled += OnCancelRight;
        }

        if (MovementSetter.AxisY)
        {
            m_input.Translation.Up.performed += OnPerformUp;
            m_input.Translation.Up.canceled += OnCancelUp;
        }

        if (MovementSetter.AxisZ)
        {
            m_input.Translation.Forward.performed += OnPerformForward;
            m_input.Translation.Forward.canceled += OnCancelForward;
        }

        if (MovementSetter.Pitch)
        {
            m_input.Rotation.Pitch.performed += OnPerformPitch;
            m_input.Rotation.Pitch.canceled += OnCancelPitch;
        }

        if (MovementSetter.Yaw)
        {
            m_input.Rotation.Yaw.performed += OnPerformYaw; 
            m_input.Rotation.Yaw.canceled += OnCancelYaw;
        }

        if (MovementSetter.Roll)
        {
            m_input.Rotation.Roll.performed += OnPerformRoll;
            m_input.Rotation.Roll.canceled += OnCancelRoll;
        }

        m_input.Enable();
    }

    private void DisableInput()
    {
        if (MovementSetter.AxisX)
        {
            m_input.Translation.Right.performed -= OnPerformRight;
            m_input.Translation.Right.canceled -= OnCancelRight;
        }

        if (MovementSetter.AxisY)
        {
            m_input.Translation.Up.performed -= OnPerformUp;
            m_input.Translation.Up.canceled -= OnCancelUp;
        }

        if (MovementSetter.AxisZ)
        {
            m_input.Translation.Forward.performed -= OnPerformForward;
            m_input.Translation.Forward.canceled -= OnCancelForward;
        }

        if (MovementSetter.Pitch)
        {
            m_input.Rotation.Pitch.performed -= OnPerformPitch;
            m_input.Rotation.Pitch.canceled -= OnCancelPitch;
        }

        if (MovementSetter.Yaw)
        {
            m_input.Rotation.Yaw.performed -= OnPerformYaw;
            m_input.Rotation.Yaw.canceled -= OnCancelYaw;
        }

        if (MovementSetter.Roll)
        {
            m_input.Rotation.Roll.performed -= OnPerformRoll;
            m_input.Rotation.Roll.canceled -= OnCancelRoll;
        }

        m_input.Disable();
    }


    private void OnPerformForward(InputAction.CallbackContext context) => Data.ForwardInput = context.ReadValue<float>();

    private void OnPerformUp(InputAction.CallbackContext context) => Data.UpInput = context.ReadValue<float>();

    private void OnPerformRight(InputAction.CallbackContext context) => Data.RightInput = context.ReadValue<float>();

    private void OnPerformPitch(InputAction.CallbackContext context)=> Data.PitchInput = context.ReadValue<float>();

    private void OnPerformYaw(InputAction.CallbackContext context)=> Data.YawInput = context.ReadValue<float>();

    private void OnPerformRoll(InputAction.CallbackContext context)=> Data.RollInput = context.ReadValue<float>();


    private void OnCancelForward(InputAction.CallbackContext context) => Data.ForwardInput = 0f;

    private void OnCancelUp(InputAction.CallbackContext context) => Data.UpInput = 0f;

    private void OnCancelRight(InputAction.CallbackContext context) => Data.RightInput = 0f;

    private void OnCancelPitch(InputAction.CallbackContext context) => Data.PitchInput = 0f;

    private void OnCancelYaw(InputAction.CallbackContext context) => Data.YawInput = 0f;

    private void OnCancelRoll(InputAction.CallbackContext context) => Data.RollInput = 0f;




    //private void CheckMouseInputRequest()
    //{
    //    if (MovementSetter.Yaw && MovementSetter.MouseInputYaw) m_input.Rotation.Yaw.ChangeBinding(0).Erase();
    //    if (MovementSetter.Pitch && MovementSetter.MouseInputPitch) m_input.Rotation.Pitch.ChangeBinding(0).Erase();
    //    if (MovementSetter.Roll && MovementSetter.MouseInputRoll) m_input.Rotation.Roll.ChangeBinding(0).Erase();

    //}


}
