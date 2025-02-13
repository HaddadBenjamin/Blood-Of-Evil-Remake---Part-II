﻿using UnityEngine;
using BloodOfEvil.Scene;
using System.Collections;
using System.Collections.Generic;
using BloodOfEvil.Player;

public class HealthbarRoot : MonoBehaviour {
    public List<Transform> healthBars = new List<Transform>(); //List of helthbars;
    private Camera cam;
    private Transform cameraTransform;                          //Main camera transform
	
    void Start ()
    {
        cam = PlayerServicesAndModulesContainer.Instance.PlayerCamera;
        cameraTransform = cam.transform;

        for (int i = 0; i < transform.childCount; i++)
            healthBars.Add(transform.GetChild(i));

        transform.SetParent(SceneServicesContainer.Instance.GameObjectInSceneReferencesService.Get("[UI] Enemies Health Bars").transform);
	}
	
	void Update () 
    {
        healthBars.Sort(DistanceCompare);

        for(int i = 0; i < healthBars.Count; i++)
            healthBars[i].SetSiblingIndex(healthBars.Count - (i+1));
	}

    private int DistanceCompare(Transform a, Transform b)
    {
        return Mathf.Abs((WorldPos(a.position) - cameraTransform.position).sqrMagnitude).CompareTo(Mathf.Abs((WorldPos(b.position) - cameraTransform.position).sqrMagnitude));
    }

    private Vector3 WorldPos(Vector3 pos)
    {
        return cam.ScreenToWorldPoint(pos);
    }
}
