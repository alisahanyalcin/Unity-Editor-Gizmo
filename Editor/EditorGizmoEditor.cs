using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace alisahanyalcin
{
    [CustomEditor(typeof(EditorGizmo))]
    public class EditorGizmoEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            /*DrawDefaultInspector();*/
            EditorGizmo gizmo = (EditorGizmo) target;
            
            gizmo.shapes = (EditorGizmo.GizmoShape) EditorGUILayout.EnumPopup("Shape", gizmo.shapes);
            gizmo.gizmoSize = EditorGUILayout.Slider("Size", gizmo.gizmoSize, 0, 10);
            
            if (gizmo.shapes != EditorGizmo.GizmoShape.Texture)
                gizmo.gizColor = EditorGUILayout.ColorField("Color", gizmo.gizColor);
            else
                gizmo.gizTexture = (Texture2D) EditorGUILayout.ObjectField("Texture", gizmo.gizTexture, typeof(Texture2D), false);
        }
    }
}