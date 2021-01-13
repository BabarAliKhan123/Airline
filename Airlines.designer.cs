﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Airline_management_system
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Airlinemanagement")]
	public partial class AirlinesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAamAdmi(AamAdmi instance);
    partial void UpdateAamAdmi(AamAdmi instance);
    partial void DeleteAamAdmi(AamAdmi instance);
    partial void Insertcode(code instance);
    partial void Updatecode(code instance);
    partial void Deletecode(code instance);
    partial void InsertFlightInfo(FlightInfo instance);
    partial void UpdateFlightInfo(FlightInfo instance);
    partial void DeleteFlightInfo(FlightInfo instance);
    partial void InsertMazdoor(Mazdoor instance);
    partial void UpdateMazdoor(Mazdoor instance);
    partial void DeleteMazdoor(Mazdoor instance);
    partial void InsertTICKETBOOKDETAIL(TICKETBOOKDETAIL instance);
    partial void UpdateTICKETBOOKDETAIL(TICKETBOOKDETAIL instance);
    partial void DeleteTICKETBOOKDETAIL(TICKETBOOKDETAIL instance);
    partial void InsertEmployeeSalary(EmployeeSalary instance);
    partial void UpdateEmployeeSalary(EmployeeSalary instance);
    partial void DeleteEmployeeSalary(EmployeeSalary instance);
    partial void InsertAdmin(Admin instance);
    partial void UpdateAdmin(Admin instance);
    partial void DeleteAdmin(Admin instance);
    #endregion
		
		public AirlinesDataContext() : 
				base(global::Airline_management_system.Properties.Settings.Default.AirlinemanagementConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AirlinesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AirlinesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AirlinesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AirlinesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<AamAdmi> AamAdmis
		{
			get
			{
				return this.GetTable<AamAdmi>();
			}
		}
		
		public System.Data.Linq.Table<code> codes
		{
			get
			{
				return this.GetTable<code>();
			}
		}
		
		public System.Data.Linq.Table<FlightInfo> FlightInfos
		{
			get
			{
				return this.GetTable<FlightInfo>();
			}
		}
		
		public System.Data.Linq.Table<Mazdoor> Mazdoors
		{
			get
			{
				return this.GetTable<Mazdoor>();
			}
		}
		
		public System.Data.Linq.Table<TICKETBOOKDETAIL> TICKETBOOKDETAILs
		{
			get
			{
				return this.GetTable<TICKETBOOKDETAIL>();
			}
		}
		
		public System.Data.Linq.Table<EmployeeSalary> EmployeeSalaries
		{
			get
			{
				return this.GetTable<EmployeeSalary>();
			}
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AamAdmi")]
	public partial class AamAdmi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Address;
		
		private string _Contact_No;
		
		private string _Cnic;
		
		private System.Nullable<int> _Age;
		
		private string _Password;
		
		private string _Gender;
		
		private System.Nullable<System.DateTime> _Reg_Date;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnContact_NoChanging(string value);
    partial void OnContact_NoChanged();
    partial void OnCnicChanging(string value);
    partial void OnCnicChanged();
    partial void OnAgeChanging(System.Nullable<int> value);
    partial void OnAgeChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnReg_DateChanging(System.Nullable<System.DateTime> value);
    partial void OnReg_DateChanged();
    #endregion
		
		public AamAdmi()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(50)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Contact No]", Storage="_Contact_No", DbType="VarChar(MAX)")]
		public string Contact_No
		{
			get
			{
				return this._Contact_No;
			}
			set
			{
				if ((this._Contact_No != value))
				{
					this.OnContact_NoChanging(value);
					this.SendPropertyChanging();
					this._Contact_No = value;
					this.SendPropertyChanged("Contact_No");
					this.OnContact_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cnic", DbType="VarChar(MAX)")]
		public string Cnic
		{
			get
			{
				return this._Cnic;
			}
			set
			{
				if ((this._Cnic != value))
				{
					this.OnCnicChanging(value);
					this.SendPropertyChanging();
					this._Cnic = value;
					this.SendPropertyChanged("Cnic");
					this.OnCnicChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int")]
		public System.Nullable<int> Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NVarChar(50)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Reg Date]", Storage="_Reg_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Reg_Date
		{
			get
			{
				return this._Reg_Date;
			}
			set
			{
				if ((this._Reg_Date != value))
				{
					this.OnReg_DateChanging(value);
					this.SendPropertyChanging();
					this._Reg_Date = value;
					this.SendPropertyChanged("Reg_Date");
					this.OnReg_DateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.codes")]
	public partial class code : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Airport_code;
		
		private string _Airport_logo_type;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnAirport_codeChanging(string value);
    partial void OnAirport_codeChanged();
    partial void OnAirport_logo_typeChanging(string value);
    partial void OnAirport_logo_typeChanged();
    #endregion
		
		public code()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Airport code]", Storage="_Airport_code", DbType="NVarChar(50)")]
		public string Airport_code
		{
			get
			{
				return this._Airport_code;
			}
			set
			{
				if ((this._Airport_code != value))
				{
					this.OnAirport_codeChanging(value);
					this.SendPropertyChanging();
					this._Airport_code = value;
					this.SendPropertyChanged("Airport_code");
					this.OnAirport_codeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Airport logo type]", Storage="_Airport_logo_type", DbType="NVarChar(50)")]
		public string Airport_logo_type
		{
			get
			{
				return this._Airport_logo_type;
			}
			set
			{
				if ((this._Airport_logo_type != value))
				{
					this.OnAirport_logo_typeChanging(value);
					this.SendPropertyChanging();
					this._Airport_logo_type = value;
					this.SendPropertyChanged("Airport_logo_type");
					this.OnAirport_logo_typeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.FlightInfos")]
	public partial class FlightInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _Flight_No;
		
		private string _Airport;
		
		private string _From;
		
		private string _To;
		
		private System.Nullable<System.DateTime> _Departure_Date;
		
		private System.Nullable<System.DateTime> _Arrival_Date;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFlight_NoChanging(System.Nullable<int> value);
    partial void OnFlight_NoChanged();
    partial void OnAirportChanging(string value);
    partial void OnAirportChanged();
    partial void OnFromChanging(string value);
    partial void OnFromChanged();
    partial void OnToChanging(string value);
    partial void OnToChanged();
    partial void OnDeparture_DateChanging(System.Nullable<System.DateTime> value);
    partial void OnDeparture_DateChanged();
    partial void OnArrival_DateChanging(System.Nullable<System.DateTime> value);
    partial void OnArrival_DateChanged();
    #endregion
		
		public FlightInfo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Flight No]", Storage="_Flight_No", DbType="Int")]
		public System.Nullable<int> Flight_No
		{
			get
			{
				return this._Flight_No;
			}
			set
			{
				if ((this._Flight_No != value))
				{
					this.OnFlight_NoChanging(value);
					this.SendPropertyChanging();
					this._Flight_No = value;
					this.SendPropertyChanged("Flight_No");
					this.OnFlight_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Airport", DbType="NVarChar(50)")]
		public string Airport
		{
			get
			{
				return this._Airport;
			}
			set
			{
				if ((this._Airport != value))
				{
					this.OnAirportChanging(value);
					this.SendPropertyChanging();
					this._Airport = value;
					this.SendPropertyChanged("Airport");
					this.OnAirportChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[From]", Storage="_From", DbType="NVarChar(50)")]
		public string From
		{
			get
			{
				return this._From;
			}
			set
			{
				if ((this._From != value))
				{
					this.OnFromChanging(value);
					this.SendPropertyChanging();
					this._From = value;
					this.SendPropertyChanged("From");
					this.OnFromChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[To]", Storage="_To", DbType="NVarChar(50)")]
		public string To
		{
			get
			{
				return this._To;
			}
			set
			{
				if ((this._To != value))
				{
					this.OnToChanging(value);
					this.SendPropertyChanging();
					this._To = value;
					this.SendPropertyChanged("To");
					this.OnToChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Departure Date]", Storage="_Departure_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Departure_Date
		{
			get
			{
				return this._Departure_Date;
			}
			set
			{
				if ((this._Departure_Date != value))
				{
					this.OnDeparture_DateChanging(value);
					this.SendPropertyChanging();
					this._Departure_Date = value;
					this.SendPropertyChanged("Departure_Date");
					this.OnDeparture_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Arrival Date]", Storage="_Arrival_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Arrival_Date
		{
			get
			{
				return this._Arrival_Date;
			}
			set
			{
				if ((this._Arrival_Date != value))
				{
					this.OnArrival_DateChanging(value);
					this.SendPropertyChanging();
					this._Arrival_Date = value;
					this.SendPropertyChanged("Arrival_Date");
					this.OnArrival_DateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Mazdoors")]
	public partial class Mazdoor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _NAME;
		
		private string _ADDRESS;
		
		private string _CONTACT_NO;
		
		private string _POST;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNAMEChanging(string value);
    partial void OnNAMEChanged();
    partial void OnADDRESSChanging(string value);
    partial void OnADDRESSChanged();
    partial void OnCONTACT_NOChanging(string value);
    partial void OnCONTACT_NOChanged();
    partial void OnPOSTChanging(string value);
    partial void OnPOSTChanged();
    #endregion
		
		public Mazdoor()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAME", DbType="NVarChar(50)")]
		public string NAME
		{
			get
			{
				return this._NAME;
			}
			set
			{
				if ((this._NAME != value))
				{
					this.OnNAMEChanging(value);
					this.SendPropertyChanging();
					this._NAME = value;
					this.SendPropertyChanged("NAME");
					this.OnNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ADDRESS", DbType="NVarChar(50)")]
		public string ADDRESS
		{
			get
			{
				return this._ADDRESS;
			}
			set
			{
				if ((this._ADDRESS != value))
				{
					this.OnADDRESSChanging(value);
					this.SendPropertyChanging();
					this._ADDRESS = value;
					this.SendPropertyChanged("ADDRESS");
					this.OnADDRESSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[CONTACT NO]", Storage="_CONTACT_NO", DbType="VarChar(MAX)")]
		public string CONTACT_NO
		{
			get
			{
				return this._CONTACT_NO;
			}
			set
			{
				if ((this._CONTACT_NO != value))
				{
					this.OnCONTACT_NOChanging(value);
					this.SendPropertyChanging();
					this._CONTACT_NO = value;
					this.SendPropertyChanged("CONTACT_NO");
					this.OnCONTACT_NOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_POST", DbType="NVarChar(50)")]
		public string POST
		{
			get
			{
				return this._POST;
			}
			set
			{
				if ((this._POST != value))
				{
					this.OnPOSTChanging(value);
					this.SendPropertyChanging();
					this._POST = value;
					this.SendPropertyChanged("POST");
					this.OnPOSTChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TICKETBOOKDETAILS")]
	public partial class TICKETBOOKDETAIL : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Address;
		
		private string _Contact;
		
		private string _Cnic;
		
		private System.Nullable<int> _Age;
		
		private System.Nullable<int> _Flight_No;
		
		private System.Nullable<System.DateTime> _Departure_Date;
		
		private System.Nullable<System.DateTime> _Arrival_Date;
		
		private string _Passport_No;
		
		private string _Passport_Type;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnContactChanging(string value);
    partial void OnContactChanged();
    partial void OnCnicChanging(string value);
    partial void OnCnicChanged();
    partial void OnAgeChanging(System.Nullable<int> value);
    partial void OnAgeChanged();
    partial void OnFlight_NoChanging(System.Nullable<int> value);
    partial void OnFlight_NoChanged();
    partial void OnDeparture_DateChanging(System.Nullable<System.DateTime> value);
    partial void OnDeparture_DateChanged();
    partial void OnArrival_DateChanging(System.Nullable<System.DateTime> value);
    partial void OnArrival_DateChanged();
    partial void OnPassport_NoChanging(string value);
    partial void OnPassport_NoChanged();
    partial void OnPassport_TypeChanging(string value);
    partial void OnPassport_TypeChanged();
    #endregion
		
		public TICKETBOOKDETAIL()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(50)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contact", DbType="VarChar(MAX)")]
		public string Contact
		{
			get
			{
				return this._Contact;
			}
			set
			{
				if ((this._Contact != value))
				{
					this.OnContactChanging(value);
					this.SendPropertyChanging();
					this._Contact = value;
					this.SendPropertyChanged("Contact");
					this.OnContactChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cnic", DbType="VarChar(MAX)")]
		public string Cnic
		{
			get
			{
				return this._Cnic;
			}
			set
			{
				if ((this._Cnic != value))
				{
					this.OnCnicChanging(value);
					this.SendPropertyChanging();
					this._Cnic = value;
					this.SendPropertyChanged("Cnic");
					this.OnCnicChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int")]
		public System.Nullable<int> Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Flight No]", Storage="_Flight_No", DbType="Int")]
		public System.Nullable<int> Flight_No
		{
			get
			{
				return this._Flight_No;
			}
			set
			{
				if ((this._Flight_No != value))
				{
					this.OnFlight_NoChanging(value);
					this.SendPropertyChanging();
					this._Flight_No = value;
					this.SendPropertyChanged("Flight_No");
					this.OnFlight_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Departure Date]", Storage="_Departure_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Departure_Date
		{
			get
			{
				return this._Departure_Date;
			}
			set
			{
				if ((this._Departure_Date != value))
				{
					this.OnDeparture_DateChanging(value);
					this.SendPropertyChanging();
					this._Departure_Date = value;
					this.SendPropertyChanged("Departure_Date");
					this.OnDeparture_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Arrival Date]", Storage="_Arrival_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Arrival_Date
		{
			get
			{
				return this._Arrival_Date;
			}
			set
			{
				if ((this._Arrival_Date != value))
				{
					this.OnArrival_DateChanging(value);
					this.SendPropertyChanging();
					this._Arrival_Date = value;
					this.SendPropertyChanged("Arrival_Date");
					this.OnArrival_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Passport No]", Storage="_Passport_No", DbType="VarChar(MAX)")]
		public string Passport_No
		{
			get
			{
				return this._Passport_No;
			}
			set
			{
				if ((this._Passport_No != value))
				{
					this.OnPassport_NoChanging(value);
					this.SendPropertyChanging();
					this._Passport_No = value;
					this.SendPropertyChanged("Passport_No");
					this.OnPassport_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Passport Type]", Storage="_Passport_Type", DbType="NVarChar(50)")]
		public string Passport_Type
		{
			get
			{
				return this._Passport_Type;
			}
			set
			{
				if ((this._Passport_Type != value))
				{
					this.OnPassport_TypeChanging(value);
					this.SendPropertyChanging();
					this._Passport_Type = value;
					this.SendPropertyChanged("Passport_Type");
					this.OnPassport_TypeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EmployeeSalarys")]
	public partial class EmployeeSalary : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Contact_No;
		
		private string _Post;
		
		private string _Salary;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnContact_NoChanging(string value);
    partial void OnContact_NoChanged();
    partial void OnPostChanging(string value);
    partial void OnPostChanged();
    partial void OnSalaryChanging(string value);
    partial void OnSalaryChanged();
    #endregion
		
		public EmployeeSalary()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Contact No]", Storage="_Contact_No", DbType="VarChar(MAX)")]
		public string Contact_No
		{
			get
			{
				return this._Contact_No;
			}
			set
			{
				if ((this._Contact_No != value))
				{
					this.OnContact_NoChanging(value);
					this.SendPropertyChanging();
					this._Contact_No = value;
					this.SendPropertyChanged("Contact_No");
					this.OnContact_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Post", DbType="NVarChar(50)")]
		public string Post
		{
			get
			{
				return this._Post;
			}
			set
			{
				if ((this._Post != value))
				{
					this.OnPostChanging(value);
					this.SendPropertyChanging();
					this._Post = value;
					this.SendPropertyChanged("Post");
					this.OnPostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="VarChar(50)")]
		public string Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admins")]
	public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Admin_Name;
		
		private string _Admin_Cnic;
		
		private string _Admin_Contact_No;
		
		private string _Password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnAdmin_NameChanging(string value);
    partial void OnAdmin_NameChanged();
    partial void OnAdmin_CnicChanging(string value);
    partial void OnAdmin_CnicChanged();
    partial void OnAdmin_Contact_NoChanging(string value);
    partial void OnAdmin_Contact_NoChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public Admin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Admin Name]", Storage="_Admin_Name", DbType="NVarChar(50)")]
		public string Admin_Name
		{
			get
			{
				return this._Admin_Name;
			}
			set
			{
				if ((this._Admin_Name != value))
				{
					this.OnAdmin_NameChanging(value);
					this.SendPropertyChanging();
					this._Admin_Name = value;
					this.SendPropertyChanged("Admin_Name");
					this.OnAdmin_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Admin Cnic]", Storage="_Admin_Cnic", DbType="VarChar(MAX)")]
		public string Admin_Cnic
		{
			get
			{
				return this._Admin_Cnic;
			}
			set
			{
				if ((this._Admin_Cnic != value))
				{
					this.OnAdmin_CnicChanging(value);
					this.SendPropertyChanging();
					this._Admin_Cnic = value;
					this.SendPropertyChanged("Admin_Cnic");
					this.OnAdmin_CnicChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Admin Contact No]", Storage="_Admin_Contact_No", DbType="VarChar(MAX)")]
		public string Admin_Contact_No
		{
			get
			{
				return this._Admin_Contact_No;
			}
			set
			{
				if ((this._Admin_Contact_No != value))
				{
					this.OnAdmin_Contact_NoChanging(value);
					this.SendPropertyChanging();
					this._Admin_Contact_No = value;
					this.SendPropertyChanged("Admin_Contact_No");
					this.OnAdmin_Contact_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(MAX)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
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
}
#pragma warning restore 1591
