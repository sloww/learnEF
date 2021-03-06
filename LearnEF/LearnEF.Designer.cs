﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace LearnEF
{
    #region 上下文
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    public partial class LearnEFEntities : ObjectContext
    {
        #region 构造函数
    
        /// <summary>
        /// 请使用应用程序配置文件的“LearnEFEntities”部分中的连接字符串初始化新 LearnEFEntities 对象。
        /// </summary>
        public LearnEFEntities() : base("name=LearnEFEntities", "LearnEFEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 LearnEFEntities 对象。
        /// </summary>
        public LearnEFEntities(string connectionString) : base(connectionString, "LearnEFEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 LearnEFEntities 对象。
        /// </summary>
        public LearnEFEntities(EntityConnection connection) : base(connection, "LearnEFEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region 分部方法
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet 属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<Employee> Employees
        {
            get
            {
                if ((_Employees == null))
                {
                    _Employees = base.CreateObjectSet<Employee>("Employees");
                }
                return _Employees;
            }
        }
        private ObjectSet<Employee> _Employees;

        #endregion

        #region AddTo 方法
    
        /// <summary>
        /// 用于向 Employees EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddToEmployees(Employee employee)
        {
            base.AddObject("Employees", employee);
        }

        #endregion

        #region 函数导入
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        /// <param name="firstName">没有元数据文档可用。</param>
        /// <param name="city">没有元数据文档可用。</param>
        public ObjectResult<Employee> SearchEmployee(global::System.String firstName, global::System.String city)
        {
            ObjectParameter firstNameParameter;
            if (firstName != null)
            {
                firstNameParameter = new ObjectParameter("FirstName", firstName);
            }
            else
            {
                firstNameParameter = new ObjectParameter("FirstName", typeof(global::System.String));
            }
    
            ObjectParameter cityParameter;
            if (city != null)
            {
                cityParameter = new ObjectParameter("City", city);
            }
            else
            {
                cityParameter = new ObjectParameter("City", typeof(global::System.String));
            }
    
            return base.ExecuteFunction<Employee>("SearchEmployee", firstNameParameter, cityParameter);
        }
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        /// <param name="mergeOption"></param>
        /// <param name="firstName">没有元数据文档可用。</param>
        /// <param name="city">没有元数据文档可用。</param>
        public ObjectResult<Employee> SearchEmployee(global::System.String firstName, global::System.String city, MergeOption mergeOption)
        {
            ObjectParameter firstNameParameter;
            if (firstName != null)
            {
                firstNameParameter = new ObjectParameter("FirstName", firstName);
            }
            else
            {
                firstNameParameter = new ObjectParameter("FirstName", typeof(global::System.String));
            }
    
            ObjectParameter cityParameter;
            if (city != null)
            {
                cityParameter = new ObjectParameter("City", city);
            }
            else
            {
                cityParameter = new ObjectParameter("City", typeof(global::System.String));
            }
    
            return base.ExecuteFunction<Employee>("SearchEmployee", mergeOption, firstNameParameter, cityParameter);
        }

        #endregion

    }

    #endregion

    #region 实体
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LearnEFModel", Name="Employee")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Employee : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 Employee 对象。
        /// </summary>
        /// <param name="empId">EmpId 属性的初始值。</param>
        public static Employee CreateEmployee(global::System.Int32 empId)
        {
            Employee employee = new Employee();
            employee.EmpId = empId;
            return employee;
        }

        #endregion

        #region 基元属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EmpId
        {
            get
            {
                return _EmpId;
            }
            set
            {
                if (_EmpId != value)
                {
                    OnEmpIdChanging(value);
                    ReportPropertyChanging("EmpId");
                    _EmpId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("EmpId");
                    OnEmpIdChanged();
                }
            }
        }
        private global::System.Int32 _EmpId;
        partial void OnEmpIdChanging(global::System.Int32 value);
        partial void OnEmpIdChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String HREmpId
        {
            get
            {
                return _HREmpId;
            }
            set
            {
                OnHREmpIdChanging(value);
                ReportPropertyChanging("HREmpId");
                _HREmpId = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("HREmpId");
                OnHREmpIdChanged();
            }
        }
        private global::System.String _HREmpId;
        partial void OnHREmpIdChanging(global::System.String value);
        partial void OnHREmpIdChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("City");
                OnCityChanged();
            }
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();

        #endregion

    
    }

    #endregion

    
}
