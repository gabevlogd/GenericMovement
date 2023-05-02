using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    private Rigidbody m_rigidbody;

    private delegate void OnUpdateTranslation();
    private OnUpdateTranslation m_onTranslate;

    private delegate void OnUpdateRotation();
    private OnUpdateRotation m_onRotate;

    private void OnEnable() => EnableMovement();
    private void OnDisable() => DisableMovement();

    private void FixedUpdate()
    {
        m_onTranslate?.Invoke();
        m_onRotate?.Invoke();
    }

    private void EnableMovement()
    {
        if (m_rigidbody == null) m_rigidbody = GetComponent<Rigidbody>();

        AddTranslationType();
        AddRotationType();
    }

    private void DisableMovement()
    {
        RemoveTranslationType();
        RemoveRotationType();
    }

    private void AddTranslationType()
    {
        switch (MovementSetter.TranslationType)
        {
            case TranslationType.stdA:
                m_onTranslate += OnTranslateStdA;
                break;
            case TranslationType.stdB:
                m_onTranslate += OnTranslateStdB;
                break;
            case TranslationType.Isometric:
                m_onTranslate += OnTranslateIso;
                break;
        }
    }

    private void AddRotationType()
    {
        switch (MovementSetter.RotationType)
        {
            case RotationType.std:
                m_onRotate += OnRotate;
                break;
        }
    }

    private void RemoveTranslationType() => m_onTranslate = null;

    private void RemoveRotationType() => m_onRotate = null;



    //////////////////////////////////////////////////////////////////////
    //                   TRANSLATION METHOD                             //
    //////////////////////////////////////////////////////////////////////

    private void OnTranslateStdA()
    {
        Speeds data = MovementParameterHandler.Data;

        if (InputHandler.Data.ForwardInput != 0f) m_rigidbody.AddForce(Mathf.Sign(data.SpeedZ) * transform.forward.normalized, ForceMode.VelocityChange);
        if (InputHandler.Data.RightInput != 0f) m_rigidbody.AddForce(Mathf.Sign(data.SpeedX) * transform.right.normalized, ForceMode.VelocityChange);
        if (InputHandler.Data.UpInput != 0f) m_rigidbody.AddForce(Mathf.Sign(data.SpeedY) * transform.up.normalized, ForceMode.VelocityChange);

        Vector3 velocity = new Vector3(data.SpeedX, data.SpeedY, data.SpeedZ);
        m_rigidbody.velocity = m_rigidbody.velocity.normalized * velocity.magnitude;
    }

    private void OnTranslateStdB()
    {
        Speeds data = MovementParameterHandler.Data;

        m_rigidbody.AddForce(data.SpeedZ * transform.forward.normalized, ForceMode.VelocityChange);
        m_rigidbody.AddForce(data.SpeedX * transform.right.normalized, ForceMode.VelocityChange);
        m_rigidbody.AddForce(data.SpeedY * transform.up.normalized, ForceMode.VelocityChange);

        Vector3 velocity = new Vector3(data.SpeedX, data.SpeedY, data.SpeedZ);
        m_rigidbody.velocity = m_rigidbody.velocity.normalized * velocity.magnitude;
    }

    private void OnTranslateIso()
    {
        Speeds data = MovementParameterHandler.Data;

        Vector3 velocity = new Vector3(data.SpeedX, data.SpeedY, data.SpeedZ);
        m_rigidbody.velocity = velocity;
    }




    //     etc...



    //////////////////////////////////////////////////////////////////////
    //                   ROTATION METHOD                                //
    //////////////////////////////////////////////////////////////////////

    private void OnRotate()
    {
        Speeds data = MovementParameterHandler.Data;

        transform.RotateAround(transform.position, transform.forward, data.AngularSpeedZ);
        transform.RotateAround(transform.position, transform.up, data.AngularSpeedY);
        transform.RotateAround(transform.position, transform.right, data.AngularSpeedX);
    }


    //     etc...    
}
