//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.521.0.
namespace FairMark.Xsd.ON_NSCHFDOPPR
{
    
    
    /// <summary>
    /// <para>Сумма НДС</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute("Сумма НДС")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("СумНДСТип", Namespace="")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class СумНДСТип
    {
        
        /// <summary>
        /// <para>Значение</para>
        /// <para xml:lang="en">Total number of digits: 19.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Значение")]
        [System.Xml.Serialization.XmlElementAttribute("СумНал", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal СумНал { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the СумНал property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool СумНалSpecified { get; set; }
        
        /// <summary>
        /// <para>Без НДС</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 18.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Без НДС")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(18)]
        [System.Xml.Serialization.XmlElementAttribute("БезНДС", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string БезНДС { get; set; }
        
        /// <summary>
        /// <para>Знак прочерка</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 1.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Знак прочерка")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("ДефНДС", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ДефНДС { get; set; }
    }
}
