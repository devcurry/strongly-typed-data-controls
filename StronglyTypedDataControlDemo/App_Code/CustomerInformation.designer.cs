﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ExampleDB")]
public partial class CustomerInformationDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertCustomer(Customer instance);
  partial void UpdateCustomer(Customer instance);
  partial void DeleteCustomer(Customer instance);
  #endregion
	
	public CustomerInformationDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ExampleDBConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public CustomerInformationDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CustomerInformationDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CustomerInformationDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CustomerInformationDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Customer> Customers
	{
		get
		{
			return this.GetTable<Customer>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customers")]
public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _CustomerID;
	
	private string _ContactName;
	
	private string _State;
	
	private string _Country;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIDChanging(string value);
    partial void OnCustomerIDChanged();
    partial void OnContactNameChanging(string value);
    partial void OnContactNameChanged();
    partial void OnStateChanging(string value);
    partial void OnStateChanged();
    partial void OnCountryChanging(string value);
    partial void OnCountryChanged();
    #endregion
	
	public Customer()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string CustomerID
	{
		get
		{
			return this._CustomerID;
		}
		set
		{
			if ((this._CustomerID != value))
			{
				this.OnCustomerIDChanging(value);
				this.SendPropertyChanging();
				this._CustomerID = value;
				this.SendPropertyChanged("CustomerID");
				this.OnCustomerIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactName", DbType="VarChar(20)")]
	public string ContactName
	{
		get
		{
			return this._ContactName;
		}
		set
		{
			if ((this._ContactName != value))
			{
				this.OnContactNameChanging(value);
				this.SendPropertyChanging();
				this._ContactName = value;
				this.SendPropertyChanged("ContactName");
				this.OnContactNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="VarChar(20)")]
	public string State
	{
		get
		{
			return this._State;
		}
		set
		{
			if ((this._State != value))
			{
				this.OnStateChanging(value);
				this.SendPropertyChanging();
				this._State = value;
				this.SendPropertyChanged("State");
				this.OnStateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="VarChar(20)")]
	public string Country
	{
		get
		{
			return this._Country;
		}
		set
		{
			if ((this._Country != value))
			{
				this.OnCountryChanging(value);
				this.SendPropertyChanging();
				this._Country = value;
				this.SendPropertyChanged("Country");
				this.OnCountryChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
#pragma warning restore 1591