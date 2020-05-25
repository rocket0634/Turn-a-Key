using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Reflection;

public class TurnAKey : MonoBehaviour {

    private static int _moduleIDCounter = 1;
    private int _moduleID;
    public KMBombInfo Info;
    public KMNeedyModule Module;
    public KMAudio Audio;
    private bool active;

    void Start() {
        _moduleID = _moduleIDCounter++;
        //In case the needy needs to know when the bomb is activated for whatever reason.
        Module.OnActivate += delegate () {
            active = true;
        };
        Module.OnNeedyActivation += OnNeedyActivation;
    }

    void OnNeedyActivation()
    {

    }
}
