using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyroManager : MonoBehaviour
{
    private static gyroManager instance;

    public static gyroManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<gyroManager>();
                if (instance == null)
                {
                    instance = new GameObject("Gyro Manager", typeof(gyroManager)).GetComponent<gyroManager>();
                }
            }
            return instance;
        }
        set
        {
            instance = value;
        }
    }

    [Header("Logic")]
    private Gyroscope gyro;
    private Quaternion rotation;
    private bool gyroActive;

    public void EnableGyro()
    {
        if (gyroActive)
            return;

        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
            gyroActive = gyro.enabled;
            Debug.Log("yeah! ");
        }

    }

    public Quaternion GetGyroRotation()
    {
        return rotation;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotation = gyro.attitude;
    }
}
