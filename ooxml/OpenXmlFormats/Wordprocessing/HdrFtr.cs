﻿
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using NPOI.OpenXmlFormats.Shared;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{

    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute("hdr", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = false)]
    public class CT_HdrFtr
    {

        private object[] itemsField;

        private ItemsChoiceType8[] itemsElementNameField;

        public CT_HdrFtr()
        {
            this.itemsElementNameField = new ItemsChoiceType8[0];
            this.itemsField = new object[0];
        }

        [System.Xml.Serialization.XmlElementAttribute("oMath", typeof(CT_OMath), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("oMathPara", typeof(CT_OMathPara), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("altChunk", typeof(CT_AltChunk), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("bookmarkEnd", typeof(CT_MarkupRange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("bookmarkStart", typeof(CT_Bookmark), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("commentRangeEnd", typeof(CT_MarkupRange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("commentRangeStart", typeof(CT_MarkupRange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXml", typeof(CT_CustomXmlBlock), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlDelRangeEnd", typeof(CT_Markup), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlDelRangeStart", typeof(CT_TrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlInsRangeEnd", typeof(CT_Markup), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlInsRangeStart", typeof(CT_TrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlMoveFromRangeEnd", typeof(CT_Markup), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlMoveFromRangeStart", typeof(CT_TrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlMoveToRangeEnd", typeof(CT_Markup), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlMoveToRangeStart", typeof(CT_TrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("del", typeof(CT_RunTrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ins", typeof(CT_RunTrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("moveFrom", typeof(CT_RunTrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("moveFromRangeEnd", typeof(CT_MarkupRange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("moveFromRangeStart", typeof(CT_MoveBookmark), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("moveTo", typeof(CT_RunTrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("moveToRangeEnd", typeof(CT_MarkupRange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("moveToRangeStart", typeof(CT_MoveBookmark), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("p", typeof(CT_P), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("permEnd", typeof(CT_Perm), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("permStart", typeof(CT_PermStart), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("proofErr", typeof(CT_ProofErr), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("sdt", typeof(CT_SdtBlock), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("tbl", typeof(CT_Tbl), Order = 0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order = 1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType8[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        public CT_Tbl GetTblArray(int i)
        {
            throw new NotImplementedException();
        }

        public IList<CT_Tbl> GetTblList()
        {
            throw new NotImplementedException();
        }

        public CT_P AddNewP()
        {
            throw new NotImplementedException();
        }

        public void SetPArray(int i, CT_P cT_P)
        {
            throw new NotImplementedException();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
    public enum ItemsChoiceType8
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
        oMath,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
        oMathPara,

        /// <remarks/>
        altChunk,

        /// <remarks/>
        bookmarkEnd,

        /// <remarks/>
        bookmarkStart,

        /// <remarks/>
        commentRangeEnd,

        /// <remarks/>
        commentRangeStart,

        /// <remarks/>
        customXml,

        /// <remarks/>
        customXmlDelRangeEnd,

        /// <remarks/>
        customXmlDelRangeStart,

        /// <remarks/>
        customXmlInsRangeEnd,

        /// <remarks/>
        customXmlInsRangeStart,

        /// <remarks/>
        customXmlMoveFromRangeEnd,

        /// <remarks/>
        customXmlMoveFromRangeStart,

        /// <remarks/>
        customXmlMoveToRangeEnd,

        /// <remarks/>
        customXmlMoveToRangeStart,

        /// <remarks/>
        del,

        /// <remarks/>
        ins,

        /// <remarks/>
        moveFrom,

        /// <remarks/>
        moveFromRangeEnd,

        /// <remarks/>
        moveFromRangeStart,

        /// <remarks/>
        moveTo,

        /// <remarks/>
        moveToRangeEnd,

        /// <remarks/>
        moveToRangeStart,

        /// <remarks/>
        p,

        /// <remarks/>
        permEnd,

        /// <remarks/>
        permStart,

        /// <remarks/>
        proofErr,

        /// <remarks/>
        sdt,

        /// <remarks/>
        tbl,
    }

    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_HdrFtrRef : CT_Rel
    {

        private ST_HdrFtr typeField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_HdrFtr type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_HdrFtr
    {

        /// <remarks/>
        [XmlEnum("even")]
        EVEN,

        [XmlEnum("default")]
        DEFAULT,

       [XmlEnum("first")]
        FIRST,
    }


    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_FtnDocProps))]

    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_FtnProps
    {

        private CT_FtnPos posField;

        private CT_NumFmt numFmtField;

        private CT_DecimalNumber numStartField;

        private CT_NumRestart numRestartField;

        public CT_FtnProps()
        {
            this.numRestartField = new CT_NumRestart();
            this.numStartField = new CT_DecimalNumber();
            this.numFmtField = new CT_NumFmt();
            this.posField = new CT_FtnPos();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CT_FtnPos pos
        {
            get
            {
                return this.posField;
            }
            set
            {
                this.posField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CT_NumFmt numFmt
        {
            get
            {
                return this.numFmtField;
            }
            set
            {
                this.numFmtField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public CT_DecimalNumber numStart
        {
            get
            {
                return this.numStartField;
            }
            set
            {
                this.numStartField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public CT_NumRestart numRestart
        {
            get
            {
                return this.numRestartField;
            }
            set
            {
                this.numRestartField = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_FtnPos
    {

        private ST_FtnPos valField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_FtnPos val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_FtnPos
    {

        /// <remarks/>
        pageBottom,

        /// <remarks/>
        beneathText,

        /// <remarks/>
        sectEnd,

        /// <remarks/>
        docEnd,
    }

    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute("footnotes", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = false)]
    public class CT_Footnotes
    {

        private List<CT_FtnEdn> footnoteField;

        public CT_Footnotes()
        {
            this.footnoteField = new List<CT_FtnEdn>();
        }

        [System.Xml.Serialization.XmlElementAttribute("footnote", Order = 0)]
        public List<CT_FtnEdn> footnote
        {
            get
            {
                return this.footnoteField;
            }
            set
            {
                this.footnoteField = value;
            }
        }
        public CT_FtnEdn AddNewFootnote()
        {
            CT_FtnEdn f = new CT_FtnEdn();
            footnoteField.Add(f);
            return f;
        }

        public IEnumerable<CT_FtnEdn> FootnoteList { get { return footnoteField.AsReadOnly(); } private set{} }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_FtnEdn
    {

        private object[] itemsField;

        private ItemsChoiceType7[] itemsElementNameField;

        private ST_FtnEdn typeField;

        private bool typeFieldSpecified;

        private string idField;

        public CT_FtnEdn()
        {
            this.itemsElementNameField = new ItemsChoiceType7[0];
            this.itemsField = new object[0];
        }

        [System.Xml.Serialization.XmlElementAttribute("oMath", typeof(CT_OMath), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("oMathPara", typeof(CT_OMathPara), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("altChunk", typeof(CT_AltChunk), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("bookmarkEnd", typeof(CT_MarkupRange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("bookmarkStart", typeof(CT_Bookmark), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("commentRangeEnd", typeof(CT_MarkupRange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("commentRangeStart", typeof(CT_MarkupRange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXml", typeof(CT_CustomXmlBlock), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlDelRangeEnd", typeof(CT_Markup), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlDelRangeStart", typeof(CT_TrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlInsRangeEnd", typeof(CT_Markup), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlInsRangeStart", typeof(CT_TrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlMoveFromRangeEnd", typeof(CT_Markup), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlMoveFromRangeStart", typeof(CT_TrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlMoveToRangeEnd", typeof(CT_Markup), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("customXmlMoveToRangeStart", typeof(CT_TrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("del", typeof(CT_RunTrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ins", typeof(CT_RunTrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("moveFrom", typeof(CT_RunTrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("moveFromRangeEnd", typeof(CT_MarkupRange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("moveFromRangeStart", typeof(CT_MoveBookmark), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("moveTo", typeof(CT_RunTrackChange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("moveToRangeEnd", typeof(CT_MarkupRange), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("moveToRangeStart", typeof(CT_MoveBookmark), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("p", typeof(CT_P), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("permEnd", typeof(CT_Perm), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("permStart", typeof(CT_PermStart), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("proofErr", typeof(CT_ProofErr), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("sdt", typeof(CT_SdtBlock), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("tbl", typeof(CT_Tbl), Order = 0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order = 1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType7[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_FtnEdn type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        public void Set(CT_FtnEdn note)
        {
            this.idField = note.idField;
            this.itemsElementNameField = note.itemsElementNameField;
            this.itemsField = note.itemsField;
            this.typeField = note.typeField;
        }

        public IEnumerable<CT_P> GetPList()
        {
            throw new NotImplementedException();
        }

        public IList<CT_Tbl> GetTblList()
        {
            throw new NotImplementedException();
        }

        public CT_Tbl GetTblArray(int i)
        {
            throw new NotImplementedException();
        }

        public CT_Tbl AddNewTbl()
        {
            throw new NotImplementedException();
        }

        public CT_P AddNewP()
        {
            throw new NotImplementedException();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
    public enum ItemsChoiceType7
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
        oMath,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
        oMathPara,

        /// <remarks/>
        altChunk,

        /// <remarks/>
        bookmarkEnd,

        /// <remarks/>
        bookmarkStart,

        /// <remarks/>
        commentRangeEnd,

        /// <remarks/>
        commentRangeStart,

        /// <remarks/>
        customXml,

        /// <remarks/>
        customXmlDelRangeEnd,

        /// <remarks/>
        customXmlDelRangeStart,

        /// <remarks/>
        customXmlInsRangeEnd,

        /// <remarks/>
        customXmlInsRangeStart,

        /// <remarks/>
        customXmlMoveFromRangeEnd,

        /// <remarks/>
        customXmlMoveFromRangeStart,

        /// <remarks/>
        customXmlMoveToRangeEnd,

        /// <remarks/>
        customXmlMoveToRangeStart,

        /// <remarks/>
        del,

        /// <remarks/>
        ins,

        /// <remarks/>
        moveFrom,

        /// <remarks/>
        moveFromRangeEnd,

        /// <remarks/>
        moveFromRangeStart,

        /// <remarks/>
        moveTo,

        /// <remarks/>
        moveToRangeEnd,

        /// <remarks/>
        moveToRangeStart,

        /// <remarks/>
        p,

        /// <remarks/>
        permEnd,

        /// <remarks/>
        permStart,

        /// <remarks/>
        proofErr,

        /// <remarks/>
        sdt,

        /// <remarks/>
        tbl,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_FtnEdn
    {

        /// <remarks/>
        normal,

        /// <remarks/>
        separator,

        /// <remarks/>
        continuationSeparator,

        /// <remarks/>
        continuationNotice,
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute("endnotes", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = false)]
    public class CT_Endnotes
    {

        private List<CT_FtnEdn> endnoteField;

        public CT_Endnotes()
        {
            this.endnoteField = new List<CT_FtnEdn>();
        }

        [System.Xml.Serialization.XmlElementAttribute("endnote", Order = 0)]
        public List<CT_FtnEdn> endnote
        {
            get
            {
                return this.endnoteField;
            }
            set
            {
                this.endnoteField = value;
            }
        }
    }

    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_FtnDocProps : CT_FtnProps
    {

        private List<CT_FtnEdnSepRef> footnoteField;

        public CT_FtnDocProps()
        {
            this.footnoteField = new List<CT_FtnEdnSepRef>();
        }

        [System.Xml.Serialization.XmlElementAttribute("footnote", Order = 0)]
        public List<CT_FtnEdnSepRef> footnote
        {
            get
            {
                return this.footnoteField;
            }
            set
            {
                this.footnoteField = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_FtnEdnSepRef
    {

        private string idField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_EdnDocProps))]

    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_EdnProps
    {

        private CT_EdnPos posField;

        private CT_NumFmt numFmtField;

        private CT_DecimalNumber numStartField;

        private CT_NumRestart numRestartField;

        public CT_EdnProps()
        {
            this.numRestartField = new CT_NumRestart();
            this.numStartField = new CT_DecimalNumber();
            this.numFmtField = new CT_NumFmt();
            this.posField = new CT_EdnPos();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CT_EdnPos pos
        {
            get
            {
                return this.posField;
            }
            set
            {
                this.posField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CT_NumFmt numFmt
        {
            get
            {
                return this.numFmtField;
            }
            set
            {
                this.numFmtField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public CT_DecimalNumber numStart
        {
            get
            {
                return this.numStartField;
            }
            set
            {
                this.numStartField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public CT_NumRestart numRestart
        {
            get
            {
                return this.numRestartField;
            }
            set
            {
                this.numRestartField = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_EdnPos
    {

        private ST_EdnPos valField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_EdnPos val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_EdnPos
    {

        /// <remarks/>
        sectEnd,

        /// <remarks/>
        docEnd,
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_EdnDocProps : CT_EdnProps
    {

        private List<CT_FtnEdnSepRef> endnoteField;

        public CT_EdnDocProps()
        {
            this.endnoteField = new List<CT_FtnEdnSepRef>();
        }

        [System.Xml.Serialization.XmlElementAttribute("endnote", Order = 0)]
        public List<CT_FtnEdnSepRef> endnote
        {
            get
            {
                return this.endnoteField;
            }
            set
            {
                this.endnoteField = value;
            }
        }
    }

    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_FtnEdnRef
    {

        private ST_OnOff customMarkFollowsField;

        private bool customMarkFollowsFieldSpecified;

        private string idField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_OnOff customMarkFollows
        {
            get
            {
                return this.customMarkFollowsField;
            }
            set
            {
                this.customMarkFollowsField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool customMarkFollowsSpecified
        {
            get
            {
                return this.customMarkFollowsFieldSpecified;
            }
            set
            {
                this.customMarkFollowsFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
}