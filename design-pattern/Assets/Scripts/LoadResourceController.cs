using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LoadResourceController
{
    public static readonly Dictionary<string, Object> resourceCache = new Dictionary<string, Object>();
    public static readonly Dictionary<string, Object[]> resourcesCache = new Dictionary<string, Object[]>();
    
    public static T LoadFromResource<T>(string path, string fileName = " ") where T : Object
    {
        string fullPath;
        if (!fileName.Equals(" "))
            fullPath = Path.Combine(path, fileName);
        else fullPath = path;
        if (!resourceCache.ContainsKey(fullPath))
        {
            resourceCache.Add(fullPath, Resources.Load<T>(fullPath));
        }

        return resourceCache[fullPath] as T;
    }

    public static T[] LoadFromResources<T>(string path, string fileName = " ") where T : Object
    {
        string fullPath;
        if (!fileName.Equals(" "))
            fullPath = Path.Combine(path, fileName);
        else fullPath = path;
        if (!resourcesCache.ContainsKey(fullPath))
        {
            T[] datas = Resources.LoadAll<T>(fullPath) as T[];
            resourcesCache.Add(fullPath, datas);
            return datas;
        }

        return resourcesCache[fullPath] as T[];
    }

    public static T[] LoadFromResourcesWithNoCache<T>(string path, string fileName = " ") where T : Object
    {
        string fullPath;
        if (!fileName.Equals(" "))
            fullPath = Path.Combine(path, fileName);
        else fullPath = path;
        return Resources.LoadAll<T>(fullPath) as T[];
    }

    #region Composite Demo

    public static Sprite GetItemIcon(int id)
    {
        return LoadFromResource<Sprite>(string.Format(PathUtils.CompositeDemo, id));
    }

    public static T InitComposite<T>(T t) where T : Object
    {
        return Object.Instantiate(t);
    }
    
    public static InventorySlot GetInventorySlot()
    {
        return InitComposite(LoadFromResource<InventorySlot>(string.Format(PathUtils.CompositeDemo, "inventory_slot")));
    }
    
    public static EquipSlot GetEquipSlot()
    {
        return InitComposite(LoadFromResource<EquipSlot>(string.Format(PathUtils.CompositeDemo, "equip_slot")));
    }
    
    #endregion
}