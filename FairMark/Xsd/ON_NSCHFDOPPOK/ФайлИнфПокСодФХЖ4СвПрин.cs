//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.521.0.
namespace FairMark.Xsd.ON_NSCHFDOPPOK
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.521.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ФайлИнфПокСодФХЖ4СвПрин", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ФайлИнфПокСодФХЖ4СвПрин
    {
        
        /// <summary>
        /// <para>Код содержания операции</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Код содержания операции")]
        [System.Xml.Serialization.XmlElementAttribute("КодСодОпер", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ФайлИнфПокСодФХЖ4СвПринКодСодОпер КодСодОпер { get; set; }
        
        /// <summary>
        /// <para>Сведения о лице, принявшем товары (груз)</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Сведения о лице, принявшем товары (груз)")]
        [System.Xml.Serialization.XmlElementAttribute("СвЛицПрин", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ФайлИнфПокСодФХЖ4СвПринСвЛицПрин СвЛицПрин { get; set; }
        
        /// <summary>
        /// <para>Содержание операции (текст)</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 255.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Содержание операции (текст)")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(255)]
        [System.Xml.Serialization.XmlAttributeAttribute("СодОпер")]
        public string СодОпер { get; set; }
        
        /// <summary>
        /// <para>Дата принятия товаров (результатов выполненных работ), имущественных прав (подтверждения факта оказания услуг)</para>
        /// <para>Дата в формате ДД.ММ.ГГГГ (01.01.1900 - 31.12.2099)</para>
        /// <para xml:lang="en">Minimum length: 10.</para>
        /// <para xml:lang="en">Maximum length: 10.</para>
        /// <para xml:lang="en">Pattern: ((((0[1-9]{1}|1[0-9]{1}|2[0-8]{1})\.(0[1-9]{1}|1[0-2]{1}))|((29|30)\.(01|0[3-9]{1}|1[0-2]{1}))|(31\.(01|03|05|07|08|10|12)))\.((19|20)[0-9]{2}))|(29\.02\.((19|20)(((0|2|4|6|8)(0|4|8))|((1|3|5|7|9)(2|6))))).</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Дата принятия товаров (результатов выполненных работ), имущественных прав (подтве" +
            "рждения факта оказания услуг)")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(10)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(10)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("((((0[1-9]{1}|1[0-9]{1}|2[0-8]{1})\\.(0[1-9]{1}|1[0-2]{1}))|((29|30)\\.(01|0[3-9]{1" +
            "}|1[0-2]{1}))|(31\\.(01|03|05|07|08|10|12)))\\.((19|20)[0-9]{2}))|(29\\.02\\.((19|20" +
            ")(((0|2|4|6|8)(0|4|8))|((1|3|5|7|9)(2|6)))))")]
        [System.Xml.Serialization.XmlAttributeAttribute("ДатаПрин")]
        public string ДатаПрин { get; set; }
    }
}
