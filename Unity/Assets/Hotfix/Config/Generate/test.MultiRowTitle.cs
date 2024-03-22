
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LuBan.Runtime;
using SimpleJSON;


namespace cfg.test
{
    
    public sealed partial class MultiRowTitle : LuBan.Runtime.BeanBase
    {
        public MultiRowTitle(JSONNode _buf) 
        {
            { if(!_buf["id"].IsNumber) { throw new SerializationException(); }  Id = _buf["id"]; }
            { if(!_buf["name"].IsString) { throw new SerializationException(); }  Name = _buf["name"]; }
            { if(!_buf["x1"].IsObject) { throw new SerializationException(); }  X1 = test.H1.DeserializeH1(_buf["x1"]);  }
            { var _j = _buf["x2_0"]; if (_j.Tag != JSONNodeType.None && _j.Tag != JSONNodeType.NullValue) { { if(!_j.IsObject) { throw new SerializationException(); }  X20 = test.H2.DeserializeH2(_j);  } } else { X20 = null; } }
            { var __json0 = _buf["x2"]; if(!__json0.IsArray) { throw new SerializationException(); } X2 = new System.Collections.Generic.List<test.H2>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { test.H2 __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = test.H2.DeserializeH2(__e0);  }  X2.Add(__v0); }   }
            { var __json0 = _buf["x3"]; if(!__json0.IsArray) { throw new SerializationException(); } int _n0 = __json0.Count; X3 = new test.H2[_n0]; int __index0=0; foreach(JSONNode __e0 in __json0.Children) { test.H2 __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = test.H2.DeserializeH2(__e0);  }  X3[__index0++] = __v0; }   }
            { var __json0 = _buf["x4"]; if(!__json0.IsArray) { throw new SerializationException(); } int _n0 = __json0.Count; X4 = new test.H2[_n0]; int __index0=0; foreach(JSONNode __e0 in __json0.Children) { test.H2 __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = test.H2.DeserializeH2(__e0);  }  X4[__index0++] = __v0; }   }
        }
    
        public static MultiRowTitle DeserializeMultiRowTitle(JSONNode _buf)
        {
            return new test.MultiRowTitle(_buf);
        }
    
        public readonly int Id;
        public readonly string Name;
        public readonly test.H1 X1;
        public readonly test.H2 X20;
        public readonly System.Collections.Generic.List<test.H2> X2;
        public readonly test.H2[] X3;
        public readonly test.H2[] X4;
       
        public const int __ID__ = 540002427;
        public override int GetTypeId() => __ID__;
    
        public  void ResolveRef(Tables tables)
        {
            
            
            X1?.ResolveRef(tables);
            X20?.ResolveRef(tables);
            foreach (var _e in X2) { _e?.ResolveRef(tables); }
            foreach (var _e in X3) { _e?.ResolveRef(tables); }
            foreach (var _e in X4) { _e?.ResolveRef(tables); }
        }
    
        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "name:" + Name + ","
            + "x1:" + X1 + ","
            + "x20:" + X20 + ","
            + "x2:" + StringUtil.CollectionToString(X2) + ","
            + "x3:" + StringUtil.CollectionToString(X3) + ","
            + "x4:" + StringUtil.CollectionToString(X4) + ","
            + "}";
        }
    }

}