using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core.Utils;
using UnityEditor;
using UnityEngine;

namespace Editor.Core
{
    public abstract class DictBaseEditor<TKey, TValue> : UnityEditor.Editor
    { 
        private bool _foldOut;

        private const string _serializedListName = "serializedList";
        private const string _keyName = "Key";
        private const string _valueName = "Value";
        
        protected void DrawDict(SerializedProperty dictProperty, GenericDictionary<TKey, TValue> dictionary)
        {
            _foldOut = EditorGUILayout.Foldout(_foldOut, dictProperty.displayName);

            if (!_foldOut) return;

            int margin = 10;
        
            GUIStyle marginStyle = new GUIStyle(GUI.skin.label) {margin = new RectOffset(margin, margin, 0, 0)};
            // do whatever you want with this style, e.g.:

            EditorGUILayout.BeginVertical(marginStyle);

            SerializedProperty pairListProperty = dictProperty.FindPropertyRelative(_serializedListName);

            foreach (SerializedProperty property in pairListProperty)
            {
                SerializedProperty keyProperty = property.FindPropertyRelative(_keyName);

                if (keyProperty.enumValueIndex == -1) continue;

                EditorGUILayout.BeginVertical("box");
            
                EditorGUILayout.LabelField(Utils.GetDisplayName($"{keyProperty.enumNames[keyProperty.enumValueIndex]}"), EditorStyles.boldLabel);
            
                SerializedProperty valueProperty = property.FindPropertyRelative(_valueName);
            
                DrawValue(valueProperty);
            
                EditorGUILayout.EndVertical();
            }
            
            List<TKey> damageTypes = ((TKey[]) Utils.GetEnumValues(typeof(TKey))).ToList();
            
            damageTypes.ForEach(d => { if (!dictionary.ContainsKey(d)) dictionary.Add(d, default(TValue)); });
        
            dictionary.RemoveAll(pair => !damageTypes.Exists(d => d.Equals(pair.Key)));
        
            EditorGUILayout.EndVertical();
        }

        protected abstract void DrawValue(SerializedProperty valueProperty);
    }
}