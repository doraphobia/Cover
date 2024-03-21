using UnityEngine;
using UnityEngine.SceneManagement;

public class HingeControl : MonoBehaviour
{
    private HingeJoint2D hingeJoint;
    private bool isRotating;


    void Start()
    {
        hingeJoint = GetComponent<HingeJoint2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isRotating = true;
        }

        if (isRotating)
        {
            float angle = hingeJoint.jointAngle;
            if (Input.GetMouseButton(0))
            {
                if (angle < 90)
                {
                    hingeJoint.useMotor = true;
                    hingeJoint.motor = new JointMotor2D { motorSpeed = 100, maxMotorTorque = 100 };
                }
            }
            else
            {
                if (angle < 180)
                {
                    hingeJoint.useMotor = true;
                    hingeJoint.motor = new JointMotor2D { motorSpeed = -100, maxMotorTorque = 100 };
                }
                else
                {
                    hingeJoint.useMotor = false;
                    isRotating = false;
                }
            }
        }

    }

}
