﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="trab_marquim")]
public partial class trab_marquimDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertPESSOA(PESSOA instance);
  partial void UpdatePESSOA(PESSOA instance);
  partial void DeletePESSOA(PESSOA instance);
  #endregion
	
	public trab_marquimDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["trab_marquimConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public trab_marquimDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public trab_marquimDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public trab_marquimDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public trab_marquimDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<PESSOA> PESSOAs
	{
		get
		{
			return this.GetTable<PESSOA>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PESSOA")]
public partial class PESSOA : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _NOME;
	
	private string _RUA;
	
	private string _BAIRRO;
	
	private string _CIDADE;
	
	private string _ESTADO;
	
	private System.Nullable<System.DateTime> _DATA_ENTRADA;
	
	private System.Nullable<System.DateTime> _DATA_SAIDA;
	
	private string _QUARTO;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNOMEChanging(string value);
    partial void OnNOMEChanged();
    partial void OnRUAChanging(string value);
    partial void OnRUAChanged();
    partial void OnBAIRROChanging(string value);
    partial void OnBAIRROChanged();
    partial void OnCIDADEChanging(string value);
    partial void OnCIDADEChanged();
    partial void OnESTADOChanging(string value);
    partial void OnESTADOChanged();
    partial void OnDATA_ENTRADAChanging(System.Nullable<System.DateTime> value);
    partial void OnDATA_ENTRADAChanged();
    partial void OnDATA_SAIDAChanging(System.Nullable<System.DateTime> value);
    partial void OnDATA_SAIDAChanged();
    partial void OnQUARTOChanging(string value);
    partial void OnQUARTOChanged();
    #endregion
	
	public PESSOA()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOME", DbType="VarChar(200)")]
	public string NOME
	{
		get
		{
			return this._NOME;
		}
		set
		{
			if ((this._NOME != value))
			{
				this.OnNOMEChanging(value);
				this.SendPropertyChanging();
				this._NOME = value;
				this.SendPropertyChanged("NOME");
				this.OnNOMEChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RUA", DbType="VarChar(200)")]
	public string RUA
	{
		get
		{
			return this._RUA;
		}
		set
		{
			if ((this._RUA != value))
			{
				this.OnRUAChanging(value);
				this.SendPropertyChanging();
				this._RUA = value;
				this.SendPropertyChanged("RUA");
				this.OnRUAChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BAIRRO", DbType="VarChar(200)")]
	public string BAIRRO
	{
		get
		{
			return this._BAIRRO;
		}
		set
		{
			if ((this._BAIRRO != value))
			{
				this.OnBAIRROChanging(value);
				this.SendPropertyChanging();
				this._BAIRRO = value;
				this.SendPropertyChanged("BAIRRO");
				this.OnBAIRROChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CIDADE", DbType="VarChar(200)")]
	public string CIDADE
	{
		get
		{
			return this._CIDADE;
		}
		set
		{
			if ((this._CIDADE != value))
			{
				this.OnCIDADEChanging(value);
				this.SendPropertyChanging();
				this._CIDADE = value;
				this.SendPropertyChanged("CIDADE");
				this.OnCIDADEChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ESTADO", DbType="VarChar(200)")]
	public string ESTADO
	{
		get
		{
			return this._ESTADO;
		}
		set
		{
			if ((this._ESTADO != value))
			{
				this.OnESTADOChanging(value);
				this.SendPropertyChanging();
				this._ESTADO = value;
				this.SendPropertyChanged("ESTADO");
				this.OnESTADOChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DATA_ENTRADA", DbType="Date")]
	public System.Nullable<System.DateTime> DATA_ENTRADA
	{
		get
		{
			return this._DATA_ENTRADA;
		}
		set
		{
			if ((this._DATA_ENTRADA != value))
			{
				this.OnDATA_ENTRADAChanging(value);
				this.SendPropertyChanging();
				this._DATA_ENTRADA = value;
				this.SendPropertyChanged("DATA_ENTRADA");
				this.OnDATA_ENTRADAChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DATA_SAIDA", DbType="Date")]
	public System.Nullable<System.DateTime> DATA_SAIDA
	{
		get
		{
			return this._DATA_SAIDA;
		}
		set
		{
			if ((this._DATA_SAIDA != value))
			{
				this.OnDATA_SAIDAChanging(value);
				this.SendPropertyChanging();
				this._DATA_SAIDA = value;
				this.SendPropertyChanged("DATA_SAIDA");
				this.OnDATA_SAIDAChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QUARTO", DbType="VarChar(20)")]
	public string QUARTO
	{
		get
		{
			return this._QUARTO;
		}
		set
		{
			if ((this._QUARTO != value))
			{
				this.OnQUARTOChanging(value);
				this.SendPropertyChanging();
				this._QUARTO = value;
				this.SendPropertyChanged("QUARTO");
				this.OnQUARTOChanged();
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
