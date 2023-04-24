//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace GameConfig.Battle
{ 

public sealed partial class TbBuff
{
    private readonly Dictionary<int, Battle.BuffConfig> _dataMap;
    private readonly List<Battle.BuffConfig> _dataList;
    
    public TbBuff(JSONNode _json)
    {
        _dataMap = new Dictionary<int, Battle.BuffConfig>();
        _dataList = new List<Battle.BuffConfig>();
        
        foreach(JSONNode _row in _json.Children)
        {
            var _v = Battle.BuffConfig.DeserializeBuffConfig(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.BuffID, _v);
        }
        PostInit();
    }

    public Dictionary<int, Battle.BuffConfig> DataMap => _dataMap;
    public List<Battle.BuffConfig> DataList => _dataList;

    public Battle.BuffConfig GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Battle.BuffConfig Get(int key) => _dataMap[key];
    public Battle.BuffConfig this[int key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
    
    
    partial void PostInit();
    partial void PostResolve();
}

}