﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LookAtPoint))]
{

    void OnEnable()
        /*
         *    EditorGUILayout.LabelField（）标签字段 
         *    EditorGUILayout.IntField（） 整数字段 
         *    EditorGUILayout.FloatField（） 浮点数字段 
         *    EditorGUILayout.TextField（） 文本字段 
         *    EditorGUILayout.Vector2Field（） 二维向量字段 
         *    EditorGUILayout.Vector3Field（） 三维向量字段 
         *    EditorGUILayout.Vector4Field（） 四维向量字段 
         * 
         *    EditorGUILayout.ColorField（） 颜色字段
        serializedObject.Update();
            //EditorGUILayout.LabelField("(Below this object)");
            //EditorGUILayout.HelpBox()用于绘制一个盒子（也可以看作矩形框），然后在盒子里显示提示信息
            EditorGUILayout.HelpBox("(Below this object)", MessageType.Info);
        EditorGUI.BeginChangeCheck();