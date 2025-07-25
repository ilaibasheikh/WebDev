﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace WebApplication15.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DatabaseFirstEFEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DatabaseFirstEFEntities object using the connection string found in the 'DatabaseFirstEFEntities' section of the application configuration file.
        /// </summary>
        public DatabaseFirstEFEntities() : base("name=DatabaseFirstEFEntities", "DatabaseFirstEFEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DatabaseFirstEFEntities object.
        /// </summary>
        public DatabaseFirstEFEntities(string connectionString) : base(connectionString, "DatabaseFirstEFEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DatabaseFirstEFEntities object.
        /// </summary>
        public DatabaseFirstEFEntities(EntityConnection connection) : base(connection, "DatabaseFirstEFEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<student> students
        {
            get
            {
                if ((_students == null))
                {
                    _students = base.CreateObjectSet<student>("students");
                }
                return _students;
            }
        }
        private ObjectSet<student> _students;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the students EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTostudents(student student)
        {
            base.AddObject("students", student);
        }

        internal object Entry(student s)
        {
            throw new NotImplementedException();
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DatabaseFirstEFModel", Name="student")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class student : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new student object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="gender">Initial value of the gender property.</param>
        /// <param name="age">Initial value of the age property.</param>
        /// <param name="class">Initial value of the class property.</param>
        public static student Createstudent(global::System.Int32 id, global::System.String name, global::System.String gender, global::System.Int32 age, global::System.Int32 @class)
        {
            student student = new student();
            student.id = id;
            student.name = name;
            student.gender = gender;
            student.age = age;
            student.@class = @class;
            return student;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value, "id");
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false, "name");
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String gender
        {
            get
            {
                return _gender;
            }
            set
            {
                OngenderChanging(value);
                ReportPropertyChanging("gender");
                _gender = StructuralObject.SetValidValue(value, false, "gender");
                ReportPropertyChanged("gender");
                OngenderChanged();
            }
        }
        private global::System.String _gender;
        partial void OngenderChanging(global::System.String value);
        partial void OngenderChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 age
        {
            get
            {
                return _age;
            }
            set
            {
                OnageChanging(value);
                ReportPropertyChanging("age");
                _age = StructuralObject.SetValidValue(value, "age");
                ReportPropertyChanged("age");
                OnageChanged();
            }
        }
        private global::System.Int32 _age;
        partial void OnageChanging(global::System.Int32 value);
        partial void OnageChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 @class
        {
            get
            {
                return _class;
            }
            set
            {
                OnclassChanging(value);
                ReportPropertyChanging("class");
                _class = StructuralObject.SetValidValue(value, "class");
                ReportPropertyChanged("class");
                OnclassChanged();
            }
        }
        private global::System.Int32 _class;
        partial void OnclassChanging(global::System.Int32 value);
        partial void OnclassChanged();

        #endregion

    }

    #endregion

}
