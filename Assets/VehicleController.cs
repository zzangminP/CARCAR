using UnityEngine;

public class VehicleController : MonoBehaviour
{


    [SerializeField] private WheelCollider frontRightWheel;
    [SerializeField] private WheelCollider frontLeftWheel;
    [SerializeField] private WheelCollider rearRightWheel;
    [SerializeField] private WheelCollider rearLeftWheel;

    [SerializeField]
    private float motorForce = 0;

    private void Update()
    {
        TestInput();
        
    }

    private void TestInput()
    {
        float v = Input.GetAxis("Vertical") * motorForce;
        Debug.Log(v);

        frontRightWheel.motorTorque = v;
        frontLeftWheel.motorTorque = v;
        

    }




}
