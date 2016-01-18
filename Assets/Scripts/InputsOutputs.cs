using UnityEngine;
using System.Collections;
using System.IO;
using System.IO.Ports;

// Alessandro & Boy


public class InputsOutputs : MonoBehaviour {

    SerialPort stream = new SerialPort("COM5", 9600);
    string[] strArr;
    int x = 0;
    int y = 0;
    
    void Start() {
        stream.Open();
    }
    
    void Update() {
        strArr = stream.ReadLine().Split("|"[0]);
        Debug.Log("x " + strArr[0] + " y " + strArr[1]);
        if (int.Parse(strArr[0]) < 350) {
            x = 1;
        } else if (int.Parse(strArr[0]) > 800) {
            x = -1;
        } else {
            x = 0;
        }
        if (int.Parse(strArr[1]) < 350) {
            y = -1;
        } else if (int.Parse(strArr[1]) > 800) {
            y = 1;
        } else {
            y = 0;
        }

        Debug.Log(new Vector2(x, y));


    }
    void FixedUpdate() {
        transform.Translate(new Vector2(x * Time.smoothDeltaTime, y * Time.smoothDeltaTime));
    }
}
