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
    [System.Xml.Serialization.XmlTypeAttribute("ФайлДокументСвСчФакт", Namespace="", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ФайлДокументСвСчФакт
    {
        
        /// <summary>
        /// <para>Исправление (строка 1а счета-фактуры)</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Исправление (строка 1а счета-фактуры)")]
        [System.Xml.Serialization.XmlElementAttribute("ИспрСчФ", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ФайлДокументСвСчФактИспрСчФ ИспрСчФ { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<УчастникТип> _свПрод;
        
        /// <summary>
        /// <para>Сведения о продавце (строки 2, 2а, 2б счета-фактуры)</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Сведения о продавце (строки 2, 2а, 2б счета-фактуры)")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("СвПрод", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<УчастникТип> СвПрод
        {
            get
            {
                return this._свПрод;
            }
            private set
            {
                this._свПрод = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ФайлДокументСвСчФакт" /> class.</para>
        /// </summary>
        public ФайлДокументСвСчФакт()
        {
            this._свПрод = new System.Collections.ObjectModel.Collection<УчастникТип>();
            this._грузОт = new System.Collections.ObjectModel.Collection<ФайлДокументСвСчФактГрузОт>();
            this._грузПолуч = new System.Collections.ObjectModel.Collection<УчастникТип>();
            this._свПРД = new System.Collections.ObjectModel.Collection<ФайлДокументСвСчФактСвПРД>();
            this._свПокуп = new System.Collections.ObjectModel.Collection<УчастникТип>();
            this._докПодтвОтгр = new System.Collections.ObjectModel.Collection<ФайлДокументСвСчФактДокПодтвОтгр>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ФайлДокументСвСчФактГрузОт> _грузОт;
        
        /// <summary>
        /// <para>Сведения о грузоотправителе (строка 3 счета-фактуры)</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Сведения о грузоотправителе (строка 3 счета-фактуры)")]
        [System.Xml.Serialization.XmlElementAttribute("ГрузОт", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<ФайлДокументСвСчФактГрузОт> ГрузОт
        {
            get
            {
                return this._грузОт;
            }
            private set
            {
                this._грузОт = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ГрузОт collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ГрузОтSpecified
        {
            get
            {
                return (this.ГрузОт.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<УчастникТип> _грузПолуч;
        
        /// <summary>
        /// <para>Грузополучатель и его адрес (строка 4 счета-фактуры)</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Грузополучатель и его адрес (строка 4 счета-фактуры)")]
        [System.Xml.Serialization.XmlElementAttribute("ГрузПолуч", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<УчастникТип> ГрузПолуч
        {
            get
            {
                return this._грузПолуч;
            }
            private set
            {
                this._грузПолуч = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ГрузПолуч collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ГрузПолучSpecified
        {
            get
            {
                return (this.ГрузПолуч.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ФайлДокументСвСчФактСвПРД> _свПРД;
        
        /// <summary>
        /// <para>Сведения о платежно-расчетном документе (строка 5 счета-фактуры)</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Сведения о платежно-расчетном документе (строка 5 счета-фактуры)")]
        [System.Xml.Serialization.XmlElementAttribute("СвПРД", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<ФайлДокументСвСчФактСвПРД> СвПРД
        {
            get
            {
                return this._свПРД;
            }
            private set
            {
                this._свПРД = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the СвПРД collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool СвПРДSpecified
        {
            get
            {
                return (this.СвПРД.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<УчастникТип> _свПокуп;
        
        /// <summary>
        /// <para>Сведения о покупателе (строки 6, 6а, 6б счета-фактуры)</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Сведения о покупателе (строки 6, 6а, 6б счета-фактуры)")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("СвПокуп", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<УчастникТип> СвПокуп
        {
            get
            {
                return this._свПокуп;
            }
            private set
            {
                this._свПокуп = value;
            }
        }
        
        /// <summary>
        /// <para>Дополнительные сведения об участниках факта хозяйственной жизни, основаниях и обстоятельствах его проведения</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Дополнительные сведения об участниках факта хозяйственной жизни, основаниях и обс" +
            "тоятельствах его проведения")]
        [System.Xml.Serialization.XmlElementAttribute("ДопСвФХЖ1", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ФайлДокументСвСчФактДопСвФХЖ1 ДопСвФХЖ1 { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ФайлДокументСвСчФактДокПодтвОтгр> _докПодтвОтгр;
        
        /// <summary>
        /// <para>Реквизиты документа, подтверждающего отгрузку товаров (работ, услуг, имущественных прав)</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Реквизиты документа, подтверждающего отгрузку товаров (работ, услуг, имущественны" +
            "х прав)")]
        [System.Xml.Serialization.XmlElementAttribute("ДокПодтвОтгр", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<ФайлДокументСвСчФактДокПодтвОтгр> ДокПодтвОтгр
        {
            get
            {
                return this._докПодтвОтгр;
            }
            private set
            {
                this._докПодтвОтгр = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ДокПодтвОтгр collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ДокПодтвОтгрSpecified
        {
            get
            {
                return (this.ДокПодтвОтгр.Count != 0);
            }
        }
        
        /// <summary>
        /// <para>Информационное поле факта хозяйственной жизни 1</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Информационное поле факта хозяйственной жизни 1")]
        [System.Xml.Serialization.XmlElementAttribute("ИнфПолФХЖ1", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ФайлДокументСвСчФактИнфПолФХЖ1 ИнфПолФХЖ1 { get; set; }
        
        /// <summary>
        /// <para>Порядковый номер счета-фактуры (строка 1 счета-фактуры), документа об отгрузке товаров (выполнении работ), передаче имущественных прав (документа об оказании услуг)</para>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// <para xml:lang="en">Maximum length: 1000.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Порядковый номер счета-фактуры (строка 1 счета-фактуры), документа об отгрузке то" +
            "варов (выполнении работ), передаче имущественных прав (документа об оказании усл" +
            "уг)")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(1000)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("НомерСчФ")]
        public string НомерСчФ { get; set; }
        
        /// <summary>
        /// <para>Дата составления (выписки) счета-фактуры (строка 1 счета-фактуры), документа об отгрузке товаров (выполнении работ), передаче имущественных прав (документа об оказании услуг)</para>
        /// <para>Дата в формате ДД.ММ.ГГГГ (01.01.1900 - 31.12.2099)</para>
        /// <para xml:lang="en">Minimum length: 10.</para>
        /// <para xml:lang="en">Maximum length: 10.</para>
        /// <para xml:lang="en">Pattern: ((((0[1-9]{1}|1[0-9]{1}|2[0-8]{1})\.(0[1-9]{1}|1[0-2]{1}))|((29|30)\.(01|0[3-9]{1}|1[0-2]{1}))|(31\.(01|03|05|07|08|10|12)))\.((19|20)[0-9]{2}))|(29\.02\.((19|20)(((0|2|4|6|8)(0|4|8))|((1|3|5|7|9)(2|6))))).</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Дата составления (выписки) счета-фактуры (строка 1 счета-фактуры), документа об о" +
            "тгрузке товаров (выполнении работ), передаче имущественных прав (документа об ок" +
            "азании услуг)")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(10)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(10)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("((((0[1-9]{1}|1[0-9]{1}|2[0-8]{1})\\.(0[1-9]{1}|1[0-2]{1}))|((29|30)\\.(01|0[3-9]{1" +
            "}|1[0-2]{1}))|(31\\.(01|03|05|07|08|10|12)))\\.((19|20)[0-9]{2}))|(29\\.02\\.((19|20" +
            ")(((0|2|4|6|8)(0|4|8))|((1|3|5|7|9)(2|6)))))")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("ДатаСчФ")]
        public string ДатаСчФ { get; set; }
        
        /// <summary>
        /// <para>Валюта: Код (строка 7 счета-фактуры)</para>
        /// <para>Код из Общероссийского классификатора валют</para>
        /// <para xml:lang="en">Minimum length: 3.</para>
        /// <para xml:lang="en">Maximum length: 3.</para>
        /// <para xml:lang="en">Pattern: [0-9]{3}.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Валюта: Код (строка 7 счета-фактуры)")]
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(3)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(3)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{3}")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("КодОКВ")]
        public string КодОКВ { get; set; }
    }
}
