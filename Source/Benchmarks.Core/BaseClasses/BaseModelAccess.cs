using BenchmarkDotNet.Attributes;
using Deipax.Core.Common;
using System;
using System.Linq.Expressions;

namespace Benchmarks.Core.BaseClasses
{
    public abstract class BaseModelAccess<T, U, P, X> 
        where T : class, new()
        where U : struct
    {
        public BaseModelAccess(
            P testValue,
            X convertValue,
            Expression<Func<T, P>> propExpresionClass,
            Expression<Func<T, P>> fieldExpresionClass,
            Expression<Func<U, P>> propExpresionStruct,
            Expression<Func<U, P>> fieldExpresionStruct)
        {
            _instanceClass = new T();
            _instanceStruct = new U();

            _testValue = testValue;
            _convertValue = convertValue;

            _propSetterClass = ModelAccess<T>.GetSetter(propExpresionClass).Set;
            _propGetterClass = ModelAccess<T>.GetGetter(propExpresionClass).Get;
            _fieldSetterClass = ModelAccess<T>.GetSetter(fieldExpresionClass).Set;
            _fieldGetterClass = ModelAccess<T>.GetGetter(fieldExpresionClass).Get;

            _propSetterStruct = ModelAccess<U>.GetSetter(propExpresionStruct).Set;
            _propGetterStruct = ModelAccess<U>.GetGetter(propExpresionStruct).Get;
            _fieldSetterStruct = ModelAccess<U>.GetSetter(fieldExpresionStruct).Set;
            _fieldGetterStruct = ModelAccess<U>.GetGetter(fieldExpresionStruct).Get;
        }

        #region Field Member
        private T _instanceClass;
        private U _instanceStruct;

        private P _testValue;
        private X _convertValue;
        
        private Action<object, object> _propSetterClass;
        private Func<object, object> _propGetterClass;
        private Action<object, object> _fieldSetterClass;
        private Func<object, object> _fieldGetterClass;

        private Action<object, object> _propSetterStruct;
        private Func<object, object> _propGetterStruct;
        private Action<object, object> _fieldSetterStruct;
        private Func<object, object> _fieldGetterStruct;
        #endregion

        #region Public Members
        [Benchmark]
        public void Get_Prop_Class()
        {
            P value = (P)_propGetterClass(_instanceClass);
        }

        [Benchmark]
        public void Get_Prop_Struct()
        {
            P value = (P)_propGetterStruct(_instanceStruct);
        }

        [Benchmark]
        public void Get_Field_Class()
        {
            P value = (P)_fieldGetterClass(_instanceClass);
        }

        [Benchmark]
        public void Get_Field_Struct()
        {
            P value = (P)_fieldGetterStruct(_instanceStruct);
        }

        [Benchmark]
        public void Set_Prop_Class()
        {
            _propSetterClass(_instanceClass, _testValue);
        }

        [Benchmark]
        public void Set_Prop_Struct()
        {
            _propSetterStruct(_instanceStruct, _testValue);
        }

        [Benchmark]
        public void Set_Field_Class()
        {
            _fieldSetterClass(_instanceClass, _testValue);
        }

        [Benchmark]
        public void Set_Field_Struct()
        {
            _fieldSetterStruct(_instanceStruct, _testValue);
        }

        [Benchmark]
        public void Set_Prop_WithConvert_Class()
        {
            _propSetterClass(_instanceClass, _convertValue);
        }

        [Benchmark]
        public void Set_Prop_WithConvert_Struct()
        {
            _propSetterStruct(_instanceStruct, _convertValue);
        }

        [Benchmark]
        public void Set_Field_WithConvert_Class()
        {
            _fieldSetterClass(_instanceClass, _convertValue);
        }

        [Benchmark]
        public void Set_Field_WithConvert_Struct()
        {
            _fieldSetterStruct(_instanceStruct, _convertValue);
        }
        #endregion
    }
}