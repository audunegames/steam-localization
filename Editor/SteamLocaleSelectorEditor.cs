using UnityEditor;

namespace Audune.Localization.Steam
{
  // Class that defines an editor for a Steam locale selector
  [CustomEditor(typeof(SteamLocaleSelector))]
  public class SteamLocaleSelectorEditor : UnityEditor.Editor
  {
    // Properties of the editor
    private SerializedProperty _code;
    private SerializedProperty _priority;
    private SerializedProperty _executionMode;

    // Foldout state of the editor
    private bool _selectorSettingsFoldout = true;
    private bool _executionSettingsFoldout = false;


    // Return the target object of the editor
    public new SteamLocaleSelector target => serializedObject.targetObject as SteamLocaleSelector;


    // OnEnable is called when the component becomes enabled
    protected void OnEnable()
    {
      // Initialize the properties
      _code = serializedObject.FindProperty("_code");
      _priority = serializedObject.FindProperty("_priority");
      _executionMode = serializedObject.FindProperty("_executionMode");
    }

    // Draw the inspector GUI
    public override void OnInspectorGUI()
    {
      serializedObject.Update();
      EditorGUI.BeginChangeCheck();

      _selectorSettingsFoldout = EditorGUILayout.BeginFoldoutHeaderGroup(_selectorSettingsFoldout, "Selector Settings");
      if (_selectorSettingsFoldout)
      {
        EditorGUILayout.PropertyField(_code);

        EditorGUILayout.Space();
      }
      EditorGUI.EndFoldoutHeaderGroup();

      _executionSettingsFoldout = EditorGUILayout.BeginFoldoutHeaderGroup(_executionSettingsFoldout, "Execution Settings");
      if (_executionSettingsFoldout)
      {
        EditorGUILayout.PropertyField(_priority);
        EditorGUILayout.PropertyField(_executionMode);
      }
      EditorGUI.EndFoldoutHeaderGroup();

      if (EditorGUI.EndChangeCheck())
        serializedObject.ApplyModifiedProperties();
    }
  }
}