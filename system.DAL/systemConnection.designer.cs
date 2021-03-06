#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace system.DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="db_salesSystem")]
	public partial class systemConnectionDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertcategory(category instance);
    partial void Updatecategory(category instance);
    partial void Deletecategory(category instance);
    partial void Insertproducts(products instance);
    partial void Updateproducts(products instance);
    partial void Deleteproducts(products instance);
    partial void Insertmarketplace(marketplace instance);
    partial void Updatemarketplace(marketplace instance);
    partial void Deletemarketplace(marketplace instance);
    partial void Insertseller(seller instance);
    partial void Updateseller(seller instance);
    partial void Deleteseller(seller instance);
    #endregion
		
		public systemConnectionDataContext() : 
				base(global::system.DAL.Properties.Settings.Default.db_salesSystemConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public systemConnectionDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public systemConnectionDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public systemConnectionDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public systemConnectionDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<category> category
		{
			get
			{
				return this.GetTable<category>();
			}
		}
		
		public System.Data.Linq.Table<products> products
		{
			get
			{
				return this.GetTable<products>();
			}
		}
		
		public System.Data.Linq.Table<marketplace> marketplace
		{
			get
			{
				return this.GetTable<marketplace>();
			}
		}
		
		public System.Data.Linq.Table<seller> seller
		{
			get
			{
				return this.GetTable<seller>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.id_category")]
	public partial class category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_category1;
		
		private string _name;
		
		private string _description;
		
		private EntitySet<products> _products;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_category1Changing(int value);
    partial void Onid_category1Changed();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    #endregion
		
		public category()
		{
			this._products = new EntitySet<products>(new Action<products>(this.attach_products), new Action<products>(this.detach_products));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_category", Storage="_id_category1", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_category1
		{
			get
			{
				return this._id_category1;
			}
			set
			{
				if ((this._id_category1 != value))
				{
					this.Onid_category1Changing(value);
					this.SendPropertyChanging();
					this._id_category1 = value;
					this.SendPropertyChanged("id_category1");
					this.Onid_category1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="VarChar(100)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="category_products", Storage="_products", ThisKey="id_category1", OtherKey="id_category")]
		public EntitySet<products> products
		{
			get
			{
				return this._products;
			}
			set
			{
				this._products.Assign(value);
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
		
		private void attach_products(products entity)
		{
			this.SendPropertyChanging();
			entity.category = this;
		}
		
		private void detach_products(products entity)
		{
			this.SendPropertyChanging();
			entity.category = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_products")]
	public partial class products : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_products;
		
		private string _name;
		
		private string _description;
		
		private System.Nullable<decimal> _value;
		
		private System.Nullable<int> _id_category;
		
		private EntityRef<category> _category;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_productsChanging(int value);
    partial void Onid_productsChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OnvalueChanging(System.Nullable<decimal> value);
    partial void OnvalueChanged();
    partial void Onid_categoryChanging(System.Nullable<int> value);
    partial void Onid_categoryChanged();
    #endregion
		
		public products()
		{
			this._category = default(EntityRef<category>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_products", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_products
		{
			get
			{
				return this._id_products;
			}
			set
			{
				if ((this._id_products != value))
				{
					this.Onid_productsChanging(value);
					this.SendPropertyChanging();
					this._id_products = value;
					this.SendPropertyChanged("id_products");
					this.Onid_productsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="VarChar(100)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_value", DbType="Decimal(25,0)")]
		public System.Nullable<decimal> value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((this._value != value))
				{
					this.OnvalueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("value");
					this.OnvalueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_category", DbType="Int")]
		public System.Nullable<int> id_category
		{
			get
			{
				return this._id_category;
			}
			set
			{
				if ((this._id_category != value))
				{
					if (this._category.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_categoryChanging(value);
					this.SendPropertyChanging();
					this._id_category = value;
					this.SendPropertyChanged("id_category");
					this.Onid_categoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="category_products", Storage="_category", ThisKey="id_category", OtherKey="id_category1", IsForeignKey=true)]
		public category category
		{
			get
			{
				return this._category.Entity;
			}
			set
			{
				category previousValue = this._category.Entity;
				if (((previousValue != value) 
							|| (this._category.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._category.Entity = null;
						previousValue.products.Remove(this);
					}
					this._category.Entity = value;
					if ((value != null))
					{
						value.products.Add(this);
						this._id_category = value.id_category1;
					}
					else
					{
						this._id_category = default(Nullable<int>);
					}
					this.SendPropertyChanged("category");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_marketplace")]
	public partial class marketplace : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_marketplace;
		
		private string _name;
		
		private string _description;
		
		private string _site;
		
		private string _telephone;
		
		private string _email;
		
		private string _contact;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_marketplaceChanging(int value);
    partial void Onid_marketplaceChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OnsiteChanging(string value);
    partial void OnsiteChanged();
    partial void OntelephoneChanging(string value);
    partial void OntelephoneChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OncontactChanging(string value);
    partial void OncontactChanged();
    #endregion
		
		public marketplace()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_marketplace", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_marketplace
		{
			get
			{
				return this._id_marketplace;
			}
			set
			{
				if ((this._id_marketplace != value))
				{
					this.Onid_marketplaceChanging(value);
					this.SendPropertyChanging();
					this._id_marketplace = value;
					this.SendPropertyChanged("id_marketplace");
					this.Onid_marketplaceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="VarChar(100)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_site", DbType="VarChar(50)")]
		public string site
		{
			get
			{
				return this._site;
			}
			set
			{
				if ((this._site != value))
				{
					this.OnsiteChanging(value);
					this.SendPropertyChanging();
					this._site = value;
					this.SendPropertyChanged("site");
					this.OnsiteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telephone", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string telephone
		{
			get
			{
				return this._telephone;
			}
			set
			{
				if ((this._telephone != value))
				{
					this.OntelephoneChanging(value);
					this.SendPropertyChanging();
					this._telephone = value;
					this.SendPropertyChanged("telephone");
					this.OntelephoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contact", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string contact
		{
			get
			{
				return this._contact;
			}
			set
			{
				if ((this._contact != value))
				{
					this.OncontactChanging(value);
					this.SendPropertyChanging();
					this._contact = value;
					this.SendPropertyChanged("contact");
					this.OncontactChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_seller")]
	public partial class seller : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name_fantasy;
		
		private string _company_name;
		
		private string _cnpj;
		
		private string _email;
		
		private string _telephone;
		
		private string _address;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onname_fantasyChanging(string value);
    partial void Onname_fantasyChanged();
    partial void Oncompany_nameChanging(string value);
    partial void Oncompany_nameChanged();
    partial void OncnpjChanging(string value);
    partial void OncnpjChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OntelephoneChanging(string value);
    partial void OntelephoneChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    #endregion
		
		public seller()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name_fantasy", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string name_fantasy
		{
			get
			{
				return this._name_fantasy;
			}
			set
			{
				if ((this._name_fantasy != value))
				{
					this.Onname_fantasyChanging(value);
					this.SendPropertyChanging();
					this._name_fantasy = value;
					this.SendPropertyChanged("name_fantasy");
					this.Onname_fantasyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_company_name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string company_name
		{
			get
			{
				return this._company_name;
			}
			set
			{
				if ((this._company_name != value))
				{
					this.Oncompany_nameChanging(value);
					this.SendPropertyChanging();
					this._company_name = value;
					this.SendPropertyChanged("company_name");
					this.Oncompany_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cnpj", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string cnpj
		{
			get
			{
				return this._cnpj;
			}
			set
			{
				if ((this._cnpj != value))
				{
					this.OncnpjChanging(value);
					this.SendPropertyChanging();
					this._cnpj = value;
					this.SendPropertyChanged("cnpj");
					this.OncnpjChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telephone", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string telephone
		{
			get
			{
				return this._telephone;
			}
			set
			{
				if ((this._telephone != value))
				{
					this.OntelephoneChanging(value);
					this.SendPropertyChanging();
					this._telephone = value;
					this.SendPropertyChanged("telephone");
					this.OntelephoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
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
