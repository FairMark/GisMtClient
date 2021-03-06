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
    /// <para>Адрес в Российской Федерации</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute("Адрес в Российской Федерации")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("АдрРФТип", Namespace="")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class АдрРФТип
    {
        
        /// <summary>
        /// <para>Индекс</para>
        /// <para xml:lang="en">Minimum length: 6.</para>
        /// <para xml:lang="en">Maximum length: 6.</para>
        /// <para xml:lang="en">Pattern: [0-9]{6}.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Индекс")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(6)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(6)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{6}")]
        [System.Xml.Serialization.XmlAttributeAttribute("Индекс")]
        public string Индекс { get; set; }
        
        /// <summary>
        /// <para>Код региона</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Код региона")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("КодРегион")]
        public string КодРегион { get; set; }
        
        /// <summary>
        /// <para>Район</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 50.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Район")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(50)]
        [System.Xml.Serialization.XmlAttributeAttribute("Район")]
        public string Район { get; set; }
        
        /// <summary>
        /// <para>Город</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 50.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Город")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(50)]
        [System.Xml.Serialization.XmlAttributeAttribute("Город")]
        public string Город { get; set; }
        
        /// <summary>
        /// <para>Населенный пункт</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 50.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Населенный пункт")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(50)]
        [System.Xml.Serialization.XmlAttributeAttribute("НаселПункт")]
        public string НаселПункт { get; set; }
        
        /// <summary>
        /// <para>Улица</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 50.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Улица")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(50)]
        [System.Xml.Serialization.XmlAttributeAttribute("Улица")]
        public string Улица { get; set; }
        
        /// <summary>
        /// <para>Дом</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 20.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Дом")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(20)]
        [System.Xml.Serialization.XmlAttributeAttribute("Дом")]
        public string Дом { get; set; }
        
        /// <summary>
        /// <para>Корпус</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 20.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Корпус")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(20)]
        [System.Xml.Serialization.XmlAttributeAttribute("Корпус")]
        public string Корпус { get; set; }
        
        /// <summary>
        /// <para>Квартира</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 20.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Квартира")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(20)]
        [System.Xml.Serialization.XmlAttributeAttribute("Кварт")]
        public string Кварт { get; set; }
    }
}
