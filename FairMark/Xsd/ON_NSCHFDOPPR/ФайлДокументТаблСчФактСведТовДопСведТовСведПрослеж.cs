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
    [System.Xml.Serialization.XmlTypeAttribute("ФайлДокументТаблСчФактСведТовДопСведТовСведПрослеж", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ФайлДокументТаблСчФактСведТовДопСведТовСведПрослеж
    {
        
        /// <summary>
        /// <para>Регистрационный номер партии товаров</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 29.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Регистрационный номер партии товаров")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(29)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("НомТовПрослеж")]
        public string НомТовПрослеж { get; set; }
        
        /// <summary>
        /// <para>Единица количественного учета товара, используемая в целях осуществления прослеживаемости</para>
        /// <para>Код из Общероссийского классификатора единиц измерения</para>
        /// <para xml:lang="en">Minimum length: 3.</para>
        /// <para xml:lang="en">Maximum length: 4.</para>
        /// <para xml:lang="en">Pattern: ([0-9]{3})|([0-9]{4}).</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Единица количественного учета товара, используемая в целях осуществления прослежи" +
            "ваемости")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(3)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(4)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([0-9]{3})|([0-9]{4})")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("ЕдИзмПрослеж")]
        public string ЕдИзмПрослеж { get; set; }
        
        /// <summary>
        /// <para>Наименование единицы количественного учета товара, используемой в целях осуществления прослеживаемости</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 255.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Наименование единицы количественного учета товара, используемой в целях осуществл" +
            "ения прослеживаемости")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(255)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("НаимЕдИзмПрослеж")]
        public string НаимЕдИзмПрослеж { get; set; }
        
        /// <summary>
        /// <para>Количество товара в единицах измерения прослеживаемого товара</para>
        /// <para xml:lang="en">Total number of digits: 26.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 11.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Количество товара в единицах измерения прослеживаемого товара")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("КолВЕдПрослеж")]
        public decimal КолВЕдПрослеж { get; set; }
        
        /// <summary>
        /// <para>Дополнительный показатель для идентификации товаров, подлежащих прослеживаемости</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 255.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Дополнительный показатель для идентификации товаров, подлежащих прослеживаемости")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(255)]
        [System.Xml.Serialization.XmlAttributeAttribute("ДопПрослеж")]
        public string ДопПрослеж { get; set; }
    }
}
