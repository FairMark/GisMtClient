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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ФайлДокументСвСчФактГрузОт", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ФайлДокументСвСчФактГрузОт
    {
        
        /// <summary>
        /// <para>Грузоотправитель и его адрес</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Грузоотправитель и его адрес")]
        [System.Xml.Serialization.XmlElementAttribute("ГрузОтпр", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public УчастникТип ГрузОтпр { get; set; }
        
        /// <summary>
        /// <para>Указано «он же»</para>
        /// <para xml:lang="en">Minimum length: 5.</para>
        /// <para xml:lang="en">Maximum length: 5.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Указано «он же»")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(5)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(5)]
        [System.Xml.Serialization.XmlElementAttribute("ОнЖе", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ОнЖе { get; set; }
    }
}
