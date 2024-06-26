
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LuBan.Runtime;
using GameFrameX.Config;
using SimpleJSON;

namespace Hotfix.Config.test
{
    public sealed partial class TestMapper : LuBan.Runtime.BeanBase
    {
        public TestMapper(JSONNode _buf)
        {
            { if(!_buf["id"].IsNumber) { throw new SerializationException(); }  Id = _buf["id"]; }
            { if(!_buf["audio_type"].IsNumber) { throw new SerializationException(); }  AudioType = (UnityEngine.AudioType)_buf["audio_type"].AsInt; }
            { if(!_buf["v2"].IsObject) { throw new SerializationException(); }  V2 = ExternalTypeUtil.NewVector2(vec2.Deserializevec2(_buf["v2"]));  }
            PostInit();
        }

        public static TestMapper DeserializeTestMapper(JSONNode _buf)
        {
            return new test.TestMapper(_buf);
        }

        public readonly int Id;
        public readonly UnityEngine.AudioType AudioType;
        public readonly UnityEngine.Vector2 V2;
        public const int __ID__ = 149110895;
        public override int GetTypeId() => __ID__;

        public  void ResolveRef(TablesComponent tables)
        {
            
            
            
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "audioType:" + AudioType + ","
            + "v2:" + V2 + ","
            + "}";
        }

        partial void PostInit();
    }
}
