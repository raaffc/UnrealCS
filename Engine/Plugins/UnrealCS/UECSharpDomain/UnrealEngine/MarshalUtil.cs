﻿using System;

namespace UnrealEngine{
    class MarshalUtil{
        public static T[] IntPtrArrayToObjectArray<T>(IntPtr[] ptrs) where T : UObject, new(){
            if (ptrs == null)
                return null;

            T[] objs = new T[ptrs.Length];
            for (int i = 0; i < objs.Length; i++){
                objs[i] = new T();
                objs[i]._this = ptrs[i];
            }

            return objs;
        }

        public static IntPtr[] ObjectArrayToIntPtrArray<T>(T[] ptrs) where T : UObject, new(){
            if (ptrs == null)
                return null;
            IntPtr[] objs = new IntPtr[ptrs.Length];
            for (int i = 0; i < objs.Length; i++){
                objs[i] = ptrs[i]._this.Get();
            }

            return objs;
        }

        /// <summary>
        /// Used by the native hot reload code to create managed instance by name
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public static object CreateInstance(string typeName){
            //todo: this will only find types in the same assembly. it will not work with other assemblies loaded into the domain
            Type type = Type.GetType(typeName);
            if (type == null)
                return null;
            object ret = System.Activator.CreateInstance(type);
            return ret;
        }

        public static object CreateArray(string typeName, int len){
            //todo: this will only find types in the same assembly. it will not work with other assemblies loaded into the domain
            Type type = Type.GetType(typeName);
            if (type == null)
                return null;
            object ret = Array.CreateInstance(type, len);
            return ret;
        }
    }
}