﻿using System;

namespace JxCode.Common
{
    public class Singleton<T> : IDisposable where T : class, new()
    {
        private static T mInstance;
        public static T Instance
        {
            get => GetInstance();
        }
        public static T GetInstance()
        {
            if (mInstance == null)
            {
                mInstance = Activator.CreateInstance<T>();
            }
            return mInstance;
        }

        public virtual void Dispose()
        {
        }
    }
}
