using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(VisSpawnPrefabTrigger))]
public class VisSpawnPrefabTriggerEditor : VisBaseTriggerEditor 
{
    public VisSpawnPrefabTriggerEditor()
    {
        showAutomaticInspectorGUI = false;
    }

    protected override void CustomInspectorGUI()
    {
        base.CustomInspectorGUI();

        VisSpawnPrefabTrigger trigger = target as VisSpawnPrefabTrigger;
        if (trigger == null)
            return;

        trigger.prefab = (GameObject)EditorGUILayout.ObjectField("  Prefab", trigger.prefab, typeof(GameObject), false);

		trigger.Plate01 = (GameObject)EditorGUILayout.ObjectField("  Plate01", trigger.Plate01, typeof(GameObject), false);
		trigger.Plate02 = (GameObject)EditorGUILayout.ObjectField("  Plate02", trigger.Plate02, typeof(GameObject), false);
		trigger.Plate03 = (GameObject)EditorGUILayout.ObjectField("  Plate03", trigger.Plate03, typeof(GameObject), false);
		trigger.Plate04 = (GameObject)EditorGUILayout.ObjectField("  Plate04", trigger.Plate04, typeof(GameObject), false);
		trigger.Plate05 = (GameObject)EditorGUILayout.ObjectField("  Plate05", trigger.Plate05, typeof(GameObject), false);
		trigger.Plate06 = (GameObject)EditorGUILayout.ObjectField("  Plate06", trigger.Plate06, typeof(GameObject), false);
		trigger.Plate07 = (GameObject)EditorGUILayout.ObjectField("  Plate07", trigger.Plate07, typeof(GameObject), false);
		trigger.Plate08 = (GameObject)EditorGUILayout.ObjectField("  Plate08", trigger.Plate08, typeof(GameObject), false);
		trigger.Plate09 = (GameObject)EditorGUILayout.ObjectField("  Plate09", trigger.Plate09, typeof(GameObject), false);
		trigger.Plate10 = (GameObject)EditorGUILayout.ObjectField("  Plate10", trigger.Plate10, typeof(GameObject), false);

#if (UNITY_2_6 || UNITY_3_0 || UNITY_3_1 || UNITY_3_2 || UNITY_3_3 || UNITY_3_3 || UNITY_3_4 || UNITY_3_5)
        EditorGUIUtility.LookLikeControls();
#endif

        trigger.randomOffset = EditorGUILayout.Vector3Field("  Random Offset", trigger.randomOffset);


#if (UNITY_2_6 || UNITY_3_0 || UNITY_3_1 || UNITY_3_2 || UNITY_3_3 || UNITY_3_3 || UNITY_3_4 || UNITY_3_5)
        EditorGUIUtility.LookLikeInspector();
#endif
    }
}