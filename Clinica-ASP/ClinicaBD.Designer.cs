﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
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
#region Metadatos de relaciones en EDM

[assembly: EdmRelationshipAttribute("ClinicaAspModel", "FK__Cita__Cedula__09DE7BCC", "Usuario", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Clinica_ASP.Usuario), "Cita", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Clinica_ASP.Cita), true)]
[assembly: EdmRelationshipAttribute("ClinicaAspModel", "FK__FormulaMe__IdCit__0EA330E9", "Cita", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Clinica_ASP.Cita), "FormulaMedica", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Clinica_ASP.FormulaMedica), true)]
[assembly: EdmRelationshipAttribute("ClinicaAspModel", "FK__TipoUsuar__Cedul__0519C6AF", "Usuario", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Clinica_ASP.Usuario), "TipoUsuario", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Clinica_ASP.TipoUsuario), true)]

#endregion

namespace Clinica_ASP
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class ClinicaAspEntities : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto ClinicaAspEntities usando la cadena de conexión encontrada en la sección 'ClinicaAspEntities' del archivo de configuración de la aplicación.
        /// </summary>
        public ClinicaAspEntities() : base("name=ClinicaAspEntities", "ClinicaAspEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto ClinicaAspEntities.
        /// </summary>
        public ClinicaAspEntities(string connectionString) : base(connectionString, "ClinicaAspEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto ClinicaAspEntities.
        /// </summary>
        public ClinicaAspEntities(EntityConnection connection) : base(connection, "ClinicaAspEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Cita> Cita
        {
            get
            {
                if ((_Cita == null))
                {
                    _Cita = base.CreateObjectSet<Cita>("Cita");
                }
                return _Cita;
            }
        }
        private ObjectSet<Cita> _Cita;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<FormulaMedica> FormulaMedica
        {
            get
            {
                if ((_FormulaMedica == null))
                {
                    _FormulaMedica = base.CreateObjectSet<FormulaMedica>("FormulaMedica");
                }
                return _FormulaMedica;
            }
        }
        private ObjectSet<FormulaMedica> _FormulaMedica;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<TipoUsuario> TipoUsuario
        {
            get
            {
                if ((_TipoUsuario == null))
                {
                    _TipoUsuario = base.CreateObjectSet<TipoUsuario>("TipoUsuario");
                }
                return _TipoUsuario;
            }
        }
        private ObjectSet<TipoUsuario> _TipoUsuario;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Usuario> Usuario
        {
            get
            {
                if ((_Usuario == null))
                {
                    _Usuario = base.CreateObjectSet<Usuario>("Usuario");
                }
                return _Usuario;
            }
        }
        private ObjectSet<Usuario> _Usuario;

        #endregion

        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Cita. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToCita(Cita cita)
        {
            base.AddObject("Cita", cita);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet FormulaMedica. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToFormulaMedica(FormulaMedica formulaMedica)
        {
            base.AddObject("FormulaMedica", formulaMedica);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet TipoUsuario. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToTipoUsuario(TipoUsuario tipoUsuario)
        {
            base.AddObject("TipoUsuario", tipoUsuario);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Usuario. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToUsuario(Usuario usuario)
        {
            base.AddObject("Usuario", usuario);
        }

        #endregion

    }

    #endregion

    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ClinicaAspModel", Name="Cita")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Cita : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Cita.
        /// </summary>
        /// <param name="idCita">Valor inicial de la propiedad IdCita.</param>
        /// <param name="cedula">Valor inicial de la propiedad Cedula.</param>
        /// <param name="fechaCita">Valor inicial de la propiedad FechaCita.</param>
        /// <param name="horaCita">Valor inicial de la propiedad HoraCita.</param>
        /// <param name="descripcion">Valor inicial de la propiedad Descripcion.</param>
        public static Cita CreateCita(global::System.Int32 idCita, global::System.Int32 cedula, global::System.DateTime fechaCita, global::System.String horaCita, global::System.String descripcion)
        {
            Cita cita = new Cita();
            cita.IdCita = idCita;
            cita.Cedula = cedula;
            cita.FechaCita = fechaCita;
            cita.HoraCita = horaCita;
            cita.Descripcion = descripcion;
            return cita;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdCita
        {
            get
            {
                return _IdCita;
            }
            set
            {
                if (_IdCita != value)
                {
                    OnIdCitaChanging(value);
                    ReportPropertyChanging("IdCita");
                    _IdCita = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("IdCita");
                    OnIdCitaChanged();
                }
            }
        }
        private global::System.Int32 _IdCita;
        partial void OnIdCitaChanging(global::System.Int32 value);
        partial void OnIdCitaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Cedula
        {
            get
            {
                return _Cedula;
            }
            set
            {
                OnCedulaChanging(value);
                ReportPropertyChanging("Cedula");
                _Cedula = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Cedula");
                OnCedulaChanged();
            }
        }
        private global::System.Int32 _Cedula;
        partial void OnCedulaChanging(global::System.Int32 value);
        partial void OnCedulaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime FechaCita
        {
            get
            {
                return _FechaCita;
            }
            set
            {
                OnFechaCitaChanging(value);
                ReportPropertyChanging("FechaCita");
                _FechaCita = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FechaCita");
                OnFechaCitaChanged();
            }
        }
        private global::System.DateTime _FechaCita;
        partial void OnFechaCitaChanging(global::System.DateTime value);
        partial void OnFechaCitaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String HoraCita
        {
            get
            {
                return _HoraCita;
            }
            set
            {
                OnHoraCitaChanging(value);
                ReportPropertyChanging("HoraCita");
                _HoraCita = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("HoraCita");
                OnHoraCitaChanged();
            }
        }
        private global::System.String _HoraCita;
        partial void OnHoraCitaChanging(global::System.String value);
        partial void OnHoraCitaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Descripcion
        {
            get
            {
                return _Descripcion;
            }
            set
            {
                OnDescripcionChanging(value);
                ReportPropertyChanging("Descripcion");
                _Descripcion = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Descripcion");
                OnDescripcionChanged();
            }
        }
        private global::System.String _Descripcion;
        partial void OnDescripcionChanging(global::System.String value);
        partial void OnDescripcionChanged();

        #endregion

    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ClinicaAspModel", "FK__Cita__Cedula__09DE7BCC", "Usuario")]
        public Usuario Usuario
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Usuario>("ClinicaAspModel.FK__Cita__Cedula__09DE7BCC", "Usuario").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Usuario>("ClinicaAspModel.FK__Cita__Cedula__09DE7BCC", "Usuario").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Usuario> UsuarioReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Usuario>("ClinicaAspModel.FK__Cita__Cedula__09DE7BCC", "Usuario");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Usuario>("ClinicaAspModel.FK__Cita__Cedula__09DE7BCC", "Usuario", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ClinicaAspModel", "FK__FormulaMe__IdCit__0EA330E9", "FormulaMedica")]
        public EntityCollection<FormulaMedica> FormulaMedica
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<FormulaMedica>("ClinicaAspModel.FK__FormulaMe__IdCit__0EA330E9", "FormulaMedica");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<FormulaMedica>("ClinicaAspModel.FK__FormulaMe__IdCit__0EA330E9", "FormulaMedica", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ClinicaAspModel", Name="FormulaMedica")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class FormulaMedica : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto FormulaMedica.
        /// </summary>
        /// <param name="idCita">Valor inicial de la propiedad IdCita.</param>
        /// <param name="idFormulaMedica">Valor inicial de la propiedad IdFormulaMedica.</param>
        /// <param name="recetaMedica">Valor inicial de la propiedad RecetaMedica.</param>
        public static FormulaMedica CreateFormulaMedica(global::System.Int32 idCita, global::System.Int32 idFormulaMedica, global::System.String recetaMedica)
        {
            FormulaMedica formulaMedica = new FormulaMedica();
            formulaMedica.IdCita = idCita;
            formulaMedica.IdFormulaMedica = idFormulaMedica;
            formulaMedica.RecetaMedica = recetaMedica;
            return formulaMedica;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdCita
        {
            get
            {
                return _IdCita;
            }
            set
            {
                OnIdCitaChanging(value);
                ReportPropertyChanging("IdCita");
                _IdCita = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IdCita");
                OnIdCitaChanged();
            }
        }
        private global::System.Int32 _IdCita;
        partial void OnIdCitaChanging(global::System.Int32 value);
        partial void OnIdCitaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdFormulaMedica
        {
            get
            {
                return _IdFormulaMedica;
            }
            set
            {
                if (_IdFormulaMedica != value)
                {
                    OnIdFormulaMedicaChanging(value);
                    ReportPropertyChanging("IdFormulaMedica");
                    _IdFormulaMedica = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("IdFormulaMedica");
                    OnIdFormulaMedicaChanged();
                }
            }
        }
        private global::System.Int32 _IdFormulaMedica;
        partial void OnIdFormulaMedicaChanging(global::System.Int32 value);
        partial void OnIdFormulaMedicaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String RecetaMedica
        {
            get
            {
                return _RecetaMedica;
            }
            set
            {
                OnRecetaMedicaChanging(value);
                ReportPropertyChanging("RecetaMedica");
                _RecetaMedica = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("RecetaMedica");
                OnRecetaMedicaChanged();
            }
        }
        private global::System.String _RecetaMedica;
        partial void OnRecetaMedicaChanging(global::System.String value);
        partial void OnRecetaMedicaChanged();

        #endregion

    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ClinicaAspModel", "FK__FormulaMe__IdCit__0EA330E9", "Cita")]
        public Cita Cita
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Cita>("ClinicaAspModel.FK__FormulaMe__IdCit__0EA330E9", "Cita").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Cita>("ClinicaAspModel.FK__FormulaMe__IdCit__0EA330E9", "Cita").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Cita> CitaReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Cita>("ClinicaAspModel.FK__FormulaMe__IdCit__0EA330E9", "Cita");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Cita>("ClinicaAspModel.FK__FormulaMe__IdCit__0EA330E9", "Cita", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ClinicaAspModel", Name="TipoUsuario")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TipoUsuario : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto TipoUsuario.
        /// </summary>
        /// <param name="idTipoUsuario">Valor inicial de la propiedad IdTipoUsuario.</param>
        /// <param name="nombreTipoUsuario">Valor inicial de la propiedad NombreTipoUsuario.</param>
        /// <param name="cedula">Valor inicial de la propiedad Cedula.</param>
        public static TipoUsuario CreateTipoUsuario(global::System.Int32 idTipoUsuario, global::System.String nombreTipoUsuario, global::System.Int32 cedula)
        {
            TipoUsuario tipoUsuario = new TipoUsuario();
            tipoUsuario.IdTipoUsuario = idTipoUsuario;
            tipoUsuario.NombreTipoUsuario = nombreTipoUsuario;
            tipoUsuario.Cedula = cedula;
            return tipoUsuario;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdTipoUsuario
        {
            get
            {
                return _IdTipoUsuario;
            }
            set
            {
                OnIdTipoUsuarioChanging(value);
                ReportPropertyChanging("IdTipoUsuario");
                _IdTipoUsuario = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IdTipoUsuario");
                OnIdTipoUsuarioChanged();
            }
        }
        private global::System.Int32 _IdTipoUsuario;
        partial void OnIdTipoUsuarioChanging(global::System.Int32 value);
        partial void OnIdTipoUsuarioChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String NombreTipoUsuario
        {
            get
            {
                return _NombreTipoUsuario;
            }
            set
            {
                OnNombreTipoUsuarioChanging(value);
                ReportPropertyChanging("NombreTipoUsuario");
                _NombreTipoUsuario = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("NombreTipoUsuario");
                OnNombreTipoUsuarioChanged();
            }
        }
        private global::System.String _NombreTipoUsuario;
        partial void OnNombreTipoUsuarioChanging(global::System.String value);
        partial void OnNombreTipoUsuarioChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Cedula
        {
            get
            {
                return _Cedula;
            }
            set
            {
                if (_Cedula != value)
                {
                    OnCedulaChanging(value);
                    ReportPropertyChanging("Cedula");
                    _Cedula = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Cedula");
                    OnCedulaChanged();
                }
            }
        }
        private global::System.Int32 _Cedula;
        partial void OnCedulaChanging(global::System.Int32 value);
        partial void OnCedulaChanged();

        #endregion

    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ClinicaAspModel", "FK__TipoUsuar__Cedul__0519C6AF", "Usuario")]
        public Usuario Usuario
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Usuario>("ClinicaAspModel.FK__TipoUsuar__Cedul__0519C6AF", "Usuario").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Usuario>("ClinicaAspModel.FK__TipoUsuar__Cedul__0519C6AF", "Usuario").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Usuario> UsuarioReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Usuario>("ClinicaAspModel.FK__TipoUsuar__Cedul__0519C6AF", "Usuario");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Usuario>("ClinicaAspModel.FK__TipoUsuar__Cedul__0519C6AF", "Usuario", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ClinicaAspModel", Name="Usuario")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Usuario : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Usuario.
        /// </summary>
        /// <param name="cedula">Valor inicial de la propiedad Cedula.</param>
        /// <param name="nombreUsuario">Valor inicial de la propiedad NombreUsuario.</param>
        /// <param name="apellidoUsuario">Valor inicial de la propiedad ApellidoUsuario.</param>
        /// <param name="email">Valor inicial de la propiedad Email.</param>
        /// <param name="contrasena">Valor inicial de la propiedad Contrasena.</param>
        /// <param name="anionacimiento">Valor inicial de la propiedad anionacimiento.</param>
        /// <param name="telefono">Valor inicial de la propiedad telefono.</param>
        public static Usuario CreateUsuario(global::System.Int32 cedula, global::System.String nombreUsuario, global::System.String apellidoUsuario, global::System.String email, global::System.String contrasena, global::System.DateTime anionacimiento, global::System.Int32 telefono)
        {
            Usuario usuario = new Usuario();
            usuario.Cedula = cedula;
            usuario.NombreUsuario = nombreUsuario;
            usuario.ApellidoUsuario = apellidoUsuario;
            usuario.Email = email;
            usuario.Contrasena = contrasena;
            usuario.anionacimiento = anionacimiento;
            usuario.telefono = telefono;
            return usuario;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Cedula
        {
            get
            {
                return _Cedula;
            }
            set
            {
                if (_Cedula != value)
                {
                    OnCedulaChanging(value);
                    ReportPropertyChanging("Cedula");
                    _Cedula = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Cedula");
                    OnCedulaChanged();
                }
            }
        }
        private global::System.Int32 _Cedula;
        partial void OnCedulaChanging(global::System.Int32 value);
        partial void OnCedulaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String NombreUsuario
        {
            get
            {
                return _NombreUsuario;
            }
            set
            {
                OnNombreUsuarioChanging(value);
                ReportPropertyChanging("NombreUsuario");
                _NombreUsuario = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("NombreUsuario");
                OnNombreUsuarioChanged();
            }
        }
        private global::System.String _NombreUsuario;
        partial void OnNombreUsuarioChanging(global::System.String value);
        partial void OnNombreUsuarioChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ApellidoUsuario
        {
            get
            {
                return _ApellidoUsuario;
            }
            set
            {
                OnApellidoUsuarioChanging(value);
                ReportPropertyChanging("ApellidoUsuario");
                _ApellidoUsuario = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ApellidoUsuario");
                OnApellidoUsuarioChanged();
            }
        }
        private global::System.String _ApellidoUsuario;
        partial void OnApellidoUsuarioChanging(global::System.String value);
        partial void OnApellidoUsuarioChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Contrasena
        {
            get
            {
                return _Contrasena;
            }
            set
            {
                OnContrasenaChanging(value);
                ReportPropertyChanging("Contrasena");
                _Contrasena = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Contrasena");
                OnContrasenaChanged();
            }
        }
        private global::System.String _Contrasena;
        partial void OnContrasenaChanging(global::System.String value);
        partial void OnContrasenaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime anionacimiento
        {
            get
            {
                return _anionacimiento;
            }
            set
            {
                OnanionacimientoChanging(value);
                ReportPropertyChanging("anionacimiento");
                _anionacimiento = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("anionacimiento");
                OnanionacimientoChanged();
            }
        }
        private global::System.DateTime _anionacimiento;
        partial void OnanionacimientoChanging(global::System.DateTime value);
        partial void OnanionacimientoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 telefono
        {
            get
            {
                return _telefono;
            }
            set
            {
                OntelefonoChanging(value);
                ReportPropertyChanging("telefono");
                _telefono = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("telefono");
                OntelefonoChanged();
            }
        }
        private global::System.Int32 _telefono;
        partial void OntelefonoChanging(global::System.Int32 value);
        partial void OntelefonoChanged();

        #endregion

    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ClinicaAspModel", "FK__Cita__Cedula__09DE7BCC", "Cita")]
        public EntityCollection<Cita> Cita
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Cita>("ClinicaAspModel.FK__Cita__Cedula__09DE7BCC", "Cita");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Cita>("ClinicaAspModel.FK__Cita__Cedula__09DE7BCC", "Cita", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ClinicaAspModel", "FK__TipoUsuar__Cedul__0519C6AF", "TipoUsuario")]
        public TipoUsuario TipoUsuario
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TipoUsuario>("ClinicaAspModel.FK__TipoUsuar__Cedul__0519C6AF", "TipoUsuario").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TipoUsuario>("ClinicaAspModel.FK__TipoUsuar__Cedul__0519C6AF", "TipoUsuario").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<TipoUsuario> TipoUsuarioReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TipoUsuario>("ClinicaAspModel.FK__TipoUsuar__Cedul__0519C6AF", "TipoUsuario");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<TipoUsuario>("ClinicaAspModel.FK__TipoUsuar__Cedul__0519C6AF", "TipoUsuario", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
