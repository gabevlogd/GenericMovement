using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TranslationType
{
    stdA,
    stdB,
    Isometric
}
public enum RotationType
{
    std
}

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(MovementParameterHandler), typeof(PlayerMovement), typeof(InputHandler))]
public class MovementSetter : MonoBehaviour
{
    [Space(10f)]
    [Header("Settings")]
    [Space(20f)]

    [SerializeField]
    private TranslationType m_translationType;
    public static TranslationType TranslationType { get => m_current.m_translationType; }

    [SerializeField]
    private RotationType m_rotationType;
    public static RotationType RotationType { get => m_current.m_rotationType; }



    #region TRANSLATION

    [Space(10f)]
    [Header("Translation")]

    [Tooltip("can the player move on the x-axis?")]
    [SerializeField]
    private bool m_AxisX;
    public static bool AxisX { get => m_current.m_AxisX; }

    [Tooltip("can the player move on the y-axis?")]
    [SerializeField]
    private bool m_AxisY;
    public static bool AxisY { get => m_current.m_AxisY; }

    [Tooltip("can the player move on the z-axis?")]
    [SerializeField]
    private bool m_AxisZ;
    public static bool AxisZ { get => m_current.m_AxisZ; }

    [Space(10f)]

    [SerializeField]
    private float m_maxSpeedX = 0f;
    public static float MaxSpeedX { get => m_current.m_maxSpeedX; }

    [SerializeField]
    private float m_maxSpeedY = 0f;
    public static float MaxSpeedY { get => m_current.m_maxSpeedY; }

    [SerializeField]
    private float m_maxSpeedZ = 0f;
    public static float MaxSpeedZ { get => m_current.m_maxSpeedZ; }

    [Space(10f)]

    [SerializeField]
    private float m_minSpeedX = 0f;
    public static float MinSpeedX { get => m_current.m_minSpeedX; }

    [SerializeField]
    private float m_minSpeedY = 0f;
    public static float MinSpeedY { get => m_current.m_minSpeedY; }

    [SerializeField]
    private float m_minSpeedZ = 0f;
    public static float MinSpeedZ { get => m_current.m_minSpeedZ; }

    [Space(10f)]

    [SerializeField]
    private float m_accelerationX = 0;
    public static float AccelerationX { get => m_current.m_accelerationX; }

    [SerializeField]
    private float m_accelerationY = 0;
    public static float AccelerationY { get => m_current.m_accelerationY; }

    [SerializeField]
    private float m_accelerationZ = 0;
    public static float AccelerationZ { get => m_current.m_accelerationZ; }

    [Space(10f)]

    [SerializeField]
    private float m_decelerationX = 0;
    public static float DecelerationX { get => m_current.m_decelerationX; }

    [SerializeField]
    private float m_decelerationY = 0;
    public static float DecelerationY { get => m_current.m_decelerationY; }

    [SerializeField]
    private float m_decelerationZ = 0;
    public static float DecelerationZ { get => m_current.m_decelerationZ; }

    #endregion


    #region ROTATION

    [Space(10f)]
    [Header("Rotation")]
    [Space(20f)]

    [Tooltip("can the player rotate on the x-axis?")]
    [SerializeField]
    private bool m_pitch;
    public static bool Pitch { get => m_current.m_pitch; }

    [Tooltip("is pitch rotation performed by mouse input?")]
    [SerializeField]
    private bool m_pitchHasMouseInput;
    public static bool MouseInputPitch { get => m_current.m_pitchHasMouseInput; }

    [Space(5f)]

    [Tooltip("can the player rotate on the y-axis?")]
    [SerializeField]
    private bool m_yaw;
    public static bool Yaw { get => m_current.m_yaw; }

    [Tooltip("is yaw rotation performed by mouse input?")]
    [SerializeField]
    private bool m_yawHasMouseInput;
    public static bool MouseInputYaw { get => m_current.m_yawHasMouseInput; }

    [Space(5f)]

    [Tooltip("can the player rotate on the z-axis?")]
    [SerializeField]
    private bool m_roll;
    public static bool Roll { get => m_current.m_roll; }

    [Tooltip("is roll rotation performed by mouse input?")]
    [SerializeField]
    private bool m_rollHasMouseInput;
    public static bool MouseInputRoll { get => m_current.m_rollHasMouseInput; }

    [Space(10f)]

    [SerializeField]
    private float m_maxAngularSpeedX = 0;
    public static float MaxAngularSpeedX { get => m_current.m_maxAngularSpeedX; }

    [SerializeField]
    private float m_maxAngularSpeedY = 0;
    public static float MaxAngularSpeedY { get => m_current.m_maxAngularSpeedY; }

    [SerializeField]
    private float m_maxAngularSpeedZ = 0;
    public static float MaxAngularSpeedZ { get => m_current.m_maxAngularSpeedZ; }

    [Space(10f)]

    [SerializeField]
    private float m_minAngularSpeedX = 0;
    public static float MinAngularSpeedX { get => m_current.m_minAngularSpeedX; }

    [SerializeField]
    private float m_minAngularSpeedY = 0;
    public static float MinAngularSpeedY { get => m_current.m_minAngularSpeedY; }

    [SerializeField]
    private float m_minAngularSpeedZ = 0;
    public static float MinAngularSpeedZ { get => m_current.m_minAngularSpeedZ; }

    [Space(10f)]

    [SerializeField]
    private float m_angularAccelerationX = 0;
    public static float AngularAccelerationX { get => m_current.m_angularAccelerationX; }

    [SerializeField]
    private float m_angularAccelerationY = 0;
    public static float AngularAccelerationY { get => m_current.m_angularAccelerationY; }

    [SerializeField]
    private float m_angularAccelerationZ = 0;
    public static float AngularAccelerationZ { get => m_current.m_angularAccelerationZ; }

    [Space(10f)]

    [SerializeField]
    private float m_angularDecelerationX = 0;
    public static float AngularDecelerationX { get => m_current.m_angularDecelerationX; }

    [SerializeField]
    private float m_angularDecelerationY = 0;
    public static float AngularDecelerationY { get => m_current.m_angularDecelerationY; }

    [SerializeField]
    private float m_angularDecelerationZ = 0;
    public static float AngularDecelerationZ { get => m_current.m_angularDecelerationZ; }

    [Space(10f)]

    [SerializeField]
    private float m_yawSensibility = 0;
    public static float YawSensibility { get => m_current.m_yawSensibility; }

    [SerializeField]
    private float m_pitchSensibility = 0;
    public static float PitchSensibility { get => m_current.m_pitchSensibility; }

    [SerializeField]
    private float m_rollSensibility = 0;
    public static float RollSensibility { get => m_current.m_rollSensibility; }

    #endregion

    private static MovementSetter m_current;

    private void Awake()
    {
        if (m_current == null) m_current = this;
    }

}
