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
            P testValueAsObject,
            X convertValueAsObject,
            Expression<Func<T, P>> propExpresionClass,
            Expression<Func<T, P>> fieldExpresionClass,
            Expression<Func<U, P>> propExpresionStruct,
            Expression<Func<U, P>> fieldExpresionStruct)
        {
            _instanceClassAsObject = new T();
            _instanceStructAsObject = new U();

            _testValueAsObject = testValueAsObject;
            _convertValueAsObject = convertValueAsObject;

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
        private object _instanceClassAsObject;
        private object _instanceStructAsObject;

        private object _testValueAsObject;
        private object _convertValueAsObject;
        
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
            var value = _propGetterClass(_instanceClassAsObject);
        }

        [Benchmark]
        public void Get_Prop_Struct()
        {
            var value = _propGetterStruct(_instanceStructAsObject);
        }

        [Benchmark]
        public void Get_Field_Class()
        {
            var value = _fieldGetterClass(_instanceClassAsObject);
        }

        [Benchmark]
        public void Get_Field_Struct()
        {
            var value = _fieldGetterStruct(_instanceStructAsObject);
        }

        [Benchmark]
        public void Set_Prop_Class()
        {
            _propSetterClass(_instanceClassAsObject, _testValueAsObject);
        }

        [Benchmark]
        public void Set_Prop_Struct()
        {
            _propSetterStruct(_instanceStructAsObject, _testValueAsObject);
        }

        [Benchmark]
        public void Set_Field_Class()
        {
            _fieldSetterClass(_instanceClassAsObject, _testValueAsObject);
        }

        [Benchmark]
        public void Set_Field_Struct()
        {
            _fieldSetterStruct(_instanceStructAsObject, _testValueAsObject);
        }

        [Benchmark]
        public void Set_Prop_WithConvert_Class()
        {
            _propSetterClass(_instanceClassAsObject, _convertValueAsObject);
        }

        [Benchmark]
        public void Set_Prop_WithConvert_Struct()
        {
            _propSetterStruct(_instanceStructAsObject, _convertValueAsObject);
        }

        [Benchmark]
        public void Set_Field_WithConvert_Class()
        {
            _fieldSetterClass(_instanceClassAsObject, _convertValueAsObject);
        }

        [Benchmark]
        public void Set_Field_WithConvert_Struct()
        {
            _fieldSetterStruct(_instanceStructAsObject, _convertValueAsObject);
        }
        #endregion
    }
}