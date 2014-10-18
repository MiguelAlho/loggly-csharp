//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Loggly.Config
{
    
    
    /// <summary>
    /// The LogglyConfig Configuration Section.
    /// </summary>
    public partial class LogglyConfig : global::System.Configuration.ConfigurationSection
    {
        
        #region Singleton Instance
        /// <summary>
        /// The XML name of the LogglyConfig Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string LogglyConfigSectionName = "loggly";
        
        /// <summary>
        /// The XML path of the LogglyConfig Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string LogglyConfigSectionPath = "loggly";
        
        /// <summary>
        /// Gets the LogglyConfig instance.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public static global::Loggly.Config.LogglyConfig Instance
        {
            get
            {
                return ((global::Loggly.Config.LogglyConfig)(global::System.Configuration.ConfigurationManager.GetSection(global::Loggly.Config.LogglyConfig.LogglyConfigSectionPath)));
            }
        }
        #endregion
        
        #region Xmlns Property
        /// <summary>
        /// The XML name of the <see cref="Xmlns"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string XmlnsPropertyName = "xmlns";
        
        /// <summary>
        /// Gets the XML namespace of this Configuration Section.
        /// </summary>
        /// <remarks>
        /// This property makes sure that if the configuration file contains the XML namespace,
        /// the parser doesn't throw an exception because it encounters the unknown "xmlns" attribute.
        /// </remarks>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Loggly.Config.LogglyConfig.XmlnsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string Xmlns
        {
            get
            {
                return ((string)(base[global::Loggly.Config.LogglyConfig.XmlnsPropertyName]));
            }
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region CustomerToken Property
        /// <summary>
        /// The XML name of the <see cref="CustomerToken"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string CustomerTokenPropertyName = "customerToken";
        
        /// <summary>
        /// Gets or sets the CustomerToken.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The CustomerToken.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Loggly.Config.LogglyConfig.CustomerTokenPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string CustomerToken
        {
            get
            {
                return ((string)(base[global::Loggly.Config.LogglyConfig.CustomerTokenPropertyName]));
            }
            set
            {
                base[global::Loggly.Config.LogglyConfig.CustomerTokenPropertyName] = value;
            }
        }
        #endregion
        
        #region Tags Property
        /// <summary>
        /// The XML name of the <see cref="Tags"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string TagsPropertyName = "tags";
        
        /// <summary>
        /// Gets or sets the Tags.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The Tags.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Loggly.Config.LogglyConfig.TagsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual global::Loggly.Config.TagList Tags
        {
            get
            {
                return ((global::Loggly.Config.TagList)(base[global::Loggly.Config.LogglyConfig.TagsPropertyName]));
            }
            set
            {
                base[global::Loggly.Config.LogglyConfig.TagsPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace Loggly.Config
{
    
    
    /// <summary>
    /// A collection of TagLayout instances.
    /// </summary>
    [global::System.Configuration.ConfigurationCollectionAttribute(typeof(global::Loggly.Config.TagLayout), CollectionType=global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate, AddItemName=global::Loggly.Config.TagList.TagLayoutPropertyName)]
    public partial class TagList : global::System.Configuration.ConfigurationElementCollection
    {
        
        #region Constants
        /// <summary>
        /// The XML name of the individual <see cref="global::Loggly.Config.TagLayout"/> instances in this collection.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string TagLayoutPropertyName = "tagRenderer";
        #endregion
        
        #region Overrides
        /// <summary>
        /// Gets the type of the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <returns>The <see cref="global::System.Configuration.ConfigurationElementCollectionType"/> of this collection.</returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate;
            }
        }
        
        /// <summary>
        /// Gets the name used to identify this collection of elements
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override string ElementName
        {
            get
            {
                return global::Loggly.Config.TagList.TagLayoutPropertyName;
            }
        }
        
        /// <summary>
        /// Indicates whether the specified <see cref="global::System.Configuration.ConfigurationElement"/> exists in the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="elementName">The name of the element to verify.</param>
        /// <returns>
        /// <see langword="true"/> if the element exists in the collection; otherwise, <see langword="false"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override bool IsElementName(string elementName)
        {
            return (elementName == global::Loggly.Config.TagList.TagLayoutPropertyName);
        }
        
        /// <summary>
        /// Gets the element key for the specified configuration element.
        /// </summary>
        /// <param name="element">The <see cref="global::System.Configuration.ConfigurationElement"/> to return the key for.</param>
        /// <returns>
        /// An <see cref="object"/> that acts as the key for the specified <see cref="global::System.Configuration.ConfigurationElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
        {
            return ((global::Loggly.Config.TagLayout)(element)).Key;
        }
        
        /// <summary>
        /// Creates a new <see cref="global::Loggly.Config.TagLayout"/>.
        /// </summary>
        /// <returns>
        /// A new <see cref="global::Loggly.Config.TagLayout"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override global::System.Configuration.ConfigurationElement CreateNewElement()
        {
            return new global::Loggly.Config.TagLayout();
        }
        #endregion
        
        #region Indexer
        /// <summary>
        /// Gets the <see cref="global::Loggly.Config.TagLayout"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::Loggly.Config.TagLayout"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::Loggly.Config.TagLayout this[int index]
        {
            get
            {
                return ((global::Loggly.Config.TagLayout)(base.BaseGet(index)));
            }
        }
        
        /// <summary>
        /// Gets the <see cref="global::Loggly.Config.TagLayout"/> with the specified key.
        /// </summary>
        /// <param name="key">The key of the <see cref="global::Loggly.Config.TagLayout"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::Loggly.Config.TagLayout this[object key]
        {
            get
            {
                return ((global::Loggly.Config.TagLayout)(base.BaseGet(key)));
            }
        }
        #endregion
        
        #region Add
        /// <summary>
        /// Adds the specified <see cref="global::Loggly.Config.TagLayout"/> to the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="tagRenderer">The <see cref="global::Loggly.Config.TagLayout"/> to add.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public void Add(global::Loggly.Config.TagLayout tagRenderer)
        {
            base.BaseAdd(tagRenderer);
        }
        #endregion
        
        #region Remove
        /// <summary>
        /// Removes the specified <see cref="global::Loggly.Config.TagLayout"/> from the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="tagRenderer">The <see cref="global::Loggly.Config.TagLayout"/> to remove.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public void Remove(global::Loggly.Config.TagLayout tagRenderer)
        {
            base.BaseRemove(this.GetElementKey(tagRenderer));
        }
        #endregion
        
        #region GetItem
        /// <summary>
        /// Gets the <see cref="global::Loggly.Config.TagLayout"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::Loggly.Config.TagLayout"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::Loggly.Config.TagLayout GetItemAt(int index)
        {
            return ((global::Loggly.Config.TagLayout)(base.BaseGet(index)));
        }
        
        /// <summary>
        /// Gets the <see cref="global::Loggly.Config.TagLayout"/> with the specified key.
        /// </summary>
        /// <param name="key">The key of the <see cref="global::Loggly.Config.TagLayout"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::Loggly.Config.TagLayout GetItemByKey(string key)
        {
            return ((global::Loggly.Config.TagLayout)(base.BaseGet(((object)(key)))));
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
    }
}
namespace Loggly.Config
{
    
    
    /// <summary>
    /// The TagLayout Configuration Element.
    /// </summary>
    public partial class TagLayout : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Key Property
        /// <summary>
        /// The XML name of the <see cref="Key"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string KeyPropertyName = "key";
        
        /// <summary>
        /// Gets or sets the Key.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The Key.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Loggly.Config.TagLayout.KeyPropertyName, IsRequired=true, IsKey=true, IsDefaultCollection=false)]
        public virtual string Key
        {
            get
            {
                return ((string)(base[global::Loggly.Config.TagLayout.KeyPropertyName]));
            }
            set
            {
                base[global::Loggly.Config.TagLayout.KeyPropertyName] = value;
            }
        }
        #endregion
        
        #region Formatter Property
        /// <summary>
        /// The XML name of the <see cref="Formatter"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string FormatterPropertyName = "formatter";
        
        /// <summary>
        /// Gets or sets the Formatter.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The Formatter.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Loggly.Config.TagLayout.FormatterPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string Formatter
        {
            get
            {
                return ((string)(base[global::Loggly.Config.TagLayout.FormatterPropertyName]));
            }
            set
            {
                base[global::Loggly.Config.TagLayout.FormatterPropertyName] = value;
            }
        }
        #endregion
        
        #region Type Property
        /// <summary>
        /// The XML name of the <see cref="Type"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string TypePropertyName = "type";
        
        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The Type.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Loggly.Config.TagLayout.TypePropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual string Type
        {
            get
            {
                return ((string)(base[global::Loggly.Config.TagLayout.TypePropertyName]));
            }
            set
            {
                base[global::Loggly.Config.TagLayout.TypePropertyName] = value;
            }
        }
        #endregion
    }
}