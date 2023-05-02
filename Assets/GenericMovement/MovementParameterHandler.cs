using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Speeds
{
    public float SpeedX;
    public float SpeedY;
    public float SpeedZ;

    public float AngularSpeedX;
    public float AngularSpeedY;
    public float AngularSpeedZ;
}

public class MovementParameterHandler : MonoBehaviour
{
    private static Speeds m_data;
    public static Speeds Data { get => m_data; }

    private delegate void OnUpdateSpeeds(ref float speed, float maxSpeed, float minSpeed, float acceleration, float deceleration, float input);
    private delegate void OnUpdateMouseSpeeds(ref float speed, float sensibility, float input);

    private OnUpdateSpeeds m_onUpdateSpeedX;
    private OnUpdateSpeeds m_onUpdateSpeedY;
    private OnUpdateSpeeds m_onUpdateSpeedZ;

    private OnUpdateSpeeds m_onUpdateAngularSpeedX;
    private OnUpdateSpeeds m_onUpdateAngularSpeedY;
    private OnUpdateSpeeds m_onUpdateAngularSpeedZ;

    private OnUpdateMouseSpeeds m_onUpdateMouseSpeedX;
    private OnUpdateMouseSpeeds m_onUpdateMouseSpeedY;
    private OnUpdateMouseSpeeds m_onUpdateMouseSpeedZ;

    private void OnEnable() => EnableSpeeds();
    private void OnDisable() => DisableSpeeds();

    private void Update()
    {
        m_onUpdateSpeedX?.Invoke(ref m_data.SpeedX, MovementSetter.MaxSpeedX, MovementSetter.MinSpeedX, MovementSetter.AccelerationX, MovementSetter.DecelerationX, InputHandler.Data.RightInput);
        m_onUpdateSpeedY?.Invoke(ref m_data.SpeedY, MovementSetter.MaxSpeedY, MovementSetter.MinSpeedY, MovementSetter.AccelerationY, MovementSetter.DecelerationY, InputHandler.Data.UpInput);
        m_onUpdateSpeedZ?.Invoke(ref m_data.SpeedZ, MovementSetter.MaxSpeedZ, MovementSetter.MinSpeedZ, MovementSetter.AccelerationZ, MovementSetter.DecelerationZ, InputHandler.Data.ForwardInput);

        m_onUpdateAngularSpeedX?.Invoke(ref m_data.AngularSpeedX, MovementSetter.MaxAngularSpeedX, MovementSetter.MinAngularSpeedX, MovementSetter.AngularAccelerationX, MovementSetter.AngularDecelerationX, InputHandler.Data.PitchInput);
        m_onUpdateAngularSpeedY?.Invoke(ref m_data.AngularSpeedY, MovementSetter.MaxAngularSpeedY, MovementSetter.MinAngularSpeedY, MovementSetter.AngularAccelerationY, MovementSetter.AngularDecelerationY, InputHandler.Data.YawInput);
        m_onUpdateAngularSpeedZ?.Invoke(ref m_data.AngularSpeedZ, MovementSetter.MaxAngularSpeedZ, MovementSetter.MinAngularSpeedZ, MovementSetter.AngularAccelerationZ, MovementSetter.AngularDecelerationZ, InputHandler.Data.RollInput);

        m_onUpdateMouseSpeedY?.Invoke(ref m_data.AngularSpeedY, MovementSetter.YawSensibility, InputHandler.Data.YawInput);
        m_onUpdateMouseSpeedX?.Invoke(ref m_data.AngularSpeedX, MovementSetter.PitchSensibility, -InputHandler.Data.PitchInput);
        m_onUpdateMouseSpeedZ?.Invoke(ref m_data.AngularSpeedZ, MovementSetter.RollSensibility, -InputHandler.Data.RollInput);

        //Debug.Log("X: " + Data.SpeedX + " Y: " + Data.SpeedY + " Z: " + Data.SpeedZ);
        //Debug.Log("X: " + Data.AngularSpeedX + " Y: " + Data.AngularSpeedY + " Z: " + Data.AngularSpeedZ);
    }


