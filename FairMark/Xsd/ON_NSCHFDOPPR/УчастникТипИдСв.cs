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
    [System.Xml.Serialization.XmlTypeAttribute("УчастникТипИдСв", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class УчастникТипИдСв
    {
        
        /// <summary>
        /// <para>Сведения об индивидуальном предпринимателе</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Сведения об индивидуальном предпринимателе")]
        [System.Xml.Serialization.XmlElementAttribute("СвИП", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public СвИПТип СвИП { get; set; }
        
        /// <summary>
        /// <para>Сведения о юридическом лице, состоящем на учете в налоговых органах</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Сведения о юридическом лице, состоящем на учете в налоговых органах")]
        [System.Xml.Serialization.XmlElementAttribute("СвЮЛУч", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public УчастникТипИдСвСвЮЛУч СвЮЛУч { get; set; }
        
        /// <summary>
        /// <para>Сведения об иностранном лице, не состоящем на учете в налоговых органах в качестве налогоплательщика</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Сведения об иностранном лице, не состоящем на учете в налоговых органах в качеств" +
            "е налогоплательщика")]
        [System.Xml.Serialization.XmlElementAttribute("СвИнНеУч", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public УчастникТипИдСвСвИнНеУч СвИнНеУч { get; set; }
        
        /// <summary>
        /// <para>Сведения о физическом лице</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Сведения о физическом лице")]
        [System.Xml.Serialization.XmlElementAttribute("СвФЛУчастФХЖ", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public СвФЛТип СвФЛУчастФХЖ { get; set; }
    }
}
