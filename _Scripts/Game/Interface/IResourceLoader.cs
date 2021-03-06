﻿using UnityEngine;
using System.Collections;

public abstract class IResourceLoader {

    /// <summary>
    /// 同步加载动更资源
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public abstract T LoadAsset<T>(string fileName) where T : UnityEngine.Object;


    /// <summary>
    /// 异步加载动更资源
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public abstract T LoadAssetAsync<T>(string fileName) where T : UnityEngine.Object;

    /// <summary>
    /// 读取文本文件内容
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public abstract string LoadText(string fileName);
}