    private void EnableSpeeds()
    {
        if (MovementSetter.AxisX) m_onUpdateSpeedX += OnUpdateSingleAxisSpeed;
        if (MovementSetter.AxisY) m_onUpdateSpeedY += OnUpdateSingleAxisSpeed;
        if (MovementSetter.AxisZ) m_onUpdateSpeedZ += OnUpdateSingleAxisSpeed;

        if (MovementSetter.Yaw)
        {
            if (MovementSetter.MouseInputYaw) m_onUpdateMouseSpeedY += OnUpdateMouseSpeed;
            else m_onUpdateAngularSpeedY += OnUpdateSingleAxisSpeed;
        }

        if (MovementSetter.Pitch)
        {
            if (MovementSetter.MouseInputPitch) m_onUpdateMouseSpeedX += OnUpdateMouseSpeed;
            else m_onUpdateAngularSpeedX += OnUpdateSingleAxisSpeed;
        }

        if (MovementSetter.Roll)
        {
            if (MovementSetter.MouseInputRoll) m_onUpdateMouseSpeedZ += OnUpdateMouseSpeed;
            else m_onUpdateAngularSpeedZ += OnUpdateSingleAxisSpeed;
        }
    }

    private void DisableSpeeds()
    {
        if (MovementSetter.AxisX) m_onUpdateSpeedX -= OnUpdateSingleAxisSpeed;
        if (MovementSetter.AxisY) m_onUpdateSpeedY -= OnUpdateSingleAxisSpeed;
        if (MovementSetter.AxisZ) m_onUpdateSpeedZ -= OnUpdateSingleAxisSpeed;

        if (MovementSetter.Yaw)
        {
            if (MovementSetter.MouseInputYaw) m_onUpdateMouseSpeedY -= OnUpdateMouseSpeed;
            else m_onUpdateAngularSpeedY -= OnUpdateSingleAxisSpeed;
        }

        if (MovementSetter.Pitch)
        {
            if (MovementSetter.MouseInputPitch) m_onUpdateMouseSpeedX -= OnUpdateMouseSpeed;
            else m_onUpdateAngularSpeedX -= OnUpdateSingleAxisSpeed;
        }

        if (MovementSetter.Roll)
        {
            if (MovementSetter.MouseInputRoll) m_onUpdateMouseSpeedZ -= OnUpdateMouseSpeed;
            else m_onUpdateAngularSpeedZ -= OnUpdateSingleAxisSpeed;
        }
    }

    private void OnUpdateSingleAxisSpeed(ref float speed, float maxSpeed, float minSpeed, float acceleration, float deceleration, float input)
    {
        if (input != 0) IncraseSpeed(ref speed, maxSpeed, minSpeed, acceleration, input);
        else DecreaseSpeed(ref speed, minSpeed, deceleration);
    }

    private void IncraseSpeed(ref float speed, float maxSpeed, float minSpeed, float acceleration, float input)
    {
        //if input and speed have opposite signs: the starting point of the lerp becomes -speed 
        //(if minSpeed != 0 need to skip the values x where x is -minSpeed < x < minSpeed)
        if (Mathf.Abs(speed) - minSpeed < 0.1f && Mathf.Sign(input) * Mathf.Sign(speed) < 0) speed = Mathf.Lerp(-speed, maxSpeed * input, acceleration * Time.deltaTime);
        else speed = Mathf.Lerp(speed, maxSpeed * input, acceleration * Time.deltaTime);
    }

    private void DecreaseSpeed(ref float speed, float minSpeed, float deceleration)
    {
        //if the speed is approximately equal to minSpeed: the speed is set to minSpeed or -minSpeed depending on the sign
        if (Mathf.Abs(speed) - minSpeed < 0.1f)
        {
            if (speed > 0) speed = minSpeed;
            else speed = -minSpeed;
            return;
        }
        else if (speed >= 0) speed = Mathf.Lerp(speed, minSpeed, deceleration * Time.deltaTime);
        else if (speed < 0) speed = Mathf.Lerp(speed, -minSpeed, deceleration * Time.deltaTime);
    }

    private void OnUpdateMouseSpeed(ref float speed, float sensibility, float input) => speed = input * sensibility * Time.deltaTime;
}
