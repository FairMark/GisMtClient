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
    /// <para>Файл обмена</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute("Файл обмена")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Файл", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Файл", Namespace="")]
    public partial class Файл
    {
        
        /// <summary>
        /// <para>Сведения об участниках электронного документооборота</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Сведения об участниках электронного документооборота")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("СвУчДокОбор", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ФайлСвУчДокОбор СвУчДокОбор { get; set; }
        
        /// <summary>
        /// <para>Счет-фактура, или документ об отгрузке товаров (выполнении работ), передаче имущественных прав (документ об оказании услуг), включающий в себя счет-фактуру (информация продавца), или документ об отгрузке товаров (выполнении работ), передаче имущественных прав (документ об оказании услуг) (информация продавца)</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute(@"Счет-фактура, или документ об отгрузке товаров (выполнении работ), передаче имущественных прав (документ об оказании услуг), включающий в себя счет-фактуру (информация продавца), или документ об отгрузке товаров (выполнении работ), передаче имущественных прав (документ об оказании услуг) (информация продавца)")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Документ", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ФайлДокумент Документ { get; set; }
        
        /// <summary>
        /// <para>Идентификатор файла</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 255.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Идентификатор файла")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(255)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("ИдФайл")]
        public string ИдФайл { get; set; }
        
        /// <summary>
        /// <para>Версия формата</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 5.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Версия формата")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(5)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("ВерсФорм")]
        public string ВерсФорм { get; set; }
        
        /// <summary>
        /// <para>Версия программы, с помощью которой сформирован файл</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 40.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Версия программы, с помощью которой сформирован файл")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(40)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("ВерсПрог")]
        public string ВерсПрог { get; set; }
    }
}
